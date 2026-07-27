using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayGetGooglePurchaseUseCase : IGooglePlayGetGooglePurchaseUseCase
	{
		private readonly IStore m_Store;

		[Preserve]
		public GooglePlayGetGooglePurchaseUseCase(IStore store)
		{
		}

		public IGooglePurchase GetGooglePurchase(string purchaseToken)
		{
			return null;
		}

		private IGooglePlayStore? GooglePlayStore()
		{
			return null;
		}
	}
}
