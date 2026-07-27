using System;

namespace Firebase
{
	public sealed class FirebaseException : Exception
	{
		public int ErrorCode { get; private set; }

		public FirebaseException()
		{
		}

		public FirebaseException(int errorCode)
		{
		}

		public FirebaseException(int errorCode, string message)
		{
		}

		public FirebaseException(int errorCode, string message, Exception inner)
		{
		}
	}
}
