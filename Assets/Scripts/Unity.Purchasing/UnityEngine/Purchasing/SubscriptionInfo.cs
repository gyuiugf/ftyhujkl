using System;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	public class SubscriptionInfo
	{
		private readonly Result m_IsSubscribed;

		private readonly Result m_IsExpired;

		private readonly Result m_IsCancelled;

		private readonly Result m_IsFreeTrial;

		private readonly Result m_IsAutoRenewing;

		private readonly Result m_IsIntroductoryPricePeriod;

		private readonly string m_ProductId;

		private readonly DateTime m_PurchaseDate;

		private readonly DateTime m_SubscriptionExpireDate;

		private readonly DateTime m_SubscriptionCancelDate;

		private readonly TimeSpan m_RemainedTime;

		private readonly string m_IntroductoryPrice;

		private readonly TimeSpan m_IntroductoryPricePeriod;

		private readonly long m_IntroductoryPriceCycles;

		private readonly TimeSpan m_FreeTrialPeriod;

		private readonly TimeSpan m_SubscriptionPeriod;

		private readonly string m_FreeTrialPeriodString;

		private readonly string m_SKUDetails;

		public SubscriptionInfo(AppleInAppPurchaseReceipt r, string introJson)
		{
		}

		public SubscriptionInfo(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata)
		{
		}

		public SubscriptionInfo(string productId)
		{
		}

		public string GetProductId()
		{
			return null;
		}

		[Obsolete("getProductId is deprecated. Please use GetProductId instead.", false)]
		public string getProductId()
		{
			return null;
		}

		public DateTime GetPurchaseDate()
		{
			return default(DateTime);
		}

		[Obsolete("getPurchaseDate is deprecated. Please use GetPurchaseDate instead.", false)]
		public DateTime getPurchaseDate()
		{
			return default(DateTime);
		}

		public Result IsSubscribed()
		{
			return default(Result);
		}

		[Obsolete("isSubscribed is deprecated. Please use IsSubscribed instead.", false)]
		public Result isSubscribed()
		{
			return default(Result);
		}

		public Result IsExpired()
		{
			return default(Result);
		}

		[Obsolete("isExpired is deprecated. Please use IsExpired instead.", false)]
		public Result isExpired()
		{
			return default(Result);
		}

		public Result IsCancelled()
		{
			return default(Result);
		}

		[Obsolete("isCancelled is deprecated. Please use IsCancelled instead.", false)]
		public Result isCancelled()
		{
			return default(Result);
		}

		public Result IsFreeTrial()
		{
			return default(Result);
		}

		[Obsolete("isFreeTrial is deprecated. Please use IsFreeTrial instead.", false)]
		public Result isFreeTrial()
		{
			return default(Result);
		}

		public Result IsAutoRenewing()
		{
			return default(Result);
		}

		[Obsolete("isAutoRenewing is deprecated. Please use IsAutoRenewing instead.", false)]
		public Result isAutoRenewing()
		{
			return default(Result);
		}

		public TimeSpan GetRemainingTime()
		{
			return default(TimeSpan);
		}

		[Obsolete("getRemainingTime is deprecated. Please use GetRemainingTime instead.", false)]
		public TimeSpan getRemainingTime()
		{
			return default(TimeSpan);
		}

		public Result IsIntroductoryPricePeriod()
		{
			return default(Result);
		}

		[Obsolete("isIntroductoryPricePeriod is deprecated. Please use IsIntroductoryPricePeriod instead.", false)]
		public Result isIntroductoryPricePeriod()
		{
			return default(Result);
		}

		public TimeSpan GetIntroductoryPricePeriod()
		{
			return default(TimeSpan);
		}

		[Obsolete("getIntroductoryPricePeriod is deprecated. Please use GetIntroductoryPricePeriod instead.", false)]
		public TimeSpan getIntroductoryPricePeriod()
		{
			return default(TimeSpan);
		}

		public string GetIntroductoryPrice()
		{
			return null;
		}

		[Obsolete("getIntroductoryPrice is deprecated. Please use GetIntroductoryPrice instead.", false)]
		public string getIntroductoryPrice()
		{
			return null;
		}

		public long GetIntroductoryPricePeriodCycles()
		{
			return 0L;
		}

		[Obsolete("getIntroductoryPricePeriodCycles is deprecated. Please use GetIntroductoryPricePeriodCycles instead.", false)]
		public long getIntroductoryPricePeriodCycles()
		{
			return 0L;
		}

		public DateTime GetExpireDate()
		{
			return default(DateTime);
		}

		[Obsolete("getExpireDate is deprecated. Please use GetExpireDate instead.", false)]
		public DateTime getExpireDate()
		{
			return default(DateTime);
		}

		public DateTime GetCancelDate()
		{
			return default(DateTime);
		}

		[Obsolete("getCancelDate is deprecated. Please use GetCancelDate instead.", false)]
		public DateTime getCancelDate()
		{
			return default(DateTime);
		}

		public TimeSpan GetFreeTrialPeriod()
		{
			return default(TimeSpan);
		}

		[Obsolete("getFreeTrialPeriod is deprecated. Please use GetFreeTrialPeriod instead.", false)]
		public TimeSpan getFreeTrialPeriod()
		{
			return default(TimeSpan);
		}

		public TimeSpan GetSubscriptionPeriod()
		{
			return default(TimeSpan);
		}

		[Obsolete("getSubscriptionPeriod is deprecated. Please use GetSubscriptionPeriod instead.", false)]
		public TimeSpan getSubscriptionPeriod()
		{
			return default(TimeSpan);
		}

		public string GetFreeTrialPeriodString()
		{
			return null;
		}

		[Obsolete("getFreeTrialPeriodString is deprecated. Please use GetFreeTrialPeriodString instead.", false)]
		public string getFreeTrialPeriodString()
		{
			return null;
		}

		public string GetSkuDetails()
		{
			return null;
		}

		[Obsolete("getSkuDetails is deprecated. Please use GetSkuDetails instead.", false)]
		public string getSkuDetails()
		{
			return null;
		}

		public string GetSubscriptionInfoJsonString()
		{
			return null;
		}

		[Obsolete("getSubscriptionInfoJsonString is deprecated. Please use GetSubscriptionInfoJsonString instead.", false)]
		public string getSubscriptionInfoJsonString()
		{
			return null;
		}

		private static DateTime NextBillingDate(DateTime billingBeginDate, TimeSpanUnits units)
		{
			return default(DateTime);
		}

		private static TimeSpan AccumulateIntroductoryDuration(TimeSpanUnits units, long cycles)
		{
			return default(TimeSpan);
		}

		private static TimeSpan ComputePeriodTimeSpan(TimeSpanUnits units)
		{
			return default(TimeSpan);
		}

		private static double ComputeExtraTime(string metadata, double newSKUPeriodInSeconds)
		{
			return 0.0;
		}

		private static TimeSpan ParseTimeSpan(string periodString)
		{
			return default(TimeSpan);
		}

		private static TimeSpanUnits ParsePeriodTimeSpanUnits(string timeSpan)
		{
			return null;
		}
	}
}
