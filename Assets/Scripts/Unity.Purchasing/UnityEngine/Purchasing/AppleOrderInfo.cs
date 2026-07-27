using System;

namespace UnityEngine.Purchasing
{
	internal class AppleOrderInfo : OrderInfo, IAppleOrderInfo
	{
		private IAppleAppReceiptViewer m_ReceiptViewer;

		public string? AppReceipt => null;

		public string? OriginalTransactionID { get; set; }

		public OwnershipType OwnershipType { get; set; }

		public string StoreName { get; set; }

		public Guid? AppAccountToken { get; set; }

		public string? jwsRepresentation { get; set; }

		public AppleOrderInfo(string transactionID, string storeName, IAppleAppReceiptViewer appReceiptViewer, string? originalTransactionID, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
			: base(null, null, null)
		{
		}
	}
}
