using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Purchasing.Utilities
{
	[HideInInspector]
	[AddComponentMenu(null)]
	internal class MonoBehaviourUtil : MonoBehaviour, IMonoBehaviourUtil
	{
		[CompilerGenerated]
		private sealed class _003CDelayedCoroutine_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int delay;

			public MonoBehaviourUtil _003C_003E4__this;

			public IEnumerator coroutine;

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
			public _003CDelayedCoroutine_003Ed__1(int _003C_003E1__state)
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

		public GameObject[] GetGameObjects()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayedCoroutine_003Ed__1))]
		public IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay)
		{
			return null;
		}

		Coroutine IMonoBehaviourUtil.StartCoroutine(IEnumerator start)
		{
			return null;
		}
	}
}
