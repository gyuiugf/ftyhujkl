using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class IDs : IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		private readonly Dictionary<string, string> m_Dic;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Add(string id, params string[] stores)
		{
		}

		public void Add(string id, params object[] stores)
		{
		}

		internal string SpecificIDForStore(string store, string defaultValue)
		{
			return null;
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}
	}
}
