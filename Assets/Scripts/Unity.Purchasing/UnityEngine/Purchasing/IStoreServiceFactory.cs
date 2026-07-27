using System;

namespace UnityEngine.Purchasing
{
	internal interface IStoreServiceFactory
	{
		void RegisterNewService(string name, Func<IStoreService> createFunction);

		void RegisterNewExtendedService(string name, Func<IStoreService, ExtensibleStoreService> createFunction);

		IStoreService Create(IStoreWrapper store, IRetryPolicy? retryPolicy);
	}
}
