namespace UnityEngine.Purchasing
{
	public interface IGooglePlayStoreExtendedService : IStoreServiceExtension
	{
		void SetObfuscatedAccountId(string accountId);

		void SetObfuscatedProfileId(string profileId);

		void EndConnection();
	}
}
