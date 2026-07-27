namespace UnityEngine.Purchasing
{
	public struct RetryPolicyInformation : IRetryPolicyInformation
	{
		public int NumberOfAttempts { get; }

		public float TimeSinceFirstAttempt { get; }

		internal RetryPolicyInformation(int numberOfAttempts, float timeSinceFirstAttempt)
		{
			NumberOfAttempts = 0;
			TimeSinceFirstAttempt = 0f;
		}
	}
}
