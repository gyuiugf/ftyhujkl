using System;
using System.Threading;
using System.Threading.Tasks;

namespace Firebase.Extensions
{
	public static class TaskExtension
	{
		public static Task ContinueWithOnMainThread(this Task task, Action<Task> continuation)
		{
			return null;
		}

		public static Task ContinueWithOnMainThread(this Task task, Action<Task> continuation, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<TResult> ContinueWithOnMainThread<TResult>(this Task task, Func<Task, TResult> continuation)
		{
			return null;
		}

		public static Task<TResult> ContinueWithOnMainThread<TResult>(this Task task, Func<Task, TResult> continuation, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task ContinueWithOnMainThread<T>(this Task<T> task, Action<Task<T>> continuation)
		{
			return null;
		}

		public static Task<TResult> ContinueWithOnMainThread<TResult, T>(this Task<T> task, Func<Task<T>, TResult> continuation)
		{
			return null;
		}
	}
}
