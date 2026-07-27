using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public class MaximumNumberOfAttemptsRetryPolicy : IRetryPolicy
	{
		private readonly int m_MaximumNumberOfAttempts;

		public MaximumNumberOfAttemptsRetryPolicy(int maximumNumberOfAttempts)
		{
		}

		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return null;
		}
	}
}
