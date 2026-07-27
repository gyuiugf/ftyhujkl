using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class CanMakePaymentsUseCase : ICanMakePaymentsUseCase
	{
		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal CanMakePaymentsUseCase(INativeAppleStore nativeStore)
		{
		}

		public bool CanMakePayments()
		{
			return false;
		}
	}
}
