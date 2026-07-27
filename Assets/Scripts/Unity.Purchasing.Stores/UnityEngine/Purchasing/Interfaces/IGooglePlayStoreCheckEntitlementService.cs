namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePlayStoreCheckEntitlementService
	{
		void CheckEntitlement(ProductDefinition product);

		void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback);
	}
}
