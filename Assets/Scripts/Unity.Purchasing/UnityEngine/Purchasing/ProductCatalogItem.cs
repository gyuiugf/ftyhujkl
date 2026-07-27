using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class ProductCatalogItem
	{
		public string id;

		public ProductType type;

		[SerializeField]
		private List<StoreID> storeIDs;

		public LocalizedProductDescription defaultDescription;

		public string screenshotPath;

		public int applePriceTier;

		public Price googlePrice;

		public string pricingTemplateID;

		[SerializeField]
		private List<LocalizedProductDescription> descriptions;

		[SerializeField]
		private List<ProductCatalogPayout> payouts;

		public IList<ProductCatalogPayout> Payouts => null;

		public ICollection<StoreID> allStoreIDs => null;

		public bool HasAvailableLocale => false;

		public TranslationLocale NextAvailableLocale => default(TranslationLocale);

		public ICollection<LocalizedProductDescription> translatedDescriptions => null;

		public void AddPayout()
		{
		}

		public void RemovePayout(ProductCatalogPayout payout)
		{
		}

		public ProductCatalogItem Clone()
		{
			return null;
		}

		public void SetStoreID(string aStore, string aId)
		{
		}

		public string GetStoreID(string store)
		{
			return null;
		}

		public void SetStoreIDs(ICollection<StoreID> storeIds)
		{
		}

		public LocalizedProductDescription GetDescription(TranslationLocale locale)
		{
			return null;
		}

		public LocalizedProductDescription GetOrCreateDescription(TranslationLocale locale)
		{
			return null;
		}

		public LocalizedProductDescription AddDescription(TranslationLocale locale)
		{
			return null;
		}

		public void RemoveDescription(TranslationLocale locale)
		{
		}
	}
}
