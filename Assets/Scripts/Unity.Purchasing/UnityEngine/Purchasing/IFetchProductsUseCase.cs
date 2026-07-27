using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal interface IFetchProductsUseCase
	{
		void FetchProducts(List<ProductDefinition>? productDefinitions, Action<List<Product>?> fetchSuccessAction, Action<List<ProductDefinition>?, string> fetchFailureAction, IRetryPolicy retryPolicy);
	}
}
