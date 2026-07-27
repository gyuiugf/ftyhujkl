using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class AppleExtensions : IAppleExtensions, IStoreExtension
	{
		public bool simulateAskToBuy
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback)
		{
		}

		public void RestoreTransactions(Action<bool, string> callback)
		{
		}

		public void RegisterPurchaseDeferredListener(Action<Product> callback)
		{
		}

		public string GetTransactionReceiptForProduct(Product _)
		{
			return null;
		}

		public void SetApplicationUsername(string applicationUsername)
		{
		}

		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			return null;
		}

		public Dictionary<string, string> GetProductDetails()
		{
			return null;
		}

		public void ContinuePromotionalPurchases()
		{
		}

		public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible)
		{
		}

		public void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action errorCallback)
		{
		}

		public void SetStorePromotionOrder(List<Product> products)
		{
		}

		public void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action errorCallback)
		{
		}

		public void PresentCodeRedemptionSheet()
		{
		}
	}
}
