using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreCheckEntitlementService : IGooglePlayStoreCheckEntitlementService
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private IStoreCheckEntitlementCallback m_EntitlementCallback;

		[Preserve]
		internal GooglePlayStoreCheckEntitlementService(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void CheckEntitlement(ProductDefinition product)
		{
		}

		public void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
		}
	}
}
