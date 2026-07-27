using UnityEngine;
using UnityEngine.UI;

namespace Google.Play.Common.LoadingScreen
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(RawImage))]
	[RequireComponent(typeof(RectTransform))]
	public class ScrollingFillAnimator : MonoBehaviour
	{
		[Tooltip("How fast the fill texture will scroll in units per second.")]
		public float ScrollSpeed;

		private RawImage _image;

		private RectTransform _rectTransform;

		private void Update()
		{
		}

		private Rect ScrollUvs(Rect uvRect)
		{
			return default(Rect);
		}

		private Rect ScaleUvs(Rect uvRect)
		{
			return default(Rect);
		}

		private void LazyInit()
		{
		}
	}
}
