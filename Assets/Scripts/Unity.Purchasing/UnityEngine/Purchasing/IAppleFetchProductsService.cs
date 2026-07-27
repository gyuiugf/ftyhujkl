using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal interface IAppleFetchProductsService
	{
		string? LastRequestProductsJson { get; }

		void SetNativeStore(INativeAppleStore nativeStore);

		Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		void OnProductsFetched(string json);

		void OnProductDetailsRetrieveFailed(string errorMessage);
	}
}
