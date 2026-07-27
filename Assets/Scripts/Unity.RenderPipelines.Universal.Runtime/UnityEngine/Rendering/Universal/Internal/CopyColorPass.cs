using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class CopyColorPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal TextureHandle source;

			internal TextureHandle destination;

			internal bool useProceduralBlit;

			internal Material samplingMaterial;

			internal Material copyColorMaterial;

			internal Downsampling downsamplingMethod;

			internal int sampleOffsetShaderHandle;
		}

		private int m_SampleOffsetShaderHandle;

		private Material m_SamplingMaterial;

		private Downsampling m_DownsamplingMethod;

		private Material m_CopyColorMaterial;

		private static readonly string k_CopyColorPassName;

		private static readonly string k_DownsampleAndCopyPassName;

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null, string customPassName = null)
		{
		}

		public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode)
		{
			filterMode = default(FilterMode);
		}

		[Obsolete("Use RTHandles for source and destination #from(2022.1) #breakingFrom(2023.1).", true)]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling)
		{
		}

		public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling)
		{
		}

		private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle source, bool useDrawProceduralBlit)
		{
		}

		internal TextureHandle Render(RenderGraph renderGraph, ContextContainer frameData, out TextureHandle destination, in TextureHandle source, Downsampling downsampling)
		{
			destination = default(TextureHandle);
			return default(TextureHandle);
		}

		internal void RenderToExistingTexture(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle destination, in TextureHandle source, Downsampling downsampling = Downsampling.None)
		{
		}

		private void RenderInternal(RenderGraph renderGraph, in TextureHandle destination, in TextureHandle source, bool useProceduralBlit)
		{
		}

		private void AddDownsampleAndCopyColorRenderPass(RenderGraph renderGraph, in TextureHandle destination, in TextureHandle source, bool useProceduralBlit, string passName)
		{
		}
	}
}
