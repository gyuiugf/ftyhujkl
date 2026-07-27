namespace UnityEngine.Rendering.Universal
{
	internal class TransparentSettingsPass : ScriptableRenderPass
	{
		private bool m_shouldReceiveShadows;

		public TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported)
		{
		}

		public bool Setup()
		{
			return false;
		}

		public static void ExecutePass(RasterCommandBuffer rasterCommandBuffer)
		{
		}
	}
}
