using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	internal sealed class Renderer2D : ScriptableRenderer
	{
		private struct RenderPassInputSummary
		{
			internal bool requiresDepthTexture;

			internal bool requiresColorTexture;
		}

		private struct ImportResourceSummary
		{
			internal RenderTargetInfo importInfo;

			internal RenderTargetInfo importInfoDepth;

			internal ImportResourceParams cameraColorParams;

			internal ImportResourceParams cameraDepthParams;

			internal ImportResourceParams backBufferColorParams;

			internal ImportResourceParams backBufferDepthParams;
		}

		private const int k_FinalBlitPassQueueOffset = 1;

		private const int k_AfterFinalBlitPassQueueOffset = 2;

		private static int m_CurrentColorHandle;

		internal RTHandle[] m_RenderGraphCameraColorHandles;

		internal RTHandle m_RenderGraphCameraDepthHandle;

		private RTHandle m_RenderGraphBackbufferColorHandle;

		private RTHandle m_RenderGraphBackbufferDepthHandle;

		private RTHandle m_CameraSortingLayerHandle;

		private Material m_BlitMaterial;

		private Material m_BlitHDRMaterial;

		private Material m_SamplingMaterial;

		private DrawNormal2DPass m_NormalPass;

		private DrawLight2DPass m_LightPass;

		private DrawShadow2DPass m_ShadowPass;

		private DrawRenderer2DPass m_RendererPass;

		private CopyDepthPass m_CopyDepthPass;

		private UpscalePass m_UpscalePass;

		private CopyCameraSortingLayerPass m_CopyCameraSortingLayerPass;

		private FinalBlitPass m_FinalBlitPass;

		private DrawScreenSpaceUIPass m_DrawOffscreenUIPass;

		private DrawScreenSpaceUIPass m_DrawOverlayUIPass;

		private Renderer2DData m_Renderer2DData;

		private LayerBatch[] m_LayerBatches;

		private int m_BatchCount;

		internal bool m_CreateColorTexture;

		internal bool m_CreateDepthTexture;

		private bool ppcUpscaleRT;

		private PostProcessPassRenderGraph m_PostProcessPassRenderGraph;

		private ColorGradingLutPass m_ColorGradingLutPassRenderGraph;

		private RTHandle currentRenderGraphCameraColorHandle => null;

		private RTHandle nextRenderGraphCameraColorHandle => null;

		internal static bool supportsMRT => false;

		internal override bool supportsNativeRenderPassRendergraphCompiler => false;

		public override int SupportedCameraStackingTypes()
		{
			return 0;
		}

		public Renderer2D(Renderer2DData data)
			: base(null)
		{
		}

		internal static bool IsDepthUsageAllowed(ContextContainer frameData, Renderer2DData rendererData)
		{
			return false;
		}

		private bool IsPixelPerfectCameraEnabled(UniversalCameraData cameraData, out PixelPerfectCamera ppc)
		{
			ppc = null;
			return false;
		}

		private RenderPassInputSummary GetRenderPassInputs(UniversalCameraData cameraData)
		{
			return default(RenderPassInputSummary);
		}

		private ImportResourceSummary GetImportResourceSummary(RenderGraph renderGraph, UniversalCameraData cameraData)
		{
			return default(ImportResourceSummary);
		}

		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		private void InitializeLayerBatches()
		{
		}

		private void CreateResources(RenderGraph renderGraph)
		{
		}

		private void CreateCameraNormalsTextures(RenderGraph renderGraph, RenderTextureDescriptor descriptor, int width, int height)
		{
		}

		private void CreateLightTextures(RenderGraph renderGraph, int width, int height)
		{
		}

		private void CreateShadowTextures(RenderGraph renderGraph, int width, int height)
		{
		}

		private void CreateCameraSortingLayerTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor)
		{
		}

		private bool RequiresDepthCopyPass(UniversalCameraData cameraData)
		{
			return false;
		}

		private void CreateCameraDepthCopyTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor)
		{
		}

		public override void OnBeginRenderGraphFrame()
		{
		}

		internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent2D activeRPEvent)
		{
		}

		internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
		{
		}

		public override void OnEndRenderGraphFrame()
		{
		}

		internal override void OnFinishRenderGraphRendering(CommandBuffer cmd)
		{
		}

		private void OnBeforeRendering(RenderGraph renderGraph)
		{
		}

		private void OnMainRendering(RenderGraph renderGraph)
		{
		}

		private void OnAfterRendering(RenderGraph renderGraph)
		{
		}

		public Renderer2DData GetRenderer2DData()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void CleanupRenderGraphResources()
		{
		}

		internal static bool IsGLESDevice()
		{
			return false;
		}
	}
}
