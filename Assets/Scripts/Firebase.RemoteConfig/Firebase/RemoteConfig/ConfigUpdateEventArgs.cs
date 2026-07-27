using System;
using System.Collections.Generic;

namespace Firebase.RemoteConfig
{
	public sealed class ConfigUpdateEventArgs : EventArgs
	{
		public IEnumerable<string> UpdatedKeys { get; set; }

		public RemoteConfigError Error { get; set; }
	}
}
