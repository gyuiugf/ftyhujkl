using System;

namespace UnityEngine.Purchasing
{
	internal class iOSStoreBindings : INativeAppleStore, INativeStore
	{
		public bool canMakePayments => false;

		public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback)
		{
		}

		public void RestoreTransactions()
		{
		}

		public void SetAppAccountToken(string token)
		{
		}

		public string AppReceipt()
		{
			return null;
		}

		public void Connect()
		{
		}

		public void AddTransactionObserver()
		{
		}

		public void FetchProducts(string json)
		{
		}

		public void FetchExistingPurchases()
		{
		}

		public void Purchase(string productJSON, string developerPayload)
		{
		}

		public void FinishTransaction(string productJSON, string transactionID)
		{
		}

		public bool CheckEntitlement(string productJSON)
		{
			return false;
		}

		public void FetchStorePromotionOrder()
		{
		}

		public void SetStorePromotionOrder(string json)
		{
		}

		public void FetchStorePromotionVisibility(string productId)
		{
		}

		public void SetStorePromotionVisibility(string productId, string visibility)
		{
		}

		public void InterceptPromotionalPurchases()
		{
		}

		public void ContinuePromotionalPurchases()
		{
		}

		public void PresentCodeRedemptionSheet()
		{
		}

		public void DeallocateMemory(IntPtr pointer)
		{
		}

		public void RefreshAppReceipt()
		{
		}

		public void FetchPurchases(string json)
		{
		}

		public void Purchase(string productJson, string optionsJson, StorefrontChangeCallback callback)
		{
		}
	}
}
