using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRenderPass : IRenderGraphRecorder
	{
		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public static RTHandle k_CameraTarget;

		private ProfilingSampler m_ProfingSampler;

		private string m_PassName;

		internal NativeArray<int> m_ColorAttachmentIndices;

		internal NativeArray<int> m_InputAttachmentIndices;

		private ScriptableRenderPassInput m_Input;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public RTHandle[] colorAttachmentHandles => null;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public RTHandle colorAttachmentHandle => null;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public RTHandle depthAttachmentHandle => null;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public RenderBufferStoreAction[] colorStoreActions => null;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public RenderBufferStoreAction depthStoreAction => default(RenderBufferStoreAction);

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public ClearFlag clearFlag => default(ClearFlag);

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public Color clearColor => default(Color);

		public RenderPassEvent renderPassEvent { get; set; }

		public ScriptableRenderPassInput input => default(ScriptableRenderPassInput);

		public bool requiresIntermediateTexture { get; set; }

		protected internal ProfilingSampler profilingSampler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected internal string passName => null;

		internal bool isBlitRenderPass { get; set; }

		internal int renderPassQueueIndex { get; set; }

		internal GraphicsFormat[] renderTargetFormat { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0u)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ResetTarget()
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureTarget(RTHandle colorAttachment)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureTarget(RTHandle[] colorAttachments)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void ConfigureClear(ClearFlag clearFlag, Color clearColor)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0)
		{
		}

		internal static DebugHandler GetActiveDebugHandler(UniversalCameraData cameraData)
		{
			return null;
		}

		public ScriptableRenderPass()
		{
		}

		public void ConfigureInput(ScriptableRenderPassInput passInput)
		{
		}

		public virtual void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}

		public static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}

		internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent)
		{
			return 0;
		}
	}
}
