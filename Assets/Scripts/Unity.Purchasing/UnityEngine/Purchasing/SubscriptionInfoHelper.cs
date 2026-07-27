using System.Collections.Generic;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	public class SubscriptionInfoHelper
	{
		private readonly string m_Receipt;

		private readonly string m_ProductId;

		private readonly string m_IntroJson;

		public SubscriptionInfoHelper(Product product, string introJson)
		{
		}

		public SubscriptionInfoHelper(string receipt, string id, string introJson)
		{
		}

		public SubscriptionInfo GetSubscriptionInfo()
		{
			return null;
		}

		private SubscriptionInfo GetAppleAppStoreSubInfo(string payload, string productId)
		{
			return null;
		}

		private static AppleInAppPurchaseReceipt FindMostRecentReceipt(List<AppleInAppPurchaseReceipt> receipts)
		{
			return null;
		}

		private static SubscriptionInfo GetGooglePlayStoreSubInfo(string payload)
		{
			return null;
		}
	}
}
