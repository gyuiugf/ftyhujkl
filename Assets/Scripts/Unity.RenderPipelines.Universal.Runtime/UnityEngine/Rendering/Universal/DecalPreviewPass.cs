using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DecalPreviewPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RendererListHandle rendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private ProfilingSampler m_ProfilingSampler;

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}
	}
}
