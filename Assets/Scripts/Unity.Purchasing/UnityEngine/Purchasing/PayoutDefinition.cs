using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class PayoutDefinition
	{
		[SerializeField]
		private PayoutType m_Type;

		[SerializeField]
		private string m_Subtype;

		[SerializeField]
		private double m_Quantity;

		[SerializeField]
		private string m_Data;

		public const int MaxSubtypeLength = 64;

		public const int MaxDataLength = 1024;

		public PayoutType type
		{
			get
			{
				return default(PayoutType);
			}
			private set
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
			private set
			{
			}
		}

		public double quantity
		{
			get
			{
				return 0.0;
			}
			private set
			{
			}
		}

		public string data
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public PayoutDefinition()
		{
		}

		public PayoutDefinition(string typeString, string subtype, double quantity)
		{
		}

		public PayoutDefinition(string typeString, string subtype, double quantity, string data)
		{
		}

		public PayoutDefinition(string subtype, double quantity)
		{
		}

		public PayoutDefinition(string subtype, double quantity, string data)
		{
		}

		public PayoutDefinition(PayoutType type, string subtype, double quantity)
		{
		}

		public PayoutDefinition(PayoutType type, string subtype, double quantity, string data)
		{
		}
	}
}
