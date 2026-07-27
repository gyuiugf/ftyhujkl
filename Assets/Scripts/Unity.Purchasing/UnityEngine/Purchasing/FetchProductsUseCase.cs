using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class FetchProductsUseCase : IFetchProductsUseCase, IStoreProductsCallback
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnProductsFetchFailed_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public FetchProductsUseCase _003C_003E4__this;

			public ProductFetchFailureDescription failureDescription;

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

		private ProductFetchRequest? m_ActiveRequest;

		private IRetryRequest? m_ActiveRetryRequest;

		[Preserve]
		internal FetchProductsUseCase(IStore storeResponsible, IRetryService retryService)
		{
		}

		public void FetchProducts(List<ProductDefinition>? productDefinitions, Action<List<Product>?> fetchSuccessAction, Action<List<ProductDefinition>?, string> fetchFailureAction, IRetryPolicy retryPolicy)
		{
		}

		private void ProcessValidFetchRequest(ProductFetchRequest request, IRetryPolicy retryPolicy)
		{
		}

		public void OnProductsFetched(IReadOnlyList<ProductDescription> products)
		{
		}

		private void ProcessFetchedProductsAndInvokeCallbacks(ProductFetchRequest request, IReadOnlyList<ProductDescription> productsRetrieved)
		{
		}

		private ProductDefinition GetMatchingDefinition(ProductDescription description)
		{
			return null;
		}

		private Product CreateMatchedProduct(ProductDefinition definition, ProductDescription description)
		{
			return null;
		}

		private static void InvokeSuccessIfFetchedProducts(List<Product> fetchedProducts, Action<List<Product>>? successCallback)
		{
		}

		private static void InvokeFailureIfIncomplete(ProductFetchRequest request, List<ProductDefinition> matchedDefinitions)
		{
		}

		[AsyncStateMachine(typeof(_003COnProductsFetchFailed_003Ed__13))]
		public void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription)
		{
		}

		private void SendRequestFailureCallback(ProductFetchRequest productFetchRequest, ProductFetchFailureDescription failureDescription)
		{
		}
	}
}
