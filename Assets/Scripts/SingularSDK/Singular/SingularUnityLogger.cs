using System;

namespace Singular
{
	internal class SingularUnityLogger
	{
		public enum LogLevel
		{
			Verbose = 2,
			Debug = 3,
			Info = 4,
			Warn = 5,
			Error = 6,
			Assert = 7
		}

		private static bool _enableLogging;

		private static LogLevel _logLevel;

		private const string LogTag = "[SingularLog]";

		public static void SetLogLevel(int level)
		{
		}

		public static void EnableLogging(bool enable)
		{
		}

		public static void LogVerbose(string message)
		{
		}

		public static void LogDebug(string message)
		{
		}

		public static void LogInfo(string message)
		{
		}

		public static void LogWarn(string message)
		{
		}

		public static void LogError(string message)
		{
		}

		public static void LogAssert(string message)
		{
		}

		private static void TryLog(string message, LogLevel level, Action<string> logAction)
		{
		}
	}
}
