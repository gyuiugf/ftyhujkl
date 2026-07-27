namespace UnityEngine.AdaptivePerformance
{
	public static class AdaptivePerformanceRenderSettings
	{
		private static float s_MaxShadowDistanceMultiplier;

		private static float s_ShadowResolutionMultiplier;

		private static float s_RenderScaleMultiplier;

		private static float s_DecalsMaxDistance;

		public static float MainLightShadowmapResolutionMultiplier => 0f;

		public static float DecalsDrawDistance => 0f;

		public static int MainLightShadowCascadesCountBias { get; }

		public static int ShadowQualityBias { get; }

		public static float LutBias { get; }

		public static float MaxShadowDistanceMultiplier => 0f;

		public static float RenderScaleMultiplier => 0f;

		public static int AntiAliasingQualityBias { get; }

		public static bool SkipDynamicBatching { get; }

		public static bool SkipFrontToBackSorting { get; }

		public static bool SkipTransparentObjects { get; }
	}
}
