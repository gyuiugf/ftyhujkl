using System;
using System.Runtime.InteropServices;

namespace Firebase.RemoteConfig
{
	internal class ConfigSettingsInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public ulong fetch_timeout_in_milliseconds
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong minimum_fetch_interval_in_milliseconds
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal ConfigSettingsInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ConfigSettingsInternal obj)
		{
			return default(HandleRef);
		}

		~ConfigSettingsInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		internal ConfigSettingsInternal()
		{
		}
	}
}
