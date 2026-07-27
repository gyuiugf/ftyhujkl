using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	internal class PurchasingManager : IStoreController
	{
		private readonly ITransactionLog m_TransactionLog;

		private StoreController m_StoreController;

		public bool useTransactionLog { get; set; }

		public ProductCollection products { get; }

		public void InitiatePurchase(Product product, string payload)
		{
		}

		public void InitiatePurchase(string productId, string payload)
		{
		}

		public void InitiatePurchase(Product product)
		{
		}

		public void InitiatePurchase(string productId)
		{
		}

		private static void OnPurchaseFailedAction(FailedOrder failedOrder)
		{
		}

		private void OnPurchasePendingAction(PendingOrder pendingOrder)
		{
		}

		private void OnPurchaseConfirmedAction(Order order)
		{
		}

		private void OnPurchasesFetchedAction(Orders orders)
		{
		}

		private void InvokeProcessPurchase(Product product, Order order)
		{
		}

		private ICart CreateCart(string productId)
		{
			return null;
		}

		private Product FindProductByProductId(string productId)
		{
			return null;
		}

		public void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, string> failCallback)
		{
		}

		public void ConfirmPendingPurchase(Product product)
		{
		}

		private static PendingOrder CreatePendingOrderFromProduct(Product product)
		{
			return null;
		}

		private bool HasRecordedTransaction(string transactionId)
		{
			return false;
		}
	}
}
