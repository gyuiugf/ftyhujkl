using System.Collections.Generic;

namespace GooglePlayGames.BasicApi
{
	public static class AuthScopeExtensions
	{
		private static readonly Dictionary<string, AuthScope> _stringToEnumMap;

		private static readonly Dictionary<AuthScope, string> _enumToStringMap;

		public static string GetValue(this AuthScope authScope)
		{
			return null;
		}

		public static AuthScope FromValue(string value)
		{
			return default(AuthScope);
		}
	}
}
