using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public class SimpleCatalogProvider : IBaseCatalogProvider
	{
		private readonly Action<Action<List<ProductDefinition>>> m_Func;

		public SimpleCatalogProvider(Action<Action<List<ProductDefinition>>> func)
		{
		}

		public void FetchProducts(Action<List<ProductDefinition>> callback)
		{
		}
	}
}
