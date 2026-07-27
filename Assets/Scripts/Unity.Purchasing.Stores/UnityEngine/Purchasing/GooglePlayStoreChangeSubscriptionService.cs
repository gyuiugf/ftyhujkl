using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreChangeSubscriptionService : IGooglePlayStoreChangeSubscriptionService
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		[Preserve]
		internal GooglePlayStoreChangeSubscriptionService(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}
	}
}
