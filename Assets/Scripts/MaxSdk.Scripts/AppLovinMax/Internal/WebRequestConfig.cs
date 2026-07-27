using System.Collections.Generic;
using UnityEngine.Networking;

namespace AppLovinMax.Internal
{
	public class WebRequestConfig
	{
		public string EndPoint { get; set; }

		public WebRequestType RequestType { get; set; }

		public DownloadHandler DownloadHandler { get; set; }

		public Dictionary<string, string> QueryParams { get; set; }

		public Dictionary<string, string> Headers { get; set; }

		public object Data { get; set; }

		public string JsonString { get; set; }

		public int MaxRequestAttempts { get; set; }

		public int TimeoutSeconds { get; set; }
	}
}
