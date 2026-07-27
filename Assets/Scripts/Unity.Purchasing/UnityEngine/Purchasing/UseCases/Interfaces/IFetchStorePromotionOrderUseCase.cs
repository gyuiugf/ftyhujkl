using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal interface IFetchStorePromotionOrderUseCase
	{
		void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback);
	}
}
