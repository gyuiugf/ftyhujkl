using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class ContinuePromotionalPurchasesUseCase : IContinuePromotionalPurchasesUseCase
	{
		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal ContinuePromotionalPurchasesUseCase(INativeAppleStore nativeStore)
		{
		}

		public void ContinuePromotionalPurchases()
		{
		}
	}
}
