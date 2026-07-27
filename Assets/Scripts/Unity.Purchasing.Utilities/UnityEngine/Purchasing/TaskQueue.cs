using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	internal class TaskQueue
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CEnqueue_003Ed__2<T> : IAsyncStateMachine where T : notnull
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			public TaskQueue _003C_003E4__this;

			public Func<Task<T>> taskGenerator;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<T> _003C_003Eu__2;

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
		private struct _003CEnqueue_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public TaskQueue _003C_003E4__this;

			public Func<Task> taskGenerator;

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

		private readonly SemaphoreSlim semaphore;

		[AsyncStateMachine(typeof(_003CEnqueue_003Ed__2<>))]
		public Task<T> Enqueue<T>(Func<Task<T>> taskGenerator) where T : notnull
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CEnqueue_003Ed__3))]
		public Task Enqueue(Func<Task> taskGenerator)
		{
			return null;
		}
	}
}
