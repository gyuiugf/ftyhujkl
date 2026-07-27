using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class Cart : ICart
	{
		private readonly HashSet<CartItem> m_CartItems;

		private IReadOnlyList<CartItem>? m_CachedItemsList;

		public Cart(CartItem cartItem)
		{
		}

		public IReadOnlyList<CartItem> Items()
		{
			return null;
		}

		public void AddItem(CartItem item)
		{
		}

		public void RemoveItem(CartItem item)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
