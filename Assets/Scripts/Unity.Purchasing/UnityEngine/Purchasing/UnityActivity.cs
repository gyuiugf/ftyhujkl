namespace UnityEngine.Purchasing
{
	internal class UnityActivity
	{
		private const string k_AndroidClassName = "com.unity3d.player.UnityPlayer";

		private static AndroidJavaClass s_UnityPlayerClass;

		private static AndroidJavaClass GetUnityPlayerClass()
		{
			return null;
		}

		internal static AndroidJavaObject GetCurrentActivity()
		{
			return null;
		}
	}
}
