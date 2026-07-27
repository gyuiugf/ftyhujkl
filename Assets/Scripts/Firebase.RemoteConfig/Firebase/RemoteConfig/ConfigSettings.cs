namespace Firebase.RemoteConfig
{
	public struct ConfigSettings
	{
		public ulong FetchTimeoutInMilliseconds { get; set; }

		public ulong MinimumFetchIntervalInMilliseconds { get; set; }

		internal static ConfigSettings FromInternal(ConfigSettingsInternal csInternal)
		{
			return default(ConfigSettings);
		}

		internal static ConfigSettingsInternal ToInternal(ConfigSettings cs)
		{
			return null;
		}
	}
}
