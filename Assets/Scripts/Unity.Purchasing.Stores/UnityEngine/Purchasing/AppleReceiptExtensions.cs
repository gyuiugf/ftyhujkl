using System.Collections.Generic;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	internal static class AppleReceiptExtensions
	{
		public static bool HasInAppPurchaseReceipts(this AppleReceipt? appleReceipt)
		{
			return false;
		}

		public static AppleInAppPurchaseReceipt FindMostRecentReceiptForProduct(this AppleReceipt appleReceipt, string productId)
		{
			return null;
		}

		private static AppleInAppPurchaseReceipt FirstNonCancelledReceipt(IEnumerable<AppleInAppPurchaseReceipt> receipts)
		{
			return null;
		}

		private static bool IsCancelled(this AppleInAppPurchaseReceipt receipt)
		{
			return false;
		}
	}
}
