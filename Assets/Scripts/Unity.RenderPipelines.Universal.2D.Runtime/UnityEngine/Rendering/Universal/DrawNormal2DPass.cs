using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DrawNormal2DPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RendererListHandle rendererList;
		}

		private static readonly string k_NormalPass;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ShaderTagId k_NormalsRenderingPassName;

		private static void Execute(RasterCommandBuffer cmd, PassData passData)
		{
		}

		public void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex)
		{
		}
	}
}
