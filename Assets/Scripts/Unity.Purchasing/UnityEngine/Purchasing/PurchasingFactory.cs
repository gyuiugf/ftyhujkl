using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	internal class PurchasingFactory
	{
		private IStore m_Store;

		private IBaseCatalogProvider m_CatalogProvider;

		public string storeName { get; private set; }

		public IStore service
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void RegisterStore(string name, Store s)
		{
		}

		public void SetCatalogProvider(IBaseCatalogProvider provider)
		{
		}

		public void SetCatalogProviderFunction(Action<Action<List<ProductDefinition>>> func)
		{
		}

		internal IBaseCatalogProvider GetCatalogProvider()
		{
			return null;
		}
	}
}
