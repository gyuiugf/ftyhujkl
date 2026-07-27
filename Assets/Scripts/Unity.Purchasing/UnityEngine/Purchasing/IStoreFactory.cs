using System;

namespace UnityEngine.Purchasing
{
	internal interface IStoreFactory
	{
		IStoreWrapper CreateStore(string storeName);

		void RegisterStore(string storeName, Func<IStoreWrapper> function);
	}
}
