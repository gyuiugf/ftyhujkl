using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	[SupportedOnRenderer(typeof(UniversalRendererData))]
	[DisallowMultipleRendererFeature("Screen Space Shadows")]
	[Tooltip("Screen Space Shadows")]
	internal class ScreenSpaceShadows : ScriptableRendererFeature
	{
		private class ScreenSpaceShadowsPass : ScriptableRenderPass
		{
			private class PassData
			{
				internal TextureHandle target;

				internal Material material;
			}

			private Material m_Material;

			private ScreenSpaceShadowsSettings m_CurrentSettings;

			private int m_ScreenSpaceShadowmapTextureID;

			internal ScreenSpaceShadowsPass()
			{
			}

			internal bool Setup(ScreenSpaceShadowsSettings featureSettings, Material material)
			{
				return false;
			}

			private void InitPassData(ref PassData passData)
			{
			}

			public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
			{
			}

			private static void ExecutePass(UnsafeCommandBuffer cmd, PassData data, RTHandle target)
			{
			}
		}

		private class ScreenSpaceShadowsPostPass : ScriptableRenderPass
		{
			internal class PassData
			{
				internal UniversalShadowData shadowData;
			}

			internal ScreenSpaceShadowsPostPass()
			{
			}

			private static void ExecutePass(RasterCommandBuffer cmd, UniversalShadowData shadowData)
			{
			}

			public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[SerializeField]
		private ScreenSpaceShadowsSettings m_Settings;

		private Material m_Material;

		private ScreenSpaceShadowsPass m_SSShadowsPass;

		private ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

		private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private bool LoadMaterial()
		{
			return false;
		}
	}
}
