using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class ProductServiceContainer
	{
		private static ProductServiceContainer? s_Instance;

		private readonly Dictionary<string, IProductService> m_InstantiatedServices;

		internal static ProductServiceContainer Instance()
		{
			return null;
		}

		internal IProductService FindService(string storeName)
		{
			return null;
		}

		internal void SetService(string storeName, IProductService service)
		{
		}
	}
}
