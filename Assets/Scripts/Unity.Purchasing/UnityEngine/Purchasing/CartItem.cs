namespace UnityEngine.Purchasing
{
	public class CartItem
	{
		public Product Product { get; }

		public int Quantity { get; }

		public CartItem(Product product)
		{
		}

		internal CartItem(Product product, int quantity)
		{
		}

		public static implicit operator CartItem(Product product)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
