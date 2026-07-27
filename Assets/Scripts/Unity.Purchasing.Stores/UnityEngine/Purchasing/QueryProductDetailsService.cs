using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class QueryProductDetailsService : IQueryProductDetailsService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CQueryInAppsAndSubsProductDetails_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ProductDetailsQueryResponse> _003C_003Et__builder;

			public QueryProductDetailsService _003C_003E4__this;

			public IReadOnlyCollection<ProductDefinition> products;

			private List<Task<(IGoogleBillingResult, IEnumerable<AndroidJavaObject>)>> _003Ctasks_003E5__2;

			private TaskAwaiter<(IGoogleBillingResult, IEnumerable<AndroidJavaObject>)[]> _003C_003Eu__1;

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
		private struct _003CQueryProductDescriptions_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<ProductDescription>> _003C_003Et__builder;

			public QueryProductDetailsService _003C_003E4__this;

			public IReadOnlyCollection<ProductDefinition> products;

			private TaskAwaiter<List<AndroidJavaObject>> _003C_003Eu__1;

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
		private struct _003CQueryProductDetails_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<AndroidJavaObject>> _003C_003Et__builder;

			public QueryProductDetailsService _003C_003E4__this;

			public IReadOnlyCollection<ProductDefinition> products;

			private TaskAwaiter<ProductDetailsQueryResponse> _003C_003Eu__1;

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

		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService;

		private readonly IProductDetailsConverter m_ProductDetailsConverter;

		[Preserve]
		internal QueryProductDetailsService(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter)
		{
		}

		public Task<List<AndroidJavaObject>> QueryProductDetails(ProductDefinition product)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CQueryProductDescriptions_003Ed__5))]
		public Task<List<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CQueryProductDetails_003Ed__6))]
		public virtual Task<List<AndroidJavaObject>> QueryProductDetails(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CQueryInAppsAndSubsProductDetails_003Ed__7))]
		private Task<ProductDetailsQueryResponse> QueryInAppsAndSubsProductDetails(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		private bool ShouldRetryQuery(IEnumerable<ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse)
		{
			return false;
		}

		private bool AreAllProductDetailsCached(IEnumerable<ProductDefinition> products)
		{
			return false;
		}

		private IEnumerable<AndroidJavaObject> GetCachedProductDetails(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		private Task<(IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> QueryInAppsAsync(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		private Task<(IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> QuerySubsAsync(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		private Task<(IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> QueryProductDetails(List<string> productList, string type)
		{
			return null;
		}
	}
}
