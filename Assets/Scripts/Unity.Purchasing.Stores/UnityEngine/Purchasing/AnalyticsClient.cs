using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class AnalyticsClient : IAnalyticsClient
	{
		private readonly IAnalyticsAdapter m_Analytics;

		[Preserve]
		internal AnalyticsClient(IAnalyticsAdapter analytics)
		{
		}

		public void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder)
		{
		}

		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}
	}
}
