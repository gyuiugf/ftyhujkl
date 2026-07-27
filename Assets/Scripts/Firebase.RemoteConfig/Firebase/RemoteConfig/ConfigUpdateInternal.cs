using System;
using System.Runtime.InteropServices;

namespace Firebase.RemoteConfig
{
	internal class ConfigUpdateInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public StringList updated_keys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ConfigUpdateInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ConfigUpdateInternal obj)
		{
			return default(HandleRef);
		}

		~ConfigUpdateInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		internal ConfigUpdateInternal()
		{
		}
	}
}
