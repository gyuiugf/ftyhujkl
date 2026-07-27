using Purchasing.Utilities;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Utilities
{
	internal static class UnityUtilDependencyInjector
	{
		private const string k_IAPMonoBehaviourUtil = "IAPMonoBehaviourUtil";

		internal static UnityUtil CreateUnityUtils()
		{
			return null;
		}

		private static MonoBehaviourUtil CreateMonoBehaviourUtil()
		{
			return null;
		}
	}
}
