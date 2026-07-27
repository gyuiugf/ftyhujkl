using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class UnityServicesInternal : IUnityServices
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			public DependencyTree dependencyTree;

			public List<int> sortedPackageTypeHashes;

			public UnityServicesInternal _003C_003E4__this;

			public Stopwatch initStopwatch;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CEnableInitializationAsync_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityServicesInternal _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public InitializationOptions options;

			public UnityServicesInternal _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeServicesAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityServicesInternal _003C_003E4__this;

			private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

			private TaskAwaiter _003C_003Eu__1;

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

		internal const string InitSuccessEventInvocationError = "Exception in services initialization success event handler: ";

		internal const string InitFailureEventInvocationError = "Exception in services initialization failure event handler: ";

		internal bool CanInitialize;

		private TaskCompletionSource<object> m_Initialization;

		public ServicesInitializationState State { get; private set; }

		public InitializationOptions Options
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[NotNull]
		internal CoreRegistry Registry { get; }

		[NotNull]
		internal CoreMetrics Metrics { get; }

		[NotNull]
		internal CoreDiagnostics Diagnostics { get; }

		public event Action Initialized
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

		public event Action<Exception> InitializeFailed
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

		public UnityServicesInternal([NotNull] CoreRegistry registry, [NotNull] CoreMetrics coreMetrics, [NotNull] CoreDiagnostics coreDiagnostics)
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__27))]
		public Task InitializeAsync(InitializationOptions options)
		{
			return null;
		}

		public string GetIdentifier()
		{
			return null;
		}

		private void TriggerInitializeSuccess()
		{
		}

		private void TriggerInitializeFailed(Exception initException)
		{
		}

		public T GetService<T>()
		{
			return default(T);
		}

		private bool HasRequestedInitialization()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CInitializeServicesAsync_003Ed__33))]
		private Task InitializeServicesAsync()
		{
			return null;
		}

		internal void SendInitializationMetrics(List<PackageInitializationInfo> packageInitInfos)
		{
		}

		internal void EnableInitialization()
		{
		}

		[AsyncStateMachine(typeof(_003CEnableInitializationAsync_003Ed__36))]
		internal Task EnableInitializationAsync()
		{
			return null;
		}
	}
}
