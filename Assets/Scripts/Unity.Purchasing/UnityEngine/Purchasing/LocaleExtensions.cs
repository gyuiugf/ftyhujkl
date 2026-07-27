namespace UnityEngine.Purchasing
{
	public static class LocaleExtensions
	{
		private static readonly string[] Labels;

		private static readonly TranslationLocale[] GoogleLocales;

		private static readonly TranslationLocale[] AppleLocales;

		private static string[] LabelsWithSupportedPlatforms;

		public static string[] GetLabelsWithSupportedPlatforms()
		{
			return null;
		}

		public static bool SupportedOnApple(this TranslationLocale locale)
		{
			return false;
		}

		public static bool SupportedOnGoogle(this TranslationLocale locale)
		{
			return false;
		}
	}
}
