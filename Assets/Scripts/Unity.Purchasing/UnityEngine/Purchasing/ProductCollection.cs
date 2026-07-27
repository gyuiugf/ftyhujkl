using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class ProductCollection
	{
		private Dictionary<string, Product> m_IdToProduct;

		private Dictionary<string, Product> m_StoreSpecificIdToProduct;

		public HashSet<Product> set => null;

		public Product[] all => null;

		public Product WithID(string id)
		{
			return null;
		}

		public Product WithStoreSpecificID(string id)
		{
			return null;
		}
	}
}
