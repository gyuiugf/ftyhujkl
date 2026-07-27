using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class StoreConnectUseCase : IStoreConnectUseCase, IStoreConnectCallback
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnStoreConnectionFailed_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public StoreConnectUseCase _003C_003E4__this;

			public StoreConnectionFailureDescription failureDescription;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		private readonly IStore m_Store;

		private readonly IRetryService m_RetryService;

		private IRetryPolicy m_RetryPolicyOnDisconnect;

		private TaskCompletionSource<object?>? m_CurrentConnectionCompletion;

		private IRetryRequest? m_CurrentRequest;

		public event Action<StoreConnectionFailureDescription>? OnStoreDisconnection
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

		internal StoreConnectUseCase(IStore store, IRetryService retryService, IRetryPolicy retryPolicyOnDisconnect)
		{
		}

		public Task Connect()
		{
			return null;
		}

		private void InitializeRequest()
		{
		}

		public void OnStoreConnectionSucceeded()
		{
		}

		[AsyncStateMachine(typeof(_003COnStoreConnectionFailed_003Ed__12))]
		public void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription)
		{
		}

		private void SendDisconnectionEvent(StoreConnectionFailureDescription connectionFailureDescription)
		{
		}

		public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy)
		{
		}
	}
}
