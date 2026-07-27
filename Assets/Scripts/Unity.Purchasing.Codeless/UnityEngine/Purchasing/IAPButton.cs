using System;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	[RequireComponent(typeof(Button))]
	[AddComponentMenu("In-App Purchasing/IAP Button")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class IAPButton : MonoBehaviour
	{
		public enum ButtonType
		{
			Purchase = 0,
			Restore = 1
		}

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

		[HideInInspector]
		public string? productId;

		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public ButtonType buttonType;

		[Tooltip("Consume the product immediately after a successful purchase.")]
		public bool consumePurchase;

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

		[Tooltip("[Optional] Displays the localized title from the app store.")]
		public Text? titleText;

		[Tooltip("[Optional] Displays the localized description from the app store.")]
		public Text? descriptionText;

		[Tooltip("[Optional] Displays the localized price from the app store.")]
		public Text? priceText;

		public void OnProductFetched(Product product)
		{
		}

		public void OnProductFetchFailed(ProductDefinition product, string failureReason)
		{
		}

		public void OnPurchaseFetched(Order order)
		{
		}

		private void OnTransactionsRestored(bool success, string? error)
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
	}
}
