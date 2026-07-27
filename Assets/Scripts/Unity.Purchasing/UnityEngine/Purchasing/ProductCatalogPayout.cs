using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class ProductCatalogPayout
	{
		public enum ProductCatalogPayoutType
		{
			Other = 0,
			Currency = 1,
			Item = 2,
			Resource = 3
		}

		[SerializeField]
		private string t;

		public const int MaxSubtypeLength = 64;

		[SerializeField]
		private string st;

		[SerializeField]
		private double q;

		public const int MaxDataLength = 1024;

		[SerializeField]
		private string d;

		public ProductCatalogPayoutType type
		{
			get
			{
				return default(ProductCatalogPayoutType);
			}
			set
			{
			}
		}

		public string typeString => null;

		public string subtype
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double quantity
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public string data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
