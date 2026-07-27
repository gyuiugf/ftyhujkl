using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayPurchaseUseCase : PurchaseUseCase, IGooglePlayChangeSubscriptionUseCase, IGooglePlayChangeSubscriptionCallback, IStorePurchaseCallback
	{
		private readonly List<SubscriptionChangeRequest> m_PendingRequests;

		private IProductCache m_ProductCache;

		public event Action<DeferredPaymentUntilRenewalDateOrder>? OnDeferredPaymentUntilRenewalDate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal GooglePlayPurchaseUseCase(IGooglePlayStore storeResponsible, IProductCache productCache)
			: base(null)
		{
		}

		public void ChangeSubscription(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode)
		{
		}

		private bool IsSubscriptionChangeValid(Order currentOrder, Product newSubscription)
		{
			return false;
		}

		private static bool IsSubscriptionProductValid(Product? subscription)
		{
			return false;
		}

		private bool ConflictingSubscriptionChangeRequestExists(Order currentOrder, Product newSubscription)
		{
			return false;
		}

		private void AddAndSendSubscriptionChangeRequest(SubscriptionChangeRequest subscriptionChangeRequest)
		{
		}

		private IGooglePlayStore? GooglePlayStore()
		{
			return null;
		}

		private void OnSubscriptionChangeFailed(FailedOrder order)
		{
		}

		public void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId)
		{
		}

		internal void InvokeOnDeferredPaymentUntilRenewalDate(DeferredPaymentUntilRenewalDateOrder pendingPurchase)
		{
		}

		public void OnSubscriptionChange(string storeSpecificId)
		{
		}

		private SubscriptionChangeRequest GetMatchingRequest(string productId)
		{
			return null;
		}

		private bool FindExistingPurchaseRequest(Product productToCheckFor)
		{
			return false;
		}

		private void RejectPurchaseDueToPendingDuplicate(Product product)
		{
		}
	}
}
