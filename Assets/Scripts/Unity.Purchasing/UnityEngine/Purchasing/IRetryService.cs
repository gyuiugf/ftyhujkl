using System;

namespace UnityEngine.Purchasing
{
	internal interface IRetryService
	{
		IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy);
	}
}
