using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	public interface IStoreProductsCallback
	{
		void OnProductsFetched(IReadOnlyList<ProductDescription> products);

		void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription);
	}
}
