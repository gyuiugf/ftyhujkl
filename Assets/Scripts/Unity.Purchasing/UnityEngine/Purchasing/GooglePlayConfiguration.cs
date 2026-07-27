using System;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration
	{
		public void SetServiceDisconnectAtInitializeListener(Action action)
		{
		}

		public void SetQueryProductDetailsFailedListener(Action<int> action)
		{
		}

		public void SetDeferredPurchaseListener(Action<Product> action)
		{
		}

		public void SetDeferredProrationUpgradeDowngradeSubscriptionListener(Action<Product> action)
		{
		}

		public void SetObfuscatedAccountId(string accountId)
		{
		}

		public void SetObfuscatedProfileId(string profileId)
		{
		}

		public void SetFetchPurchasesAtInitialize(bool enable)
		{
		}

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public void SetFetchPurchasesExcludeDeferred(bool exclude)
		{
		}
	}
}
