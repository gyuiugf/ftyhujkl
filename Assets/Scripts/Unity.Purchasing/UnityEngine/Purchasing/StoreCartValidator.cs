namespace UnityEngine.Purchasing
{
	internal class StoreCartValidator : ICartValidator
	{
		private readonly string m_StoreName;

		private readonly ICartValidator m_CartValidator;

		public StoreCartValidator(string storeName, ICartValidator cartValidator)
		{
		}

		public void Validate(ICart cart)
		{
		}
	}
}
