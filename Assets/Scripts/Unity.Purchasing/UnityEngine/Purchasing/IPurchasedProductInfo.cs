namespace UnityEngine.Purchasing
{
	public interface IPurchasedProductInfo
	{
		string productId { get; }

		SubscriptionInfo? subscriptionInfo { get; }
	}
}
