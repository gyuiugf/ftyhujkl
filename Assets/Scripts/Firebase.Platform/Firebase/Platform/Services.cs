namespace Firebase.Platform
{
	internal static class Services
	{
		public static IAppConfigExtensions AppConfig { get; internal set; }

		public static IClockService Clock { get; internal set; }

		public static ILoggingService Logging { get; internal set; }

		static Services()
		{
		}
	}
}
