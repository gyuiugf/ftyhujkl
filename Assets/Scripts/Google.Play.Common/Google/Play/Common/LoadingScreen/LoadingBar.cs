using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Google.Play.Common.LoadingScreen
{
	[ExecuteInEditMode]
	public class LoadingBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFillUntilDone_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float startingFillProportion;

			public AsyncOperation operation;

			public float endingFillProportion;

			public LoadingBar _003C_003E4__this;

			public bool skipFinalUpdate;

			private float _003CpreviousFillProportion_003E5__2;

			private bool _003CisDone_003E5__3;

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
			public _003CFillUntilDone_003Ed__12(int _003C_003E1__state)
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

		public float OutlineWidth;

		public float InnerBorderWidth;

		[Tooltip("If true, the Outline and Background RectTransforms will update to match the outline and border width.")]
		public bool ResizeAutomatically;

		[Tooltip("AssetBundle download and install progress. The value set in the Editor is ignored at runtime.")]
		[Range(0f, 1f)]
		public float Progress;

		public RectTransform Background;

		public RectTransform Outline;

		public RectTransform ProgressHolder;

		public RectTransform ProgressFill;

		[Tooltip("Proportion of the loading bar allocated to AssetBundle download progress. The remainder of the loading bar is allocated to install progress.")]
		[Range(0f, 1f)]
		public float AssetBundleDownloadToInstallRatio;

		private void Update()
		{
		}

		public void ApplyBorderWidth()
		{
		}

		public void SetProgress(float proportionOfLoadingBar)
		{
		}

		[IteratorStateMachine(typeof(_003CFillUntilDone_003Ed__12))]
		public IEnumerator FillUntilDone(AsyncOperation operation, float startingFillProportion, float endingFillProportion, bool skipFinalUpdate)
		{
			return null;
		}
	}
}
