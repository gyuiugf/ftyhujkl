using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal class DrawObjectsWithRenderingLayersPass : DrawObjectsPass
	{
		private class RenderingLayersPassData
		{
			internal PassData basePassData;

			internal RenderingLayerUtils.MaskSize maskSize;
		}

		public DrawObjectsWithRenderingLayersPass(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
			: base(null, null, opaque: false, default(RenderPassEvent), default(RenderQueueRange), default(LayerMask), default(StencilState), 0)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle colorTarget, TextureHandle renderingLayersTexture, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, RenderingLayerUtils.MaskSize maskSize, uint batchLayerMask = 4294967295u)
		{
		}
	}
}
