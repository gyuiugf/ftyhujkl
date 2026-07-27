using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	public interface IBaseCatalogProvider
	{
		void FetchProducts(Action<List<ProductDefinition>> callback);
	}
}
