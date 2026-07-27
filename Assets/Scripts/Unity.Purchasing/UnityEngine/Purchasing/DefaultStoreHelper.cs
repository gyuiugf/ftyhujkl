namespace UnityEngine.Purchasing
{
	public static class DefaultStoreHelper
	{
		private static string s_DefaultCustomStoreOverrideName;

		public static void OverrideDefaultStoreName(string newDefaultStoreName)
		{
		}

		public static string GetDefaultStoreName()
		{
			return null;
		}

		private static string GetBuiltInDefaultStoreName()
		{
			return null;
		}

		internal static AppStore GetDefaultBuiltInAppStore()
		{
			return default(AppStore);
		}
	}
}
