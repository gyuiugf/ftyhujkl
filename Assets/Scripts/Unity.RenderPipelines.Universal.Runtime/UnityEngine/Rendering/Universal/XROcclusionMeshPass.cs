using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public class XROcclusionMeshPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal XRPass xr;

			internal bool isActiveTargetBackBuffer;

			internal bool shouldYFlip;

			internal TextureHandle cameraColorAttachment;
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public bool m_IsActiveTargetBackBuffer;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public XROcclusionMeshPass(RenderPassEvent evt)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData data)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment)
		{
		}
	}
}
