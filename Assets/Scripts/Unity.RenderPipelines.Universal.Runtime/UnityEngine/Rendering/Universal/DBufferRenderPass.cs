using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class DBufferRenderPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal DecalDrawDBufferSystem drawSystem;

			internal DBufferSettings settings;

			internal bool decalLayers;

			internal RTHandle dBufferDepth;

			internal RTHandle[] dBufferColorHandles;

			internal RendererListHandle rendererList;
		}

		internal static string[] s_DBufferNames;

		internal static string s_DBufferDepthName;

		private static readonly int s_SSAOTextureID;

		private DecalDrawDBufferSystem m_DrawSystem;

		private DBufferSettings m_Settings;

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private bool m_DecalLayers;

		private TextureHandle[] dbufferHandles;

		public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList, bool renderGraph)
		{
		}

		private static void SetKeywords(RasterCommandBuffer cmd, PassData passData)
		{
		}

		private void InitPassData(ref PassData passData)
		{
		}

		private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
			return default(RendererListParams);
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
