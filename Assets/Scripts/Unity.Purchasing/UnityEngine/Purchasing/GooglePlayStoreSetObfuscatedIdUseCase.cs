using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreSetObfuscatedIdUseCase : IGooglePlayStoreSetObfuscatedIdUseCase
	{
		private readonly IGoogleBillingClient m_BillingClient;

		[Preserve]
		internal GooglePlayStoreSetObfuscatedIdUseCase(IGoogleBillingClient billingClient)
		{
		}

		public void SetObfuscatedAccountId(string accountId)
		{
		}

		public void SetObfuscatedProfileId(string profileId)
		{
		}
	}
}
