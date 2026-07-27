using System;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IGooglePlayConfiguration : IStoreConfiguration
	{
		void SetServiceDisconnectAtInitializeListener(Action action);

		void SetQueryProductDetailsFailedListener(Action<int> action);

		void SetDeferredPurchaseListener(Action<Product> action);

		void SetDeferredProrationUpgradeDowngradeSubscriptionListener(Action<Product> action);

		void SetObfuscatedAccountId(string accountId);

		void SetObfuscatedProfileId(string profileId);

		void SetFetchPurchasesAtInitialize(bool enable);

		void SetFetchPurchasesExcludeDeferred(bool exclude);
	}
}
