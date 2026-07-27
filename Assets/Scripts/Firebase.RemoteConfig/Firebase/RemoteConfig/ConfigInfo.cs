using System;

namespace Firebase.RemoteConfig
{
	public sealed class ConfigInfo
	{
		private DateTime UnixEpochUtc;

		public DateTime FetchTime { get; internal set; }

		public DateTime ThrottledEndTime { get; internal set; }

		public LastFetchStatus LastFetchStatus { get; internal set; }

		public FetchFailureReason LastFetchFailureReason { get; internal set; }

		internal ConfigInfo(ConfigInfoInternal configInfoInternal)
		{
		}
	}
}
