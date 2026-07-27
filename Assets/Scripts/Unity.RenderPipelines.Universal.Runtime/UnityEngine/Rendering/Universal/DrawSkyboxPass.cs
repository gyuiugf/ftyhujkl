using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public class DrawSkyboxPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal XRPass xr;

			internal RendererListHandle skyRendererListHandle;

			internal Material material;
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public DrawSkyboxPass(RenderPassEvent evt)
		{
		}

		private RendererListHandle CreateSkyBoxRendererList(RenderGraph renderGraph, UniversalCameraData cameraData)
		{
			return default(RendererListHandle);
		}

		private static void ExecutePass(RasterCommandBuffer cmd, XRPass xr, RendererList rendererList)
		{
		}

		private void InitPassData(ref PassData passData, in XRPass xr, in RendererListHandle handle)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, ScriptableRenderContext context, TextureHandle colorTarget, TextureHandle depthTarget, Material skyboxMaterial)
		{
		}
	}
}
