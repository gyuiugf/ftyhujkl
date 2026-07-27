using System;

namespace Firebase
{
	public sealed class AppOptions : IDisposable
	{
		public Uri DatabaseUrl { get; set; }

		public string AppId { get; set; }

		public string ApiKey { get; set; }

		public string MessageSenderId { get; set; }

		public string StorageBucket { get; set; }

		public string ProjectId { get; set; }

		internal string PackageName { get; set; }

		public AppOptions()
		{
		}

		public void Dispose()
		{
		}

		public static AppOptions LoadFromJsonConfig(string json_config)
		{
			return null;
		}

		internal AppOptions(AppOptionsInternal other)
		{
		}

		internal AppOptionsInternal ConvertToInternal()
		{
			return null;
		}
	}
}
