using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	[AddComponentMenu("In-App Purchasing/IAP Button")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	public class CodelessIAPButton : MonoBehaviour
	{
		[Serializable]
		public class OnProductFetchedEvent : UnityEvent<Product>
		{
		}

		[Serializable]
		public class OnProductFetchFailedEvent : UnityEvent<ProductDefinition, string>
		{
		}

		[Serializable]
		public class OnPurchaseFetchedEvent : UnityEvent<Order>
		{
		}

		[Serializable]
		public class OnTransactionsRestoredEvent : UnityEvent<bool, string?>
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
		public class OnPurchaseCompletedLegacyEvent : UnityEvent<Product>
		{
		}

		[Serializable]
		[Obsolete]
		public class OnPurchaseFailedLegacyEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
		}

		[HideInInspector]
		public string? productId;

		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public CodelessButtonType buttonType;

		[FormerlySerializedAs("consumePurchase")]
		[Tooltip("Automatically confirm the transaction immediately after a successful purchase.")]
		public bool automaticallyConfirmTransaction;

		[Tooltip("Event fired after fetching a product.")]
		public OnProductFetchedEvent? onProductFetched;

		[Tooltip("Event fired after failing to fetch a product.")]
		public OnProductFetchFailedEvent? onProductFetchFailed;

		[Tooltip("Event fired after fetching a purchase.")]
		public OnPurchaseFetchedEvent? onPurchaseFetched;

		[Tooltip("Event fired after a restore transactions.")]
		public OnTransactionsRestoredEvent? onTransactionsRestored;

		[Tooltip("Event fired after a pending order.")]
		public OnOrderPendingEvent? onOrderPending;

		[Tooltip("Event fired after a confirmed order.")]
		public OnOrderConfirmedEvent? onOrderConfirmed;

		[Tooltip("Event fired after a failed purchase of this product.")]
		public OnPurchaseFailedEvent? onPurchaseFailed;

		[Tooltip("Event fired after the payment of a purchase was delayed or postponed for this product.")]
		public OnOrderDeferredEvent? onOrderDeferred;

		[Header("Obsolete Events (for backward compatibility only)")]
		[FormerlySerializedAs("onPurchaseComplete")]
		[Tooltip("Event fired after a successful purchase of this product.")]
		[Obsolete]
		public OnPurchaseCompletedLegacyEvent? onPurchaseCompleteLegacy;

		[FormerlySerializedAs("onPurchaseFailed")]
		[Tooltip("Event fired after failing to purchase an order.")]
		[Obsolete]
		public OnPurchaseFailedLegacyEvent? onPurchaseFailedLegacy;

		[Tooltip("Button that triggers purchase.")]
		public Button? button;

		private void Start()
		{
		}

		private void AddPurchaseButtonListener()
		{
		}

		private void AddRestoreButtonListener()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PurchaseProduct()
		{
		}

		private void Restore()
		{
		}

		internal bool IsAPurchaseButton()
		{
			return false;
		}

		private bool IsARestoreButton()
		{
			return false;
		}

		public void OnProductFetched(Product product)
		{
		}

		public void OnProductFetchFailed(ProductDefinition product, string failureReason)
		{
		}

		public void OnPurchaseFetched(Order order)
		{
		}

		public void OnTransactionsRestored(bool success, string? error)
		{
		}

		public void OnOrderPending(PendingOrder order)
		{
		}

		public void OnOrderConfirmed(ConfirmedOrder order)
		{
		}

		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		private Button? GetButton()
		{
			return null;
		}

		private void AddButtonToCodelessListener()
		{
		}

		private void RemoveButtonToCodelessListener()
		{
		}

		internal void OnInitCompleted()
		{
		}
	}
}
