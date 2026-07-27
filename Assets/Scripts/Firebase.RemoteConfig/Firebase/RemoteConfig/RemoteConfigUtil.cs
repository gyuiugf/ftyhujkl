using System;
using System.Collections.Generic;

namespace Firebase.RemoteConfig
{
	internal sealed class RemoteConfigUtil
	{
		internal delegate void ConfigUpdateDelegate(string appName, IntPtr configUpdatePtr, int error);

		public static ulong kDefaultCacheExpiration => 0uL;

		public static ulong kDefaultTimeoutInMilliseconds => 0uL;

		public static void ExportFix()
		{
		}

		internal static void SetConfigUpdateCallback(FirebaseRemoteConfigInternal rc, ConfigUpdateDelegate config_listener)
		{
		}

		internal static StringStringMap ConvertDictionaryToMap(IDictionary<string, object> oldMap)
		{
			return null;
		}
	}
}
