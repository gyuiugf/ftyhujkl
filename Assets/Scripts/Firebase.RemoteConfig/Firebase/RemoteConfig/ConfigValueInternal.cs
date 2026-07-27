using System;
using System.Runtime.InteropServices;

namespace Firebase.RemoteConfig
{
	internal class ConfigValueInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public CharVector data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ValueSource source
		{
			get
			{
				return default(ValueSource);
			}
			set
			{
			}
		}

		internal ConfigValueInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ConfigValueInternal obj)
		{
			return default(HandleRef);
		}

		~ConfigValueInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		internal ConfigValueInternal()
		{
		}
	}
}
