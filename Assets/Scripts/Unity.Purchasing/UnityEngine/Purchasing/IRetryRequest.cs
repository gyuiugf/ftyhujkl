using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	internal interface IRetryRequest
	{
		Task<bool> Invoke();

		Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription);
	}
}
