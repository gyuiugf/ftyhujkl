using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class PresentCodeRedemptionSheetUseCase : IPresentCodeRedemptionSheetUseCase
	{
		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal PresentCodeRedemptionSheetUseCase(INativeAppleStore nativeStore)
		{
		}

		public void PresentCodeRedemptionSheet()
		{
		}
	}
}
