using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.Purchasing
{
	[AddComponentMenu("In-App Purchasing/IAP Listener")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	public class IAPListener : MonoBehaviour
	{
		[Serializable]
		public class OnProductsFetchedEvent : UnityEvent<List<Product>>
		{
		}

		[Serializable]
		public class OnProductsFetchFailedEvent : UnityEvent<ProductFetchFailed>
		{
		}

		[Serializable]
		public class OnPurchasesFetchedEvent : UnityEvent<Orders>
		{
		}

		[Serializable]
		public class OnPurchasesFetchFailureEvent : UnityEvent<PurchasesFetchFailureDescription>
		{
		}

		[Serializable]
		public class OnOrderPendingEvent : UnityEvent<PendingOrder>
		{
		}

		[Serializable]
		public class OnOrderConfirmedEvent : UnityEvent<ConfirmedOrder>
		{
		}

		[Serializable]
		public class OnPurchaseFailedEvent : UnityEvent<FailedOrder>
		{
		}

		[Serializable]
		public class OnOrderDeferredEvent : UnityEvent<DeferredOrder>
		{
		}

		[Serializable]
		[Obsolete]
		public class OnProductsFetchedLegacyEvent : UnityEvent<ProductCollection>
		{
		}

		[Serializable]
		[Obsolete]
		public class OnPurchaseCompletedLegacyEvent : UnityEvent<Product>
		{
		}

		[Serializable]
		[Obsolete]
		public class OnPurchaseFailedLegacyEvent : UnityEvent<Product, PurchaseFailureReason>
		{
		}

		[Serializable]
		[Obsolete]
		public class OnPurchaseDetailedFailedLegacyEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
		}

		[Tooltip("Automatically confirm the transaction immediately after a successful purchase.")]
		public bool automaticallyConfirmTransaction;

		[Tooltip("Preserve this GameObject when a new scene is loaded.")]
		public bool dontDestroyOnLoad;

		[Tooltip("Event fired after fetching products.")]
		public OnProductsFetchedEvent onProductsFetched;

		[Tooltip("Event fired after failing to fetch products.")]
		public OnProductsFetchFailedEvent onProductsFetchFailed;

		[Tooltip("Event fired after fetching purchases.")]
		public OnPurchasesFetchedEvent onPurchasesFetched;

		[Tooltip("Event fired after failing to fetch purchases.")]
		public OnPurchasesFetchFailureEvent onPurchasesFetchFailure;

		[Tooltip("Event fired after updating a pending order.")]
		public OnOrderPendingEvent onOrderPending;

		[Tooltip("Event fired after updating a confirmed order.")]
		public OnOrderConfirmedEvent onOrderConfirmed;

		[Tooltip("Event fired after failing to purchase an order.")]
		public OnPurchaseFailedEvent onPurchaseFailed;

		[Tooltip("Event fired after the payment of a purchase was delayed or postponed.")]
		public OnOrderDeferredEvent onOrderDeferred;

		[Header("Obsolete Events (for backward compatibility only)")]
		[FormerlySerializedAs("onProductsFetched")]
		[Tooltip("Event fired after a successful fetching the products from the store.")]
		[Obsolete]
		public OnProductsFetchedLegacyEvent onProductsFetchedLegacy;

		[FormerlySerializedAs("onPurchaseComplete")]
		[Tooltip("Event fired after a successful purchase of this product.")]
		[Obsolete]
		public OnPurchaseCompletedLegacyEvent onPurchaseCompleteLegacy;

		[FormerlySerializedAs("onPurchaseFailed")]
		[Tooltip("Event fired after failing to purchase an order.")]
		[Obsolete]
		public OnPurchaseFailedLegacyEvent onPurchaseFailedLegacy;

		[FormerlySerializedAs("onPurchaseDetailedFailedEvent")]
		[Tooltip("Event fired after failing to purchase an order.")]
		[Obsolete]
		public OnPurchaseDetailedFailedLegacyEvent onPurchaseDetailedFailedLegacy;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnProductsFetched(List<Product> products)
		{
		}

		public void OnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		public void OnPurchasesFetched(Orders orders)
		{
		}

		public void OnPurchasesFetchFailure(PurchasesFetchFailureDescription purchasesFetchFailureDescription)
		{
		}

		public void OnOrderPending(PendingOrder pendingOrder)
		{
		}

		public void OnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
		}

		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
		}
	}
}
