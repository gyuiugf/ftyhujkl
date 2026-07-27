namespace UnityEngine.Purchasing
{
	internal class GoogleOrderInfo : OrderInfo, IGoogleOrderInfo
	{
		public string? ObfuscatedAccountId { get; set; }

		public string? ObfuscatedProfileId { get; set; }

		public GoogleOrderInfo(string receipt, string? transactionID, string storeName, string? obfuscatedAccountId, string? obfuscatedProfileId)
			: base(null, null, null)
		{
		}
	}
}
