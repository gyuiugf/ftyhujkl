using System;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePlayCheckEntitlementUseCase
	{
		void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked);
	}
}
