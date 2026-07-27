using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchaseService
	{
		void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode);

		void SetProductCache(IProductCache productCache);
	}
}
