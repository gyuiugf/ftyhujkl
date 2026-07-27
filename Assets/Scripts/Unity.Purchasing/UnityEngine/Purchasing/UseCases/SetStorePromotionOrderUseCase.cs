using System.Collections.Generic;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class SetStorePromotionOrderUseCase : ISetStorePromotionOrderUseCase
	{
		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal SetStorePromotionOrderUseCase(INativeAppleStore nativeStore)
		{
		}

		public void SetStorePromotionOrder(List<Product> products)
		{
		}
	}
}
