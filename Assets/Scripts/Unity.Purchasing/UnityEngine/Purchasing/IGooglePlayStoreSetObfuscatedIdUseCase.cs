namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStoreSetObfuscatedIdUseCase
	{
		void SetObfuscatedAccountId(string accountId);

		void SetObfuscatedProfileId(string profileId);
	}
}
