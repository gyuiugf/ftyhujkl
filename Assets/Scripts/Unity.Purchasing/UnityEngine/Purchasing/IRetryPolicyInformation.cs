namespace UnityEngine.Purchasing
{
	public interface IRetryPolicyInformation
	{
		int NumberOfAttempts { get; }

		float TimeSinceFirstAttempt { get; }
	}
}
