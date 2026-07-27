using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	internal interface IAsyncDelayer
	{
		Task Delay(int delayMilliseconds);
	}
}
