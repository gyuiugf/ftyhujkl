namespace UnityEngine.Purchasing
{
	internal interface IRetryableRequestFailureDescription
	{
		bool IsRetryable { get; }
	}
}
