namespace UnityEngine.Purchasing
{
	public class GoogleProductMetadata : ProductMetadata
	{
		public string originalJson { get; internal set; }

		public string subscriptionPeriod { get; internal set; }

		public string freeTrialPeriod { get; internal set; }

		public string introductoryPrice { get; internal set; }

		public string introductoryPricePeriod { get; internal set; }

		public int introductoryPriceCycles { get; internal set; }

		internal GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
			: base(null, null, null, null, default(decimal))
		{
		}
	}
}
