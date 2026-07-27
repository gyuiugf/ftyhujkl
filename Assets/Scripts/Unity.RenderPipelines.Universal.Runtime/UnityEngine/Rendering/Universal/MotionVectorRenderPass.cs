using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal sealed class MotionVectorRenderPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal Camera camera;

			internal XRPass xr;

			internal TextureHandle cameraDepth;

			internal Material cameraMaterial;

			internal RendererListHandle rendererListHdl;

			internal RendererList rendererList;
		}

		public class MotionMatrixPassData
		{
			public MotionVectorsPersistentData motionData;

			public XRPass xr;
		}

		internal const string k_MotionVectorTextureName = "_MotionVectorTexture";

		internal const string k_MotionVectorDepthTextureName = "_MotionVectorDepthTexture";

		internal const GraphicsFormat k_TargetFormat = GraphicsFormat.R16G16_SFloat;

		public const string k_MotionVectorsLightModeTag = "MotionVectors";

		private static readonly string[] s_ShaderTags;

		private static readonly int s_CameraDepthTextureID;

		private static readonly ProfilingSampler s_SetMotionMatrixProfilingSampler;

		private readonly Material m_CameraMaterial;

		private readonly FilteringSettings m_FilteringSettings;

		internal MotionVectorRenderPass(RenderPassEvent evt, Material cameraMaterial, LayerMask opaqueLayerMask)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList)
		{
		}

		private static DrawingSettings GetDrawingSettings(Camera camera, bool supportsDynamicBatching)
		{
			return default(DrawingSettings);
		}

		private static void DrawCameraMotionVectors(RasterCommandBuffer cmd, XRPass xr, Material cameraMaterial)
		{
		}

		private static void DrawObjectMotionVectors(RasterCommandBuffer cmd, XRPass xr, ref RendererList rendererList)
		{
		}

		private void InitPassData(ref PassData passData, UniversalCameraData cameraData)
		{
		}

		private void InitRendererLists(ref PassData passData, ref CullingResults cullResults, bool supportsDynamicBatching, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle cameraDepthTexture, TextureHandle motionVectorColor, TextureHandle motionVectorDepth)
		{
		}

		internal static void SetRenderGraphMotionVectorGlobalMatrices(RenderGraph renderGraph, UniversalCameraData cameraData)
		{
		}
	}
}
