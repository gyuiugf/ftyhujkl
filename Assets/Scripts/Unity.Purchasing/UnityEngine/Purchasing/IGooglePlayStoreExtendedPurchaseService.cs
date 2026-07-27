using System;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	public interface IGooglePlayStoreExtendedPurchaseService : IPurchaseServiceExtension
	{
		event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate;

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct);

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayProrationMode desiredProrationMode);

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayReplacementMode desiredReplacementMode);

		void UpgradeDowngradeSubscription(Order currentOrder, Product newProduct, GooglePlayReplacementMode desiredReplacementMode);

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		bool IsOrderDeferred(Order order);

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		GooglePurchaseState? GetPurchaseState(Order order);

		string GetObfuscatedAccountId(Order order);

		string GetObfuscatedProfileId(Order order);
	}
}
