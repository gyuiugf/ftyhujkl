namespace UnityEngine.Purchasing
{
	public class AppleProductMetadata : ProductMetadata
	{
		public bool isFamilyShareable { get; }

		internal AppleProductMetadata(ProductMetadata baseProductMetadata, bool isFamilyShareable)
			: base(null, null, null, null, default(decimal))
		{
		}

		internal AppleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice, bool isFamilyShareable)
			: base(null, null, null, null, default(decimal))
		{
		}
	}
}
