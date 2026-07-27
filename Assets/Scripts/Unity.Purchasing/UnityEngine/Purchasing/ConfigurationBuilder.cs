using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class ConfigurationBuilder
	{
		private static ConfigurationBuilder instance;

		internal CatalogProvider m_CatalogProvider;

		internal ConfigurationProvider m_ConfigurationProvider;

		public static ConfigurationBuilder Instance(object ignored)
		{
			return null;
		}

		public void AddProduct(string id, ProductType type)
		{
		}

		public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs)
		{
		}

		public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, PayoutDefinition payout)
		{
		}

		public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, IEnumerable<PayoutDefinition> payouts)
		{
		}

		public T Configure<T>()
		{
			return default(T);
		}
	}
}
