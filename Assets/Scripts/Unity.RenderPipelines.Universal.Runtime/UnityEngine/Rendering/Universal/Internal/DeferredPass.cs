using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal class DeferredPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal UniversalCameraData cameraData;

			internal UniversalLightData lightData;

			internal UniversalShadowData shadowData;

			internal TextureHandle[] gbuffer;

			internal DeferredLights deferredLights;
		}

		private DeferredLights m_DeferredLights;

		public DeferredPass(RenderPassEvent evt, DeferredLights deferredLights)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, TextureHandle[] gbuffer)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
