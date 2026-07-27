using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public interface IStorePurchaseFetchCallback
	{
		void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders);

		void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason);
	}
}
