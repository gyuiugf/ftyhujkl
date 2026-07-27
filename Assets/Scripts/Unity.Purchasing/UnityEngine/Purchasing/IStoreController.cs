using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IStoreController
	{
		ProductCollection products { get; }

		void InitiatePurchase(Product product, string payload);

		void InitiatePurchase(string productId, string payload);

		void InitiatePurchase(Product product);

		void InitiatePurchase(string productId);

		void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, string> failCallback);

		void ConfirmPendingPurchase(Product product);
	}
}
