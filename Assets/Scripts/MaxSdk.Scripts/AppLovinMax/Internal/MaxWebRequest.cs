using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace AppLovinMax.Internal
{
	public class MaxWebRequest
	{
		[CompilerGenerated]
		private sealed class _003CSend_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<WebResponse> callback;

			public MaxWebRequest _003C_003E4__this;

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
			public _003CSend_003Ed__5(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CSendInternal_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MaxWebRequest _003C_003E4__this;

			public Action<WebResponse> onComplete;

			public Func<UnityWebRequest, IEnumerator> waitFunc;

			private int _003Cattempt_003E5__2;

			private UnityWebRequest _003Crequest_003E5__3;

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
			public _003CSendInternal_003Ed__8(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const int WaitBetweenRetriesSeconds = 1;

		private readonly WebRequestConfig webRequestConfig;

		private UnityWebRequest webRequest;

		private bool isSending;

		public MaxWebRequest(WebRequestConfig config)
		{
		}

		[IteratorStateMachine(typeof(_003CSend_003Ed__5))]
		public IEnumerator Send(Action<WebResponse> callback)
		{
			return null;
		}

		public WebResponse SendSync()
		{
			return null;
		}

		public void Abort()
		{
		}

		[IteratorStateMachine(typeof(_003CSendInternal_003Ed__8))]
		private IEnumerator SendInternal(Func<UnityWebRequest, IEnumerator> waitFunc, Action<WebResponse> onComplete)
		{
			return null;
		}

		private UnityWebRequest CreateWebRequest()
		{
			return null;
		}

		private string BuildURL()
		{
			return null;
		}
	}
}
