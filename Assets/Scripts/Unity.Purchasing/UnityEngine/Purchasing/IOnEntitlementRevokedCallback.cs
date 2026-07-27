namespace UnityEngine.Purchasing
{
	public interface IOnEntitlementRevokedCallback
	{
		void onEntitlementRevoked(string productId);
	}
}
