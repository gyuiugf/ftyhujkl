using System.Collections.Generic;

namespace GooglePlayGames.BasicApi
{
	public class AuthResponse
	{
		private readonly string _authCode;

		private readonly List<AuthScope> _grantedScopes;

		public AuthResponse(string authCode, List<AuthScope> grantedScopes)
		{
		}

		public List<AuthScope> GetGrantedScopes()
		{
			return null;
		}

		public string GetAuthCode()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
