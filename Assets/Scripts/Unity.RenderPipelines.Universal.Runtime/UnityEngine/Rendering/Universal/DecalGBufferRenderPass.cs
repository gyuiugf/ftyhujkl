using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	internal class DecalGBufferRenderPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal DecalDrawGBufferSystem drawSystem;

			internal DecalScreenSpaceSettings settings;

			internal bool decalLayers;

			internal UniversalCameraData cameraData;

			internal RendererListHandle rendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private DecalDrawGBufferSystem m_DrawSystem;

		private DecalScreenSpaceSettings m_Settings;

		private DeferredLights m_DeferredLights;

		private bool m_DecalLayers;

		public DecalGBufferRenderPass(DecalScreenSpaceSettings settings, DecalDrawGBufferSystem drawSystem, bool decalLayers)
		{
		}

		internal void Setup(DeferredLights deferredLights)
		{
		}

		private void InitPassData(UniversalCameraData cameraData, ref PassData passData)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
