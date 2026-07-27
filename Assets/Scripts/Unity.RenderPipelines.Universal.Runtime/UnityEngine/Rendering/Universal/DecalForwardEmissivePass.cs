using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DecalForwardEmissivePass : ScriptableRenderPass
	{
		private class PassData
		{
			internal DecalDrawFowardEmissiveSystem drawSystem;

			internal RendererListHandle rendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private DecalDrawFowardEmissiveSystem m_DrawSystem;

		public DecalForwardEmissivePass(DecalDrawFowardEmissiveSystem drawSystem)
		{
		}

		private void InitPassData(ref PassData passData)
		{
		}

		private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
			return default(RendererListParams);
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}
	}
}
