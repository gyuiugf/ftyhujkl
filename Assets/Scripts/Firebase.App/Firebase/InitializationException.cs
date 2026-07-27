using System;

namespace Firebase
{
	public sealed class InitializationException : Exception
	{
		public InitResult InitResult { get; private set; }

		public InitializationException(InitResult result)
		{
		}

		public InitializationException(InitResult result, string message)
		{
		}

		public InitializationException(InitResult result, string message, Exception inner)
		{
		}
	}
}
