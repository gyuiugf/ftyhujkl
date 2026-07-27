namespace UnityEngine.Purchasing
{
	public interface IGoogleOrderInfo
	{
		string? ObfuscatedAccountId { get; set; }

		string? ObfuscatedProfileId { get; set; }
	}
}
