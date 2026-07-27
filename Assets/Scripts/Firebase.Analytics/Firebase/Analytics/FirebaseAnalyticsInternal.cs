using System.Threading.Tasks;

namespace Firebase.Analytics
{
	internal static class FirebaseAnalyticsInternal
	{
		private static FirebaseApp app;

		private static FirebaseApp App => null;

		public static void ExportFix()
		{
		}

		static FirebaseAnalyticsInternal()
		{
		}

		public static void SetAnalyticsCollectionEnabled(bool enabled)
		{
		}

		public static void LogEvent(string name, string parameterName, string parameterValue)
		{
		}

		public static void LogEvent(string name, string parameterName, double parameterValue)
		{
		}

		public static void LogEvent(string name, string parameterName, long parameterValue)
		{
		}

		public static void LogEvent(string name, string parameterName, int parameterValue)
		{
		}

		public static void LogEvent(string name)
		{
		}

		public static void InitiateOnDeviceConversionMeasurementWithEmailAddress(string emailAddress)
		{
		}

		public static void InitiateOnDeviceConversionMeasurementWithPhoneNumber(string phoneNumber)
		{
		}

		public static void InitiateOnDeviceConversionMeasurementWithHashedEmailAddress(CharVector hashedEmailAddress)
		{
		}

		public static void InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber(CharVector hashedPhoneNumber)
		{
		}

		public static void SetUserProperty(string name, string property)
		{
		}

		public static void SetUserId(string userId)
		{
		}

		public static void SetSessionTimeoutDuration(long milliseconds)
		{
		}

		public static void ResetAnalyticsData()
		{
		}

		public static Task<string> GetAnalyticsInstanceIdAsync()
		{
			return null;
		}

		public static Task<long> GetSessionIdAsync()
		{
			return null;
		}

		public static void LogEvent(string name, StringList parameterNames, VariantList parameterValues)
		{
		}

		public static void SetConsentWithInts(IntIntMap settings)
		{
		}
	}
}
