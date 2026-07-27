using System;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	public abstract class ExtensiblePurchaseService : IPurchaseService
	{
		private IPurchaseService m_BaseInternalPurchaseService;

		public virtual IAppleStoreExtendedPurchaseService? Apple => null;

		public virtual IGooglePlayStoreExtendedPurchaseService? Google => null;

		public event Action<PendingOrder>? OnPurchasePending
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Order>? OnPurchaseConfirmed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<FailedOrder>? OnPurchaseFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<DeferredOrder>? OnPurchaseDeferred
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Orders>? OnPurchasesFetched
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<PurchasesFetchFailureDescription>? OnPurchasesFetchFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Entitlement>? OnCheckEntitlement
		{
			add
			{
			}
			remove
			{
			}
		}

		protected ExtensiblePurchaseService(IPurchaseService basePurchaseService)
		{
		}

		public virtual void PurchaseProduct(Product product)
		{
		}

		public virtual void Purchase(ICart cart)
		{
		}

		public virtual void ConfirmPurchase(PendingOrder order)
		{
		}

		public virtual void FetchPurchases()
		{
		}

		public virtual void CheckEntitlement(Product product)
		{
		}

		public virtual void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		public virtual ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return null;
		}

		public void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess)
		{
		}
	}
}
