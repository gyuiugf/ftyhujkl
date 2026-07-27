namespace UnityEngine.Purchasing
{
	public class Entitlement
	{
		public Product? Product { get; }

		public Order? Order { get; internal set; }

		public EntitlementStatus Status { get; }

		public string? ErrorMessage { get; }

		internal Entitlement(Product? product, Order? order, EntitlementStatus status, string? message = null)
		{
		}
	}
}
