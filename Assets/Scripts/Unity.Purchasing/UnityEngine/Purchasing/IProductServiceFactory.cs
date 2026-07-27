using System;

namespace UnityEngine.Purchasing
{
	internal interface IProductServiceFactory
	{
		void RegisterNewService(string name, Func<IProductService> createFunction);

		void RegisterNewExtendedService(string name, Func<IProductService, ExtensibleProductService> createFunction);

		IProductService Create(IStoreWrapper store);
	}
}
