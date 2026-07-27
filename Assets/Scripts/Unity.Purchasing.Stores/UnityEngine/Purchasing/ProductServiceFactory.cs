using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Services;

namespace UnityEngine.Purchasing
{
	internal class ProductServiceFactory : IProductServiceFactory
	{
		private static ProductServiceFactory? s_Instance;

		private readonly Dictionary<string?, Func<IStoreWrapper, IProductService>> m_ProductServiceInstantiationByName;

		internal static ProductServiceFactory Instance()
		{
			return null;
		}

		private ProductServiceFactory()
		{
		}

		public void RegisterNewService(string name, Func<IProductService> createFunction)
		{
		}

		public void RegisterNewExtendedService(string name, Func<IProductService, ExtensibleProductService> createFunction)
		{
		}

		public IProductService Create(IStoreWrapper store)
		{
			return null;
		}

		private static ProductService CreateGenericProductService(IStoreWrapper storeWrapper)
		{
			return null;
		}

		private static void AddProductServiceDependencies(IStoreWrapper store, IDependencyInjectionService di)
		{
		}

		private static AppleStoreExtendedProductService CreateAppleProductService(IStoreWrapper store)
		{
			return null;
		}
	}
}
