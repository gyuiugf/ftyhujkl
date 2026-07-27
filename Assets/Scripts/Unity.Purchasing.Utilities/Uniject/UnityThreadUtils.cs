using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Scripting;

namespace Uniject
{
	[Preserve]
	internal class UnityThreadUtils : IThreadUtils
	{
		private static int s_UnityThreadId;

		private static TaskScheduler UnityThreadScheduler;

		public bool IsRunningOnMainThread => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void CaptureUnityThreadInfo()
		{
		}

		public Task PostAsync(Action action)
		{
			return null;
		}

		public Task PostAsync(Action<object> action, object state)
		{
			return null;
		}

		public Task<T> PostAsync<T>(Func<T> action)
		{
			return null;
		}

		public Task<T> PostAsync<T>(Func<object, T> action, object state)
		{
			return null;
		}
	}
}
