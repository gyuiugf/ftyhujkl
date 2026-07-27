using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public class AggregateRetryPolicy : IRetryPolicy
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShouldRetry_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public AggregateRetryPolicy _003C_003E4__this;

			public IRetryPolicyInformation info;

			private List<IRetryPolicy>.Enumerator _003C_003E7__wrap1;

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

		private readonly List<IRetryPolicy> m_RetryPolicies;

		public AggregateRetryPolicy(List<IRetryPolicy> retryPolicies)
		{
		}

		public AggregateRetryPolicy(params IRetryPolicy[] retryPolicies)
		{
		}

		[AsyncStateMachine(typeof(_003CShouldRetry_003Ed__3))]
		public Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return null;
		}
	}
}
