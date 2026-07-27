using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IAppleExtensions : IStoreExtension
	{
		bool simulateAskToBuy { get; set; }

		void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback);

		string GetTransactionReceiptForProduct(Product product);

		void RestoreTransactions(Action<bool, string> callback);

		void RegisterPurchaseDeferredListener(Action<Product> callback);

		void SetApplicationUsername(string applicationUsername);

		void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action errorCallback);

		void SetStorePromotionOrder(List<Product> products);

		void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action errorCallback);

		void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible);

		void ContinuePromotionalPurchases();

		Dictionary<string, string> GetIntroductoryPriceDictionary();

		Dictionary<string, string> GetProductDetails();

		void PresentCodeRedemptionSheet();
	}
}
