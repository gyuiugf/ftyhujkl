using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class InvokeOnRenderObjectCallbackPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal TextureHandle colorTarget;

			internal TextureHandle depthTarget;
		}

		public InvokeOnRenderObjectCallbackPass(RenderPassEvent evt)
		{
		}

		internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget)
		{
		}
	}
}
