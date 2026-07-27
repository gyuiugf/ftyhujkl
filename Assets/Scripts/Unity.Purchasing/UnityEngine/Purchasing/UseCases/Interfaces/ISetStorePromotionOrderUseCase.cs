using System.Collections.Generic;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal interface ISetStorePromotionOrderUseCase
	{
		void SetStorePromotionOrder(List<Product> products);
	}
}
