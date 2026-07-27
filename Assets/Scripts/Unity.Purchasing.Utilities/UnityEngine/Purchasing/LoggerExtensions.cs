using System;

namespace UnityEngine.Purchasing
{
	internal static class LoggerExtensions
	{
		private const string k_IAPLogTag = "InAppPurchasing";

		public static void LogIAP(this ILogger logger, string message)
		{
		}

		public static void LogIAPError(this ILogger logger, string message)
		{
		}

		public static void LogIAPException(this ILogger logger, Exception exception)
		{
		}

		public static void LogIAPWarning(this ILogger logger, string message)
		{
		}
	}
}
