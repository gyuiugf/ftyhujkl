using System;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	public interface IPurchaseService
	{
		IAppleStoreExtendedPurchaseService? Apple { get; }

		IGooglePlayStoreExtendedPurchaseService? Google { get; }

		event Action<PendingOrder>? OnPurchasePending;

		event Action<Order>? OnPurchaseConfirmed;

		event Action<FailedOrder>? OnPurchaseFailed;

		event Action<DeferredOrder>? OnPurchaseDeferred;

		event Action<Orders>? OnPurchasesFetched;

		event Action<PurchasesFetchFailureDescription>? OnPurchasesFetchFailed;

		event Action<Entitlement>? OnCheckEntitlement;

		void PurchaseProduct(Product product);

		void Purchase(ICart cart);

		void ConfirmPurchase(PendingOrder order);

		void FetchPurchases();

		void CheckEntitlement(Product product);

		void RestoreTransactions(Action<bool, string?>? callback);

		ReadOnlyObservableCollection<Order> GetPurchases();

		void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess);
	}
}
