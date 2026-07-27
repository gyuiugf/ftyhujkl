using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public interface IStoreWrapper
	{
		Store instance { get; }

		string name { get; }

		ConnectionState GetStoreConnectionState();
	}
}
