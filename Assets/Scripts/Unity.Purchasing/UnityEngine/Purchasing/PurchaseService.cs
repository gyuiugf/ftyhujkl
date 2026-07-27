using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	public class PurchaseService : IPurchaseService
	{
		private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase;

		private readonly IPurchaseUseCase m_PurchaseUseCase;

		private readonly IConfirmOrderUseCase m_ConfirmOrderUseCase;

		private readonly ICheckEntitlementUseCase m_CheckEntitlementUseCase;

		internal readonly ObservableCollection<Order> m_Purchases;

		private readonly ReadOnlyObservableCollection<Order> m_PurchasesReadOnly;

		private readonly IStoreWrapper m_StoreWrapper;

		private readonly IAnalyticsClient m_AnalyticsClient;

		private bool m_ProcessFetchedPendingOrders;

		private readonly HashSet<string> m_PurchasesProcessedInSession;

		public IAppleStoreExtendedPurchaseService? Apple => null;

		public IGooglePlayStoreExtendedPurchaseService? Google => null;

		public event Action<PendingOrder>? OnPurchasePending
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

		public event Action<Order>? OnPurchaseConfirmed
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

		public event Action<FailedOrder>? OnPurchaseFailed
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

		public event Action<DeferredOrder>? OnPurchaseDeferred
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

		public event Action<Orders>? OnPurchasesFetched
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

		public event Action<PurchasesFetchFailureDescription>? OnPurchasesFetchFailed
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

		public event Action<Entitlement>? OnCheckEntitlement
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

		public void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess)
		{
		}

		internal PurchaseService(IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient)
		{
		}

		public void PurchaseProduct(Product product)
		{
		}

		public void Purchase(ICart cart)
		{
		}

		internal void PurchaseSucceeded(PendingOrder order)
		{
		}

		private void RemovePendingOrders(PendingOrder order)
		{
		}

		private void RemoveDeferredOrders(PendingOrder pendingOrder)
		{
		}

		internal void PurchaseFailed(FailedOrder order)
		{
		}

		private void PurchaseDeferred(DeferredOrder order)
		{
		}

		public void ConfirmPurchase(PendingOrder order)
		{
		}

		private FailedOrder ConfirmPurchaseValidations(PendingOrder order)
		{
			return null;
		}

		private void OnConfirmSucceeded(PendingOrder pendingOrder, ConfirmedOrder confirmedOrder)
		{
		}

		private void OnConfirmFailed(FailedOrder failedOrder)
		{
		}

		public void FetchPurchases()
		{
		}

		private void OnFetchSuccess(Orders fetchedPurchases)
		{
		}

		private bool WasPurchaseAlreadyProcessed(string transactionId)
		{
			return false;
		}

		private void ProcessPendingOrder(PendingOrder fetchedPurchase)
		{
		}

		private void OnFetchFailure(PurchasesFetchFailureDescription fetchFailed)
		{
		}

		public void CheckEntitlement(Product product)
		{
		}

		private void OnEntitlementChecked(Entitlement entitlement)
		{
		}

		private void UpdateEntitlementOrder(Entitlement entitlement)
		{
		}

		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		protected virtual void RestoreTransactionsInternal(Action<bool, string?>? callback)
		{
		}

		public ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return null;
		}

		internal bool IsStoreConnected()
		{
			return false;
		}
	}
}
