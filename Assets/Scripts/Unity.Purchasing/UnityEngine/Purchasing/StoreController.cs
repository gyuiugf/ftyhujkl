using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public class StoreController : IStoreService, IProductService, IPurchaseService
	{
		private IStoreService m_StoreService;

		private IProductService m_ProductService;

		private IPurchaseService m_PurchaseService;

		IAppleStoreExtendedService? IStoreService.Apple => null;

		IGooglePlayStoreExtendedService? IStoreService.Google => null;

		IAppleStoreExtendedProductService? IProductService.Apple => null;

		IAppleStoreExtendedPurchaseService? IPurchaseService.Apple => null;

		IGooglePlayStoreExtendedPurchaseService? IPurchaseService.Google => null;

		public IAppleStoreExtendedService? AppleStoreExtendedService => null;

		public IGooglePlayStoreExtendedService? GooglePlayStoreExtendedService => null;

		public IAppleStoreExtendedProductService? AppleStoreExtendedProductService => null;

		public IAppleStoreExtendedPurchaseService? AppleStoreExtendedPurchaseService => null;

		public IGooglePlayStoreExtendedPurchaseService? GooglePlayStoreExtendedPurchaseService => null;

		public event Action<StoreConnectionFailureDescription>? OnStoreDisconnected
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<PendingOrder>? OnPurchasePending
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Order>? OnPurchaseConfirmed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<FailedOrder>? OnPurchaseFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<DeferredOrder>? OnPurchaseDeferred
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Orders>? OnPurchasesFetched
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<PurchasesFetchFailureDescription>? OnPurchasesFetchFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Entitlement>? OnCheckEntitlement
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<List<Product>>? OnProductsFetched
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<ProductFetchFailed>? OnProductsFetchFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public StoreController(string? storeName = null)
		{
		}

		internal void SetTestInstances(IStoreService storeService, IProductService productService, IPurchaseService purchaseService)
		{
		}

		public void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess)
		{
		}

		public Task Connect()
		{
			return null;
		}

		public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy? retryPolicy)
		{
		}

		public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
		}

		public void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy? retryPolicy = null)
		{
		}

		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return null;
		}

		public Product GetProductById(string productId)
		{
			return null;
		}

		public void PurchaseProduct(Product product)
		{
		}

		public void Purchase(ICart cart)
		{
		}

		public void ConfirmPurchase(PendingOrder order)
		{
		}

		public void FetchPurchases()
		{
		}

		public void CheckEntitlement(Product product)
		{
		}

		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		public ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return null;
		}

		public void PurchaseProduct(string? productId)
		{
		}
	}
}
