using System;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		void UpgradeDowngradeSubscription(string oldSku, string newSku);

		void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode);

		void UpgradeDowngradeSubscription(string oldSku, string newSku, GooglePlayProrationMode desiredProrationMode);

		void RestoreTransactions(Action<bool, string> callback);

		[Obsolete("No longer functional. This calls launchPriceChangeConfirmationFlow which was removed from Google Play Billing Library 6.0.0")]
		void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback);

		bool IsPurchasedProductDeferred(Product product);

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		GooglePurchaseState GetPurchaseState(Product product);

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		string GetObfuscatedAccountId(Product product);

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		string GetObfuscatedProfileId(Product product);
	}
}
