using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class AggregateCartValidator : ICartValidator
	{
		private readonly List<ICartValidator> m_CartValidators;

		public AggregateCartValidator(List<ICartValidator> cartValidators)
		{
		}

		public AggregateCartValidator(params ICartValidator[] cartValidators)
		{
		}

		public void Validate(ICart cart)
		{
		}
	}
}
