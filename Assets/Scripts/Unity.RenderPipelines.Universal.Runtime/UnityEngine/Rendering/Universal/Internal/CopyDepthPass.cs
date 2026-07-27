using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class CopyDepthPass : ScriptableRenderPass
	{
		private static class ShaderConstants
		{
			public static readonly int _CameraDepthAttachment;

			public static readonly int _CameraDepthTexture;

			public static readonly int _ZWriteShaderHandle;
		}

		private class PassData
		{
			internal TextureHandle source;

			internal TextureHandle destination;

			internal UniversalCameraData cameraData;

			internal Material copyDepthMaterial;

			internal int msaaSamples;

			internal bool copyResolvedDepth;

			internal bool copyToDepth;

			internal bool isDstBackbuffer;
		}

		private Material m_CopyDepthMaterial;

		internal bool m_CopyResolvedDepth;

		internal int MsaaSamples { get; set; }

		internal bool CopyToDepth { get; set; }

		internal bool CopyToDepthXR { get; set; }

		internal bool CopyToBackbuffer { get; set; }

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public CopyDepthPass(RenderPassEvent evt, Shader copyDepthShader, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false, string customPassName = null)
		{
		}

		public void Setup(RTHandle source, RTHandle destination)
		{
		}

		public void Dispose()
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle source, bool yflip)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle destination, TextureHandle source, bool bindAsCameraDepth = false, string passName = "Copy Depth")
		{
		}

		public void Render(RenderGraph renderGraph, TextureHandle destination, TextureHandle source, UniversalResourceData resourceData, UniversalCameraData cameraData, bool bindAsCameraDepth = false, string passName = "Copy Depth")
		{
		}
	}
}
