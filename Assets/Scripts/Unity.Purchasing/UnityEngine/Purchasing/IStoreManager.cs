namespace UnityEngine.Purchasing
{
	internal interface IStoreManager
	{
		IStoreWrapper GetStore(string name);
	}
}
