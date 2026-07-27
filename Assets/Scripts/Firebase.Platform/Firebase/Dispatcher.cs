using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firebase
{
	internal class Dispatcher
	{
		private class CallbackStorage<TResult>
		{
			public TResult Result { get; set; }

			public Exception Exception { get; set; }
		}

		private int ownerThreadId;

		private Queue<Action> queue;

		public TResult Run<TResult>(Func<TResult> callback)
		{
			return default(TResult);
		}

		public Task<TResult> RunAsync<TResult>(Func<TResult> callback)
		{
			return null;
		}

		internal static Task<TResult> RunAsyncNow<TResult>(Func<TResult> callback)
		{
			return null;
		}

		internal bool ManagesThisThread()
		{
			return false;
		}

		public void PollJobs()
		{
		}
	}
}
