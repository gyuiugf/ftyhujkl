namespace UnityEngine.Purchasing
{
	public class DeferredPaymentUntilRenewalDateOrder
	{
		public Order CurrentOrder { get; }

		public Product SubscriptionOrdered { get; }

		public DeferredPaymentUntilRenewalDateOrder(Order currentOrder, Product subscriptionOrdered)
		{
		}
	}
}
