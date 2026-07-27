using System.Collections.Generic;

public class MaxCmpError
{
	public enum ErrorCode
	{
		Unspecified = -1,
		IntegrationError = 1,
		FormUnavailable = 2,
		FormNotRequired = 3
	}

	public ErrorCode Code { get; private set; }

	public string Message { get; private set; }

	public int CmpCode { get; private set; }

	public string CmpMessage { get; private set; }

	public static MaxCmpError Create(IDictionary<string, object> error)
	{
		return null;
	}

	private static ErrorCode GetCode(int code)
	{
		return default(ErrorCode);
	}

	private MaxCmpError()
	{
	}
}
