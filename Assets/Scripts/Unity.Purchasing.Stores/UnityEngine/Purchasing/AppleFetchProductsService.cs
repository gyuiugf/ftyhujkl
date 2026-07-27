using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	[Preserve]
	internal class AppleFetchProductsService : IAppleFetchProductsService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CExecuteFetchProductsRequest_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<ProductDescription>> _003C_003Et__builder;

			public AppleFetchProductsService _003C_003E4__this;

			public IReadOnlyCollection<ProductDefinition> products;

			private TaskAwaiter<List<ProductDescription>> _003C_003Eu__1;

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

		private INativeAppleStore? m_NativeStore;

		private readonly TaskQueue queue;

		private TaskCompletionSource<List<ProductDescription>>? m_CurrentRequestCompletionSource;

		public string? LastRequestProductsJson { get; private set; }

		public void SetNativeStore(INativeAppleStore nativeStore)
		{
		}

		public virtual Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		private void ValidateThatRequestIsPossible()
		{
		}

		[AsyncStateMachine(typeof(_003CExecuteFetchProductsRequest_003Ed__10))]
		private Task<List<ProductDescription>> ExecuteFetchProductsRequest(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		public void OnProductsFetched(string json)
		{
		}

		public void OnProductDetailsRetrieveFailed(string errorMessage)
		{
		}
	}
}
