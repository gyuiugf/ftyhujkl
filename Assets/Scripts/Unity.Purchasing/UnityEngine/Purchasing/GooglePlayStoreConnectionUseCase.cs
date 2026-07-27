using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreConnectionUseCase : IGooglePlayStoreConnectionUseCase
	{
		private readonly IGoogleBillingClient m_BillingClient;

		[Preserve]
		public GooglePlayStoreConnectionUseCase(IGoogleBillingClient billingClient)
		{
		}

		public void EndConnection()
		{
		}
	}
}
