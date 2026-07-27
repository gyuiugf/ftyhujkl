using System;
using System.Runtime.InteropServices;

namespace Firebase.RemoteConfig
{
	internal class ConfigInfoInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public ulong fetch_time
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public LastFetchStatus last_fetch_status
		{
			get
			{
				return default(LastFetchStatus);
			}
			set
			{
			}
		}

		public FetchFailureReason last_fetch_failure_reason
		{
			get
			{
				return default(FetchFailureReason);
			}
			set
			{
			}
		}

		public ulong throttled_end_time
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal ConfigInfoInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ConfigInfoInternal obj)
		{
			return default(HandleRef);
		}

		~ConfigInfoInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		internal ConfigInfoInternal()
		{
		}
	}
}
