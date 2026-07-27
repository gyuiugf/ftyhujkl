using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class ProbeVolumeDebugPass : ScriptableRenderPass
	{
		private class WriteApvData
		{
			public ComputeShader computeShader;

			public BufferHandle resultBuffer;

			public Vector2 clickCoordinates;

			public TextureHandle depthBuffer;

			public TextureHandle normalBuffer;
		}

		private ComputeShader m_ComputeShader;

		public ProbeVolumeDebugPass(RenderPassEvent evt, ComputeShader computeShader)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle depthPyramidBuffer, TextureHandle normalBuffer)
		{
		}
	}
}
