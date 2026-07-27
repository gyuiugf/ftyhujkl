using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class OrderInfo : IOrderInfo
	{
		private string m_Receipt;

		public IAppleOrderInfo? Apple => null;

		public IGoogleOrderInfo? Google => null;

		public List<IPurchasedProductInfo> PurchasedProductInfo { get; set; }

		public string TransactionID { get; }

		public string Receipt
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private string GetReceipt()
		{
			return null;
		}

		private void SetReceipt(string receipt)
		{
		}

		public OrderInfo(string receipt, string? transactionID, string storeName)
		{
		}

		private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName)
		{
			return null;
		}
	}
}
