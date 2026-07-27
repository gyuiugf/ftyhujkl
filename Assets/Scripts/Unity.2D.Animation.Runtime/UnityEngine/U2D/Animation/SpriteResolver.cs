using UnityEngine.Animations;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.U2D.Common;

namespace UnityEngine.U2D.Animation
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("2D Animation/Sprite Resolver")]
	[DefaultExecutionOrder(-20)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/SL-Resolver.html")]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	public class SpriteResolver : MonoBehaviour, IPreviewable, UnityEngine.Animations.IAnimationPreviewable
	{
		[SerializeField]
		private float m_CategoryHash;

		[SerializeField]
		private float m_labelHash;

		[SerializeField]
		private float m_SpriteKey;

		[SerializeField]
		[DiscreteEvaluation]
		private int m_SpriteHash;

		private int m_CategoryHashInt;

		private int m_LabelHashInt;

		private int m_PreviousCategoryHash;

		private int m_PreviousLabelHash;

		private int m_PreviousSpriteKeyInt;

		private int m_PreviousSpriteHash;

		private SpriteRenderer spriteRenderer => null;

		public SpriteLibrary spriteLibrary => null;

		private void Reset()
		{
		}

		private void SetSprite(Sprite sprite)
		{
		}

		private void OnEnable()
		{
		}

		private void InitializeSerializedData()
		{
		}

		public bool SetCategoryAndLabel(string category, string label)
		{
			return false;
		}

		public string GetCategory()
		{
			return null;
		}

		public string GetLabel()
		{
			return null;
		}

		public void OnPreviewUpdate()
		{
		}

		private static bool IsInGUIUpdateLoop()
		{
			return false;
		}

		internal void LateUpdate()
		{
		}

		private void ResolveUpdatedValue()
		{
		}

		internal static int ConvertCategoryLabelHashToSpriteKey(SpriteLibrary library, int categoryHash, int labelHash)
		{
			return 0;
		}

		internal Sprite GetSprite(out bool validEntry)
		{
			validEntry = default(bool);
			return null;
		}

		public bool ResolveSpriteToSpriteRenderer()
		{
			return false;
		}

		private void OnTransformParentChanged()
		{
		}
	}
}
