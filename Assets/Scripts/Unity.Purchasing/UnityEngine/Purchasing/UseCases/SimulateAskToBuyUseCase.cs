using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class SimulateAskToBuyUseCase : ISimulateAskToBuyUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Preserve]
		internal SimulateAskToBuyUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}

		public bool SimulateAskToBuy()
		{
			return false;
		}

		public void SetSimulateAskToBuy(bool value)
		{
		}
	}
}
