using System;

namespace UnityEngine.Purchasing
{
	internal interface ICheckEntitlementUseCase
	{
		void IsProductEntitled(Product product, Action<Entitlement> onResult);
	}
}
