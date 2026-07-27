using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.VFX;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRenderer : IDisposable
	{
		private static class Profiling
		{
			private const string k_Name = "ScriptableRenderer";

			public static readonly ProfilingSampler setPerCameraShaderVariables;

			public static readonly ProfilingSampler sortRenderPasses;

			public static readonly ProfilingSampler recordRenderGraph;

			public static readonly ProfilingSampler setupCamera;

			public static readonly ProfilingSampler vfxProcessCamera;

			public static readonly ProfilingSampler addRenderPasses;

			public static readonly ProfilingSampler clearRenderingState;

			public static readonly ProfilingSampler internalFinishRenderingCommon;

			public static readonly ProfilingSampler drawGizmos;

			public static readonly ProfilingSampler drawWireOverlay;

			internal static readonly ProfilingSampler beginXRRendering;

			internal static readonly ProfilingSampler endXRRendering;

			internal static readonly ProfilingSampler initRenderGraphFrame;

			internal static readonly ProfilingSampler setEditorTarget;
		}

		public class RenderingFeatures
		{
			[Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead. #from(2022.2) #breakingFrom(2023.1)", true)]
			public bool cameraStacking { get; set; }

			public bool msaa { get; set; }
		}

		private static class RenderPassBlock
		{
			public static readonly int BeforeRendering;

			public static readonly int MainRenderingOpaque;

			public static readonly int MainRenderingTransparent;

			public static readonly int AfterRendering;
		}

		private class VFXProcessCameraPassData
		{
			internal UniversalRenderingData renderingData;

			internal Camera camera;

			internal VFXCameraXRSettings cameraXRSettings;

			internal XRPass xrPass;
		}

		private class DrawGizmosPassData
		{
			public RendererListHandle gizmoRenderList;

			public TextureHandle color;

			public TextureHandle depth;
		}

		private class DrawWireOverlayPassData
		{
			public RendererListHandle wireOverlayList;
		}

		private class BeginXRPassData
		{
			internal UniversalCameraData cameraData;
		}

		private class EndXRPassData
		{
			public UniversalCameraData cameraData;
		}

		private class DummyData
		{
		}

		private class PassData
		{
			internal ScriptableRenderer renderer;

			internal UniversalCameraData cameraData;

			internal TextureHandle target;

			internal Vector2Int cameraTargetSizeCopy;
		}

		internal struct RenderBlocks : IDisposable
		{
			public struct BlockRange : IDisposable
			{
				private int m_Current;

				private int m_End;

				public int Current => 0;

				public BlockRange(int begin, int end)
				{
					m_Current = 0;
					m_End = 0;
				}

				public BlockRange GetEnumerator()
				{
					return default(BlockRange);
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}
			}

			private NativeArray<RenderPassEvent> m_BlockEventLimits;

			private NativeArray<int> m_BlockRanges;

			private NativeArray<int> m_BlockRangeLengths;

			public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue)
			{
				m_BlockEventLimits = default(NativeArray<RenderPassEvent>);
				m_BlockRanges = default(NativeArray<int>);
				m_BlockRangeLengths = default(NativeArray<int>);
			}

			public void Dispose()
			{
			}

			private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue)
			{
			}

			public int GetLength(int index)
			{
				return 0;
			}

			public BlockRange GetRange(int index)
			{
				return default(BlockRange);
			}
		}

		internal bool hasReleasedRTs;

		internal static ScriptableRenderer current;

		private StoreActionsOptimization m_StoreActionsOptimizationSetting;

		private static bool m_UseOptimizedStoreActions;

		private const int k_RenderPassBlockCount = 4;

		protected static readonly RTHandle k_CameraTarget;

		private List<ScriptableRenderPass> m_ActiveRenderPassQueue;

		private List<ScriptableRendererFeature> m_RendererFeatures;

		private RTHandle m_CameraColorTarget;

		private RTHandle m_CameraDepthTarget;

		private RTHandle m_CameraResolveTarget;

		private bool m_FirstTimeCameraColorTargetIsBound;

		private bool m_FirstTimeCameraDepthTargetIsBound;

		private bool m_IsPipelineExecuting;

		internal bool useRenderPassEnabled;

		private static RenderTargetIdentifier[] m_ActiveColorAttachmentIDs;

		private static RTHandle[] m_ActiveColorAttachments;

		private static RTHandle m_ActiveDepthAttachment;

		private ContextContainer m_frameData;

		private static RenderBufferStoreAction[] m_ActiveColorStoreActions;

		private static RenderBufferStoreAction m_ActiveDepthStoreAction;

		private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopyIDs;

		private static RTHandle[][] m_TrimmedColorAttachmentCopies;

		private static Plane[] s_Planes;

		private static Vector4[] s_VectorPlanes;

		[Obsolete("cameraDepth has been renamed to cameraDepthTarget. #from(2021.1) #breakingFrom(2023.1) (UnityUpgradable) -> cameraDepthTarget", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public RenderTargetIdentifier cameraDepth => default(RenderTargetIdentifier);

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		protected ProfilingSampler profilingExecute { get; set; }

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public RTHandle cameraColorTargetHandle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public RTHandle cameraDepthTargetHandle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal DebugHandler DebugHandler { get; }

		[Obsolete("Use cameraColorTargetHandle. #from(2022.1) #breakingFrom(2023.2)", true)]
		public RenderTargetIdentifier cameraColorTarget => default(RenderTargetIdentifier);

		protected List<ScriptableRendererFeature> rendererFeatures => null;

		protected List<ScriptableRenderPass> activeRenderPassQueue => null;

		public RenderingFeatures supportedRenderingFeatures { get; set; }

		public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes { get; set; }

		internal ContextContainer frameData => null;

		internal bool useDepthPriming { get; set; }

		internal bool stripShadowsOffVariants { get; set; }

		internal bool stripAdditionalLightOffVariants { get; set; }

		internal virtual bool supportsNativeRenderPassRendergraphCompiler => false;

		public virtual bool supportsGPUOcclusion => false;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public static void SetCameraMatrices(CommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		protected void SetupRenderPasses(in RenderingData renderingData)
		{
		}

		public virtual int SupportedCameraStackingTypes()
		{
			return 0;
		}

		public bool SupportsCameraStackingType(CameraRenderType cameraRenderType)
		{
			return false;
		}

		protected internal virtual bool SupportsMotionVectors()
		{
			return false;
		}

		protected internal virtual bool SupportsCameraOpaque()
		{
			return false;
		}

		protected internal virtual bool SupportsCameraNormals()
		{
			return false;
		}

		internal static void SetCameraMatrices(RasterCommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped)
		{
		}

		private void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, bool isTargetFlipped)
		{
		}

		private void SetPerCameraBillboardProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData)
		{
		}

		private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle)
		{
			billboardTangent = default(Vector3);
			billboardNormal = default(Vector3);
			cameraXZAngle = default(float);
		}

		private void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, in UniversalCameraData cameraData, bool isTargetFlipped)
		{
		}

		private static void SetShaderTimeValues(IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime)
		{
		}

		public ScriptableRenderer(ScriptableRendererData data)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		internal virtual void ReleaseRenderTargets()
		{
		}

		public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public virtual void FinishRendering(CommandBuffer cmd)
		{
		}

		public virtual void OnBeginRenderGraphFrame()
		{
		}

		internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
		{
		}

		public virtual void OnEndRenderGraphFrame()
		{
		}

		private void InitRenderGraphFrame(RenderGraph renderGraph)
		{
		}

		internal void ProcessVFXCameraCommand(RenderGraph renderGraph)
		{
		}

		internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, TextureHandle target)
		{
		}

		internal void DrawRenderGraphGizmos(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset)
		{
		}

		internal void DrawRenderGraphWireOverlay(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color)
		{
		}

		internal void BeginRenderGraphXRRendering(RenderGraph renderGraph)
		{
		}

		internal void EndRenderGraphXRRendering(RenderGraph renderGraph)
		{
		}

		private void SetEditorTarget(RenderGraph renderGraph)
		{
		}

		internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
		{
		}

		internal void FinishRenderGraphRendering(CommandBuffer cmd)
		{
		}

		internal virtual void OnFinishRenderGraphRendering(CommandBuffer cmd)
		{
		}

		internal void RecordCustomRenderGraphPassesInEventRange(RenderGraph renderGraph, RenderPassEvent eventStart, RenderPassEvent eventEnd)
		{
		}

		internal void CalculateSplitEventRange(RenderPassEvent startInjectionPoint, RenderPassEvent targetEvent, out RenderPassEvent startEvent, out RenderPassEvent splitEvent, out RenderPassEvent endEvent)
		{
			startEvent = default(RenderPassEvent);
			splitEvent = default(RenderPassEvent);
			endEvent = default(RenderPassEvent);
		}

		internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent startInjectionPoint, RenderPassEvent endInjectionPoint)
		{
		}

		internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent injectionPoint)
		{
		}

		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData)
		{
			return default(ClearFlag);
		}

		protected static ClearFlag GetCameraClearFlag(UniversalCameraData cameraData)
		{
			return default(ClearFlag);
		}

		internal void OnPreCullRenderPasses(in CameraData cameraData)
		{
		}

		internal void AddRenderPasses(ref RenderingData renderingData)
		{
		}

		private static void ClearRenderingState(IBaseCommandBuffer cmd)
		{
		}

		internal void Clear(CameraRenderType cameraType)
		{
		}

		internal bool IsSceneFilteringEnabled(Camera camera)
		{
			return false;
		}

		internal virtual void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		internal virtual void EnableSwapBufferMSAA(bool enable)
		{
		}

		private void InternalFinishRenderingCommon(CommandBuffer cmd, bool resolveFinalTarget)
		{
		}

		private protected int AdjustAndGetScreenMSAASamples(RenderGraph renderGraph, bool useIntermediateColorTarget)
		{
			return 0;
		}

		internal static void SortStable(List<ScriptableRenderPass> list)
		{
		}
	}
}
