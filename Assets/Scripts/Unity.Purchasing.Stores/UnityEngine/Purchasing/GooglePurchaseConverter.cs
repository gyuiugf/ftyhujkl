using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchaseConverter : IGooglePurchaseConverter
	{
		[Preserve]
		internal GooglePurchaseConverter(IProductDetailsConverter productDetailsConverter)
		{
		}

		public Order CreateOrderFromPurchase(IGooglePurchase purchase, IProductCache? productCache)
		{
			return null;
		}

		private static ProductType GetProductType(ICart cart)
		{
			return default(ProductType);
		}

		public ICart CreateCartFromPurchase(IGooglePurchase purchase, IProductCache? productCache)
		{
			return null;
		}

		private Product DefaultProduct(IGooglePurchase purchase)
		{
			return null;
		}
	}
}
