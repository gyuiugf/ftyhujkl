using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class ConfirmedOrder : Order
	{
		public ConfirmedOrder(ICart cart, IOrderInfo info)
			: base(null, null)
		{
		}

		private List<IPurchasedProductInfo> FillPurchasedProductInfo()
		{
			return null;
		}
	}
}
