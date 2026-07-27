using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayGetGooglePurchaseUseCase
	{
		IGooglePurchase GetGooglePurchase(string purchaseToken);
	}
}
