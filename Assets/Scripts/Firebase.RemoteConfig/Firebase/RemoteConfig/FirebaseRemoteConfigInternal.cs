using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.RemoteConfig
{
	internal class FirebaseRemoteConfigInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal string InstanceKey => null;

		public FirebaseApp App => null;

		internal FirebaseRemoteConfigInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseRemoteConfigInternal obj)
		{
			return default(HandleRef);
		}

		~FirebaseRemoteConfigInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		internal void SetSwigCMemOwn(bool ownership)
		{
		}

		public Task<ConfigInfoInternal> EnsureInitializedAsync()
		{
			return null;
		}

		public Task<bool> ActivateAsync()
		{
			return null;
		}

		public Task<bool> FetchAndActivateAsync()
		{
			return null;
		}

		public Task FetchAsync()
		{
			return null;
		}

		public Task FetchAsync(ulong cacheExpirationInSeconds)
		{
			return null;
		}

		internal Task SetConfigSettingsAsync(ConfigSettingsInternal settings)
		{
			return null;
		}

		internal ConfigSettingsInternal GetConfigSettings()
		{
			return null;
		}

		public IEnumerable<string> GetKeysByPrefix(string prefix)
		{
			return null;
		}

		public IEnumerable<string> GetKeys()
		{
			return null;
		}

		internal ConfigInfoInternal GetInfo()
		{
			return null;
		}

		internal static FirebaseRemoteConfigInternal GetInstanceInternal(FirebaseApp app)
		{
			return null;
		}

		internal static void ReleaseReferenceInternal(FirebaseRemoteConfigInternal rc)
		{
		}

		internal ConfigValueInternal GetValueInternal(string key)
		{
			return null;
		}

		internal Task SetDefaultsInternalAsync(StringStringMap default_dict)
		{
			return null;
		}
	}
}
