using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DrawScreenSpaceUIPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RendererListHandle rendererList;
		}

		private class UnsafePassData
		{
			internal RendererListHandle rendererList;

			internal TextureHandle colorTarget;
		}

		private RTHandle m_ColorTarget;

		private RTHandle m_DepthTarget;

		private bool m_RenderOffscreen;

		public DrawScreenSpaceUIPass(RenderPassEvent evt, bool renderOffscreen)
		{
		}

		public static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
		{
		}

		public static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight)
		{
		}

		private static void ExecutePass(RasterCommandBuffer commandBuffer, PassData passData, RendererList rendererList)
		{
		}

		private static void ExecutePass(UnsafeCommandBuffer commandBuffer, UnsafePassData passData, RendererList rendererList)
		{
		}

		public void Dispose()
		{
		}

		public void Setup(UniversalCameraData cameraData, GraphicsFormat depthStencilFormat)
		{
		}

		internal void RenderOffscreen(RenderGraph renderGraph, ContextContainer frameData, GraphicsFormat depthStencilFormat, out TextureHandle output)
		{
			output = default(TextureHandle);
		}

		internal void RenderOverlay(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle colorBuffer, in TextureHandle depthBuffer)
		{
		}
	}
}
