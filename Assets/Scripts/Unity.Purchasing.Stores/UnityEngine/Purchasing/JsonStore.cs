using System;
using System.Collections.Generic;
using Purchasing.Extension;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class JsonStore : InternalStore, IUnityCallback
	{
		protected ICartValidator m_CartValidator;

		protected string m_StoreName;

		private INativeStore? m_Store;

		private bool m_IsRefreshing;

		private Action? m_RefreshCallback;

		protected readonly ILogger Logger;

		private PurchaseFailureDescription? LastPurchaseFailureDescription;

		private StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode;

		private const string k_StoreSpecificErrorCodeKey = "storeSpecificErrorCode";

		public void SetNativeStore(INativeStore native)
		{
		}

		internal JsonStore(ICartValidator cartValidator, ILogger logger, string storeName)
		{
		}

		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		internal void ProcessManagedStoreResponse(List<ProductDefinition>? storeProducts)
		{
		}

		public override void FetchPurchases()
		{
		}

		public void OnProductsFetchFailed(string jsonFailureDescription)
		{
		}

		public void OnPurchasesRetrievalFailed(string jsonFailureDescription)
		{
		}

		public virtual void OnPurchasesFetched(string json)
		{
		}

		internal List<Order> CreateOrdersFromFetchedPurchases(List<ProductDescription> productDescriptions)
		{
			return null;
		}

		public override void Purchase(ICart cart)
		{
		}

		protected virtual void Purchase(ProductDefinition productDefinition, string developerPayload)
		{
		}

		public override void FinishTransaction(PendingOrder pendingOrder)
		{
		}

		protected virtual void FinishTransaction(ProductDefinition? productDefinition, string transactionId)
		{
		}

		public override void Connect()
		{
		}

		public void OnStoreConnectionSucceeded()
		{
		}

		public void OnStoreConnectionFailed(string jsonFailureDescription)
		{
		}

		public override void CheckEntitlement(ProductDefinition product)
		{
		}

		public virtual void OnProductsFetched(string json)
		{
		}

		public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		protected DeferredOrder GenerateDeferredOrder(string id, string receipt, string transactionID)
		{
			return null;
		}

		protected PendingOrder GeneratePendingOrder(string id, string receipt, string transactionID)
		{
			return null;
		}

		protected ConfirmedOrder GenerateConfirmedOrder(string id, string receipt, string transactionID)
		{
			return null;
		}

		protected Product FindProductById(string productId)
		{
			return null;
		}

		public void OnPurchaseFailed(string json)
		{
		}

		public void OnPurchaseFailed(PurchaseFailureDescription failure, string? json = null)
		{
		}

		public virtual void OnPurchaseDeferred(string productDetails)
		{
		}

		public PurchaseFailureDescription? GetLastPurchaseFailureDescription()
		{
			return null;
		}

		public StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode()
		{
			return default(StoreSpecificPurchaseErrorCode);
		}

		private static StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string? json)
		{
			return default(StoreSpecificPurchaseErrorCode);
		}

		public ConnectionState CheckConnectionState()
		{
			return default(ConnectionState);
		}
	}
}
