namespace UnityEngine.Purchasing
{
	internal interface IAndroidJavaStore : INativeStore
	{
		AndroidJavaObject GetStore();
	}
}
