namespace UnityEngine.Purchasing
{
	public interface IStoreCheckEntitlementCallback
	{
		void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message = null);
	}
}
