using System;

namespace UnityEngine.Purchasing
{
	public interface IAppleOrderInfo
	{
		string? AppReceipt { get; }

		string? OriginalTransactionID { get; set; }

		OwnershipType OwnershipType { get; set; }

		string StoreName { get; set; }

		Guid? AppAccountToken { get; set; }

		string? jwsRepresentation { get; set; }
	}
}
