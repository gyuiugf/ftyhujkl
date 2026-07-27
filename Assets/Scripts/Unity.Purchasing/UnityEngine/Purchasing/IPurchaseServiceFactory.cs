using System;

namespace UnityEngine.Purchasing
{
	internal interface IPurchaseServiceFactory
	{
		void RegisterNewService(string name, Func<IPurchaseService> createFunction);

		void RegisterNewExtendedService(string name, Func<IPurchaseService, ExtensiblePurchaseService> createFunction);

		IPurchaseService Create(IStoreWrapper store);
	}
}
