using System;
using System.Runtime.InteropServices;

namespace Firebase.Analytics
{
	internal class FirebaseAnalyticsInternalPINVOKE
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
			internal static extern void SWIGRegisterExceptionCallbacks_FirebaseAnalyticsInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalyticsInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

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
			internal static extern void SWIGRegisterStringCallback_FirebaseAnalyticsInternal(SWIGStringDelegate stringDelegate);

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

		static FirebaseAnalyticsInternalPINVOKE()
		{
		}

		[PreserveSig]
		public static extern void ExportFix();

		[PreserveSig]
		public static extern IntPtr new_Future_LongLong();

		[PreserveSig]
		public static extern IntPtr Future_LongLong_SWIG_OnCompletion(HandleRef jarg1, Future_LongLong.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void Future_LongLong_SWIG_FreeCompletionData(IntPtr jarg1);

		[PreserveSig]
		public static extern long Future_LongLong_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_Future_LongLong(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_IntIntMap__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_IntIntMap__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern uint IntIntMap_size(HandleRef jarg1);

		[PreserveSig]
		public static extern bool IntIntMap_empty(HandleRef jarg1);

		[PreserveSig]
		public static extern void IntIntMap_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern int IntIntMap_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void IntIntMap_setitem(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern bool IntIntMap_ContainsKey(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void IntIntMap_Add(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern bool IntIntMap_Remove(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr IntIntMap_create_iterator_begin(HandleRef jarg1);

		[PreserveSig]
		public static extern int IntIntMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void IntIntMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void delete_IntIntMap(HandleRef jarg1);

		[PreserveSig]
		public static extern void SetAnalyticsCollectionEnabled(bool jarg1);

		[PreserveSig]
		public static extern void LogEvent__SWIG_0(string jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_1(string jarg1, string jarg2, double jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_2(string jarg1, string jarg2, long jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_3(string jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_4(string jarg1);

		[PreserveSig]
		public static extern void InitiateOnDeviceConversionMeasurementWithEmailAddress(string jarg1);

		[PreserveSig]
		public static extern void InitiateOnDeviceConversionMeasurementWithPhoneNumber(string jarg1);

		[PreserveSig]
		public static extern void InitiateOnDeviceConversionMeasurementWithHashedEmailAddress(HandleRef jarg1);

		[PreserveSig]
		public static extern void InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber(HandleRef jarg1);

		[PreserveSig]
		public static extern void SetUserProperty(string jarg1, string jarg2);

		[PreserveSig]
		public static extern void SetUserId(string jarg1);

		[PreserveSig]
		public static extern void SetSessionTimeoutDuration(long jarg1);

		[PreserveSig]
		public static extern void ResetAnalyticsData();

		[PreserveSig]
		public static extern IntPtr GetAnalyticsInstanceId();

		[PreserveSig]
		public static extern IntPtr GetSessionId();

		[PreserveSig]
		public static extern void LogEvent__SWIG_5(string jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void SetConsentWithInts(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr Future_LongLong_SWIGUpcast(IntPtr jarg1);
	}
}
