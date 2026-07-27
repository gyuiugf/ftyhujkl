using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unity.Services.Core
{
	public static class UnityServices
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public InitializationOptions options;

			private TaskAwaiter<object> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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

		internal static ExternalUserIdProperty ExternalUserIdProperty;

		public static IUnityServices Instance { get; set; }

		public static IReadOnlyDictionary<string, IUnityServices> Services => null;

		internal static TaskCompletionSource<object> InstantiationCompletion { get; set; }

		private static Dictionary<string, IUnityServices> s_Services { get; }

		public static ServicesInitializationState State => default(ServicesInitializationState);

		public static string ExternalUserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action Initialized
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<Exception> InitializeFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public static Task InitializeAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__26))]
		[PreserveDependency("Register()", "Unity.Services.Core.Registration.CorePackageInitializer", "Unity.Services.Core.Registration")]
		[PreserveDependency("CreateStaticInstance()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
		[PreserveDependency("EnableServicesInitializationAsync()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
		[PreserveDependency("CaptureUnityThreadInfo()", "Unity.Services.Core.UnityThreadUtils", "Unity.Services.Core")]
		public static Task InitializeAsync(InitializationOptions options)
		{
			return null;
		}

		public static IUnityServices CreateServices()
		{
			return null;
		}

		public static IUnityServices CreateServices(string servicesId)
		{
			return null;
		}

		internal static void ClearServices()
		{
		}
	}
}
