using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class PendingOrder : Order
	{
		public PendingOrder(ICart cart, IOrderInfo info)
			: base(null, null)
		{
		}

		private List<IPurchasedProductInfo> FillPurchasedProductInfo()
		{
			return null;
		}
	}
}
