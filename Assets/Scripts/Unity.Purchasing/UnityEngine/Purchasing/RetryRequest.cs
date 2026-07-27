using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Uniject;

namespace UnityEngine.Purchasing
{
	internal class RetryRequest : IRetryRequest
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvokeFromMainThread_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public RetryRequest _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRetry_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public IRetryableRequestFailureDescription requestFailureDescription;

			public RetryRequest _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRetryFromMainThread_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public RetryRequest _003C_003E4__this;

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

		private float m_StartTime;

		private int m_NumberOfAttempts;

		private readonly Action m_Request;

		private readonly IRetryPolicy m_RetryPolicy;

		private readonly IUtil m_Util;

		public RetryRequest(Action request, IRetryPolicy retryPolicy, IUtil util)
		{
		}

		public Task<bool> Invoke()
		{
			return null;
		}

		public Task<bool> RunTaskOnMainThread(Func<Task<bool>> function)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInvokeFromMainThread_003Ed__8))]
		private Task<bool> InvokeFromMainThread()
		{
			return null;
		}

		private void FirstTry()
		{
		}

		[AsyncStateMachine(typeof(_003CRetry_003Ed__10))]
		public Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRetryFromMainThread_003Ed__11))]
		private Task<bool> RetryFromMainThread()
		{
			return null;
		}
	}
}
