using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStoreFetchProductsService
	{
		void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		void SetProductsCallback(IStoreProductsCallback productsCallback);
	}
}
