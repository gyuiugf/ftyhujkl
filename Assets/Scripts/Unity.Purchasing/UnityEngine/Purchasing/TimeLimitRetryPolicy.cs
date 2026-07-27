using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public class TimeLimitRetryPolicy : IRetryPolicy
	{
		private readonly float m_TimeLimit;

		public TimeLimitRetryPolicy(float timeLimit)
		{
		}

		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return null;
		}
	}
}
