namespace UnityEngine.Purchasing
{
	internal class PurchasedProductInfo : IPurchasedProductInfo
	{
		public string productId { get; }

		public SubscriptionInfo? subscriptionInfo { get; private set; }

		public PurchasedProductInfo(string productId, string receipt, ProductType productType)
		{
		}

		private void TryInitSubscriptionInfo(SubscriptionInfoHelper subscriptionInfoHelper)
		{
		}
	}
}
