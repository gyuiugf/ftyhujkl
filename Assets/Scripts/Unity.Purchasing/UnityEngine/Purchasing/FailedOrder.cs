namespace UnityEngine.Purchasing
{
	public class FailedOrder : Order
	{
		private PurchaseFailureReason m_FailureReason;

		private string m_Details;

		public PurchaseFailureReason FailureReason => default(PurchaseFailureReason);

		public string Details => null;

		public FailedOrder(ICart cart, PurchaseFailureReason reason, string details)
			: base(null, null)
		{
		}

		public FailedOrder(Order order, PurchaseFailureReason reason, string details)
			: base(null, null)
		{
		}
	}
}
