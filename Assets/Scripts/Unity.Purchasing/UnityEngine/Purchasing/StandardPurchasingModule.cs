using System;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class StandardPurchasingModule
	{
		private static StandardPurchasingModule instance;

		internal readonly string k_Version;

		public FakeStoreUIMode useFakeStoreUIMode { get; set; }

		public bool useFakeStoreAlways { get; set; }

		public string Version => null;

		public AppStore appStore => default(AppStore);

		public static StandardPurchasingModule Instance()
		{
			return null;
		}

		public static StandardPurchasingModule Instance(AppStore androidStore)
		{
			return null;
		}
	}
}
