using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public interface IOrderInfo
	{
		IAppleOrderInfo? Apple { get; }

		IGoogleOrderInfo? Google { get; }

		List<IPurchasedProductInfo> PurchasedProductInfo { get; set; }

		string Receipt { get; }

		string TransactionID { get; }
	}
}
