using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Google.Play.Common.LoadingScreen
{
	public class LoadingScreen : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAttemptAssetBundleDownloadsCo_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingScreen _003C_003E4__this;

			public int numberOfAttempts;

			private int _003Ci_003E5__2;

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
			public _003CAttemptAssetBundleDownloadsCo_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CGetAssetBundle_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string assetBundleUrl;

			public LoadingScreen _003C_003E4__this;

			private UnityWebRequest _003CwebRequest_003E5__2;

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
			public _003CGetAssetBundle_003Ed__12(int _003C_003E1__state)
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

		[Tooltip("The URL used to fetch the AssetBundle on Start.")]
		public string AssetBundleUrl;

		[Tooltip("The LoadingBar used to indicated download and install progress.")]
		public LoadingBar LoadingBar;

		[Tooltip("The button displayed when a download error occurs. Should call ButtonEventRetryDownload in its onClick() event.")]
		public Button RetryButton;

		private const int InitialAttemptCount = 3;

		private AssetBundle _bundle;

		private int _assetBundleRetrievalAttemptCount;

		private float _maxLoadingBarProgress;

		private bool _downloading;

		private void Start()
		{
		}

		public void ButtonEventRetryDownload()
		{
		}

		private void AttemptAssetBundleDownload(int numberOfAttempts)
		{
		}

		[IteratorStateMachine(typeof(_003CAttemptAssetBundleDownloadsCo_003Ed__11))]
		private IEnumerator AttemptAssetBundleDownloadsCo(int numberOfAttempts)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetAssetBundle_003Ed__12))]
		private IEnumerator GetAssetBundle(string assetBundleUrl)
		{
			return null;
		}

		private void ShowRetryButton()
		{
		}

		private void HideRetryButton()
		{
		}

		private static bool IsNetworkError(UnityWebRequest request)
		{
			return false;
		}

		private static AsyncOperation StartAssetBundleDownload(string assetBundleUrl, out UnityWebRequest webRequest)
		{
			webRequest = null;
			return null;
		}
	}
}
