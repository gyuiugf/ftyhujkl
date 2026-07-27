using System;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class SubscriptionManager : SubscriptionInfoHelper
	{
		public static void UpdateSubscription(Product newProduct, Product oldProduct, string developerPayload, Action<Product, string> appleStore, Action<string, string> googleStore)
		{
		}

		public static void UpdateSubscriptionInGooglePlayStore(Product oldProduct, Product newProduct, Action<string, string> googlePlayUpdateCallback)
		{
		}

		public static void UpdateSubscriptionInAppleStore(Product newProduct, string developerPayload, Action<Product, string> appleStoreUpdateCallback)
		{
		}

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public SubscriptionManager(Product product, string intro_json)
			: base(null, null)
		{
		}

		public SubscriptionManager(string receipt, string id, string intro_json)
			: base(null, null)
		{
		}

		public SubscriptionInfo getSubscriptionInfo()
		{
			return null;
		}
	}
}
