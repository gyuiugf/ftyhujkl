using System;

namespace UnityEngine.Purchasing
{
	internal interface IFetchPurchasesUseCase
	{
		void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction);
	}
}
