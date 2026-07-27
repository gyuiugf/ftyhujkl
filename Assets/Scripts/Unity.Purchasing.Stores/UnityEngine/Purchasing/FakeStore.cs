using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	internal class FakeStore : JsonStore, INativeStore
	{
		protected enum DialogType
		{
			Purchase = 0,
			FetchProducts = 1
		}

		public const string Name = "fake";

		private readonly List<ConfirmedOrder> m_ConfirmedOrders;

		public FakeStoreUIMode UIMode;

		public bool purchaseCalled;

		public bool restoreCalled;

		public string unavailableProductId { get; set; }

		public FakeStore(ICartValidator cartValidator, ILogger logger)
			: base(null, null, null)
		{
		}

		public override void Connect()
		{
		}

		public void FetchProducts(string json)
		{
		}

		public void StoreFetchProducts(ReadOnlyCollection<ProductDefinition> productDefinitions)
		{
		}

		private ProductMetadata GetOrCreateProductMetadata(string productId)
		{
			return null;
		}

		public void FetchExistingPurchases()
		{
		}

		public void Purchase(string productJson, string optionsJson)
		{
		}

		private ProductDefinition ParseProductDefinition(string productJSON)
		{
			return null;
		}

		private ProductType ParseProductType(Dictionary<string, object> dictionary)
		{
			return default(ProductType);
		}

		private void FakePurchase(ProductDefinition productDefinition, string developerPayload)
		{
		}

		public bool CheckEntitlement(string productJSON)
		{
			return false;
		}

		private bool CheckIfProductEntitled(ProductDefinition definition)
		{
			return false;
		}

		public void RestoreTransactions(Action<bool, string> callback)
		{
		}

		public void FinishTransaction(string productJSON, string transactionID)
		{
		}

		protected virtual bool StartUI<T>(object model, DialogType dialogType, Action<bool, T> callback)
		{
			return false;
		}
	}
}
