using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Singular
{
	[Serializable]
	public class SingularLinkParams
	{
		private string _deeplink;

		private string _passthrough;

		private bool _isDeferred;

		private Dictionary<string, string> _urlParameters;

		[JsonProperty(PropertyName = "deeplink")]
		public string Deeplink
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty(PropertyName = "passthrough")]
		public string Passthrough
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty(PropertyName = "is_deferred")]
		public bool IsDeferred
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[JsonProperty(PropertyName = "url_parameters")]
		public Dictionary<string, string> UrlParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
