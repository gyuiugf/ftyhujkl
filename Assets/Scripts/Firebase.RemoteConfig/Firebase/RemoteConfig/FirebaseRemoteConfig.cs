using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Firebase.RemoteConfig
{
	public sealed class FirebaseRemoteConfig
	{
		[CompilerGenerated]
		private sealed class _003CEnsureInitializedAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConfigInfo> _003C_003Et__builder;

			public FirebaseRemoteConfig _003C_003E4__this;

			private ConfigInfoInternal _003CconfigInfoInternal_003E5__1;

			private ConfigInfoInternal _003C_003Es__2;

			private TaskAwaiter<ConfigInfoInternal> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static readonly Dictionary<string, FirebaseRemoteConfig> remoteConfigByInstanceKey;

		private FirebaseRemoteConfigInternal remoteConfigInternal;

		private readonly FirebaseApp firebaseApp;

		private string instanceKey;

		private static RemoteConfigUtil.ConfigUpdateDelegate configUpdateDelegate;

		public FirebaseApp App => null;

		public static FirebaseRemoteConfig DefaultInstance => null;

		public ConfigSettings ConfigSettings => default(ConfigSettings);

		public IEnumerable<string> Keys => null;

		public IDictionary<string, ConfigValue> AllValues => null;

		public ConfigInfo Info => null;

		public static TimeSpan DefaultCacheExpiration => default(TimeSpan);

		public static ulong DefaultTimeoutInMilliseconds => 0uL;

		private event EventHandler<ConfigUpdateEventArgs> ConfigUpdateListenerImpl
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<ConfigUpdateEventArgs> OnConfigUpdateListener
		{
			add
			{
			}
			remove
			{
			}
		}

		private FirebaseRemoteConfig(FirebaseRemoteConfigInternal remoteConfig, FirebaseApp app)
		{
		}

		private static void DisposeObject(object objectToDispose)
		{
		}

		~FirebaseRemoteConfig()
		{
		}

		private void Dispose()
		{
		}

		private void OnAppDisposed(object sender, EventArgs eventArgs)
		{
		}

		private void ThrowIfNull()
		{
		}

		public static FirebaseRemoteConfig GetInstance(FirebaseApp app)
		{
			return null;
		}

		private static FirebaseRemoteConfig FindByKey(string instanceKey)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CEnsureInitializedAsync_003Ed__23))]
		[DebuggerStepThrough]
		public Task<ConfigInfo> EnsureInitializedAsync()
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

		public Task FetchAsync(TimeSpan cacheExpiration)
		{
			return null;
		}

		public Task SetDefaultsAsync(IDictionary<string, object> defaults)
		{
			return null;
		}

		public Task SetConfigSettingsAsync(ConfigSettings settings)
		{
			return null;
		}

		public ConfigValue GetValue(string key)
		{
			return default(ConfigValue);
		}

		public IEnumerable<string> GetKeysByPrefix(string prefix)
		{
			return null;
		}

		internal void OnConfigUpdate(ConfigUpdateInternal configUpdate, RemoteConfigError error)
		{
		}

		[MonoPInvokeCallback(typeof(RemoteConfigUtil.ConfigUpdateDelegate))]
		private static void ConfigUpdateMethod(string appName, IntPtr configUpdatePtr, int error)
		{
		}
	}
}
