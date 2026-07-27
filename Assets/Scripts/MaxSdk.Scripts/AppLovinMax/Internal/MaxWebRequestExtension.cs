using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace AppLovinMax.Internal
{
	public static class MaxWebRequestExtension
	{
		[CompilerGenerated]
		private sealed class _003CSendAndWait_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityWebRequest request;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSendAndWait_003Ed__0(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[IteratorStateMachine(typeof(_003CSendAndWait_003Ed__0))]
		internal static IEnumerator SendAndWait(this UnityWebRequest request)
		{
			return null;
		}

		internal static string ToHttpMethodString(this WebRequestType type)
		{
			return null;
		}

		internal static string ToQueryString(this Dictionary<string, string> queries)
		{
			return null;
		}
	}
}
