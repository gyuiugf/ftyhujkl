using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthOnlyPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RendererListHandle rendererList;
		}

		private FilteringSettings m_FilteringSettings;

		private static readonly ShaderTagId k_ShaderTagId;

		private static readonly int s_CameraDepthTextureID;

		internal ShaderTagId shaderTagId { get; set; }

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, RendererList rendererList)
		{
		}

		private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
			return default(RendererListParams);
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle depthTexture, uint batchLayerMask, bool setGlobalDepth)
		{
		}
	}
}
