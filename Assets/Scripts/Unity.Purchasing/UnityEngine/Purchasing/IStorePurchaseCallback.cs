namespace UnityEngine.Purchasing
{
	public interface IStorePurchaseCallback
	{
		void OnPurchaseSucceeded(PendingOrder order);

		void OnPurchaseFailed(FailedOrder failedOrder);

		void OnPurchaseDeferred(DeferredOrder deferredOrder);
	}
}
