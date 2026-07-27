namespace UnityEngine.Purchasing
{
	public abstract class Order
	{
		public ICart CartOrdered { get; internal set; }

		public IOrderInfo Info { get; }

		protected Order(ICart cart, IOrderInfo info)
		{
		}
	}
}
