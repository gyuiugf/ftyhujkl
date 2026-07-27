using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class UpscalePass : ScriptableRenderPass
	{
		private class PassData
		{
			internal TextureHandle source;
		}

		private static readonly string k_UpscalePass;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ProfilingSampler m_ExecuteProfilingSampler;

		private static Material m_BlitMaterial;

		private RTHandle source;

		private RTHandle destination;

		public UpscalePass(RenderPassEvent evt, Material blitMaterial)
		{
		}

		public void Setup(RTHandle colorTargetHandle, int width, int height, FilterMode mode, RenderTextureDescriptor cameraTargetDescriptor, out RTHandle upscaleHandle)
		{
			upscaleHandle = null;
		}

		public void Dispose()
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, RTHandle source)
		{
		}

		public void Render(RenderGraph graph, Camera camera, in TextureHandle cameraColorAttachment, in TextureHandle upscaleHandle)
		{
		}
	}
}
