using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace Stores.Android.GooglePlay.AAR.Interfaces
{
	internal interface IGooglePurchasesUpdatedHandler
	{
		void HandleUpdatedPurchases(IGoogleBillingResult result, List<IGooglePurchase> purchases);

		void SetProductCache(IProductCache productCache);
	}
}
