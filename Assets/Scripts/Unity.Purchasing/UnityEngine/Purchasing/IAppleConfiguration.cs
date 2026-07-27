using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IAppleConfiguration : IStoreConfiguration
	{
		string appReceipt { get; }

		bool canMakePayments { get; }

		void SetApplePromotionalPurchaseInterceptorCallback(Action<Product> callback);

		void SetEntitlementsRevokedListener(Action<List<Product>> callback);
	}
}
