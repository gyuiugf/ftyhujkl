using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public class ExponentialBackOffRetryPolicy : IRetryPolicy
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShouldRetry_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public ExponentialBackOffRetryPolicy _003C_003E4__this;

			public IRetryPolicyInformation info;

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

		private readonly int m_BaseRetryDelay;

		private readonly int m_MaxRetryDelay;

		private readonly float m_ExponentialFactor;

		private readonly int m_MaxNumberOfRetriesBeforeCeiling;

		private readonly IAsyncDelayer m_Delayer;

		public ExponentialBackOffRetryPolicy(int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2f)
		{
		}

		private static void ValidateArguments(int baseRetryDelay, int maxRetryDelay, float exponentialFactor)
		{
		}

		private int CalculateMaxNumberOfRetriesBeforeCeiling(int baseRetryDelay, int maxRetryDelay, float exponentialFactor)
		{
			return 0;
		}

		internal ExponentialBackOffRetryPolicy(IAsyncDelayer delayer, int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2f)
		{
		}

		[AsyncStateMachine(typeof(_003CShouldRetry_003Ed__9))]
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return null;
		}

		private int AdjustDelay(int numberOfRetries)
		{
			return 0;
		}

		private bool HasHitMaxRetryDelay(int numberOfRetries)
		{
			return false;
		}
	}
}
