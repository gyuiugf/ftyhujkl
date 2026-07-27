using UnityEngine.Networking;

namespace AppLovinMax.Internal
{
	public class WebResponse
	{
		public bool IsSuccess { get; }

		public string ResponseMessage { get; }

		public string ErrorMessage { get; }

		public WebResponse(UnityWebRequest request)
		{
		}
	}
}
