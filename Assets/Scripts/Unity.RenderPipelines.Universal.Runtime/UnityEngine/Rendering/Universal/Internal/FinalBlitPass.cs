using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class FinalBlitPass : ScriptableRenderPass
	{
		private static class BlitPassNames
		{
			public const string NearestSampler = "NearestDebugDraw";

			public const string BilinearSampler = "BilinearDebugDraw";
		}

		private enum BlitType
		{
			Core = 0,
			HDR = 1,
			Count = 2
		}

		private struct BlitMaterialData
		{
			public Material material;

			public int nearestSamplerPass;

			public int bilinearSamplerPass;
		}

		private class PassData
		{
			internal TextureHandle source;

			internal TextureHandle destination;

			internal int sourceID;

			internal Vector4 hdrOutputLuminanceParams;

			internal bool requireSrgbConversion;

			internal bool enableAlphaOutput;

			internal BlitMaterialData blitMaterialData;

			internal UniversalCameraData cameraData;
		}

		private static readonly int s_CameraDepthTextureID;

		private BlitMaterialData[] m_BlitMaterialData;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public FinalBlitPass(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial)
		{
		}

		public void Dispose()
		{
		}

		[Obsolete("Use RTHandles for colorHandle. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle)
		{
		}

		private static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperation, Vector4 hdrOutputParameters, bool rendersOverlayUI)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData data, RTHandle source, RTHandle destination, UniversalCameraData cameraData, Vector4 scaleBias)
		{
		}

		private void InitPassData(UniversalCameraData cameraData, ref PassData passData, BlitType blitType, bool enableAlphaOutput)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, UniversalCameraData cameraData, in TextureHandle src, in TextureHandle dest, TextureHandle overlayUITexture)
		{
		}
	}
}
