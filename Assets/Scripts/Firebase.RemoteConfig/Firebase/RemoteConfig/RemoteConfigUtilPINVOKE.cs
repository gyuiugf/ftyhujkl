using System;
using System.Runtime.InteropServices;

namespace Firebase.RemoteConfig
{
	internal class RemoteConfigUtilPINVOKE
	{
		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacks_RemoteConfigUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacksArgument_RemoteConfigUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingApplicationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIOException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOverflowException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingSystemException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			static SWIGExceptionHelper()
			{
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			private static object exceptionsLock;

			public static bool Pending => false;

			public static void Set(Exception e)
			{
			}

			public static Exception Retrieve()
			{
				return null;
			}

			static SWIGPendingException()
			{
			}
		}

		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterStringCallback_RemoteConfigUtil(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
			private static string CreateString(string cString)
			{
				return null;
			}

			static SWIGStringHelper()
			{
			}
		}

		protected static SWIGExceptionHelper swigExceptionHelper;

		protected static SWIGStringHelper swigStringHelper;

		static RemoteConfigUtilPINVOKE()
		{
		}

		[PreserveSig]
		public static extern void ExportFix();

		[PreserveSig]
		public static extern IntPtr new_Future_ConfigInfo();

		[PreserveSig]
		public static extern IntPtr Future_ConfigInfo_SWIG_OnCompletion(HandleRef jarg1, Future_ConfigInfo.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void Future_ConfigInfo_SWIG_FreeCompletionData(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr Future_ConfigInfo_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_Future_ConfigInfo(HandleRef jarg1);

		[PreserveSig]
		public static extern void ConfigUpdateInternal_updated_keys_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr ConfigUpdateInternal_updated_keys_get(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr new_ConfigUpdateInternal();

		[PreserveSig]
		internal static extern void delete_ConfigUpdateInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern void ConfigInfoInternal_fetch_time_set(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern ulong ConfigInfoInternal_fetch_time_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void ConfigInfoInternal_last_fetch_status_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern int ConfigInfoInternal_last_fetch_status_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void ConfigInfoInternal_last_fetch_failure_reason_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern int ConfigInfoInternal_last_fetch_failure_reason_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void ConfigInfoInternal_throttled_end_time_set(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern ulong ConfigInfoInternal_throttled_end_time_get(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr new_ConfigInfoInternal();

		[PreserveSig]
		internal static extern void delete_ConfigInfoInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern ulong kDefaultCacheExpiration_get();

		[PreserveSig]
		public static extern ulong kDefaultTimeoutInMilliseconds_get();

		[PreserveSig]
		public static extern void ConfigSettingsInternal_fetch_timeout_in_milliseconds_set(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern ulong ConfigSettingsInternal_fetch_timeout_in_milliseconds_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void ConfigSettingsInternal_minimum_fetch_interval_in_milliseconds_set(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern ulong ConfigSettingsInternal_minimum_fetch_interval_in_milliseconds_get(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr new_ConfigSettingsInternal();

		[PreserveSig]
		internal static extern void delete_ConfigSettingsInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern void delete_FirebaseRemoteConfigInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_EnsureInitialized(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_Activate(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_FetchAndActivate(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_Fetch__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_Fetch__SWIG_1(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_SetConfigSettings(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_GetConfigSettings(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_GetKeysByPrefix(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_GetKeys(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_GetInfo(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseRemoteConfigInternal_App_get(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr FirebaseRemoteConfigInternal_GetInstanceInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern void FirebaseRemoteConfigInternal_ReleaseReferenceInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr FirebaseRemoteConfigInternal_GetValueInternal(HandleRef jarg1, string jarg2);

		[PreserveSig]
		internal static extern IntPtr FirebaseRemoteConfigInternal_SetDefaultsInternal(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void ConfigValueInternal_data_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr ConfigValueInternal_data_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void ConfigValueInternal_source_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern int ConfigValueInternal_source_get(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr new_ConfigValueInternal();

		[PreserveSig]
		internal static extern void delete_ConfigValueInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern void SetConfigUpdateCallback(HandleRef jarg1, RemoteConfigUtil.ConfigUpdateDelegate jarg2);

		[PreserveSig]
		public static extern IntPtr Future_ConfigInfo_SWIGUpcast(IntPtr jarg1);
	}
}
