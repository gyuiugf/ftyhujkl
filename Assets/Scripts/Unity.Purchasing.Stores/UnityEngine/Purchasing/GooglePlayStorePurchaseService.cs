using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStorePurchaseService : IGooglePlayStorePurchaseService
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		[Preserve]
		internal GooglePlayStorePurchaseService(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void Purchase(ProductDefinition product)
		{
		}
	}
}
