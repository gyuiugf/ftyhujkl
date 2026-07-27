using System;
using Uniject;

namespace UnityEngine.Purchasing
{
	internal class RetryService : IRetryService
	{
		private readonly IUtil m_Util;

		internal RetryService(IUtil util)
		{
		}

		public IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy)
		{
			return null;
		}
	}
}
