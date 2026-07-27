using System.Collections.Generic;

namespace UnityEngine.U2D
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@latest/index.html?subfolder=/manual/SSProfile.html")]
	public class SpriteShape : ScriptableObject
	{
		[SerializeField]
		private List<AngleRange> m_Angles;

		[SerializeField]
		private Texture2D m_FillTexture;

		[SerializeField]
		private List<CornerSprite> m_CornerSprites;

		[SerializeField]
		private float m_FillOffset;

		[SerializeField]
		private bool m_UseSpriteBorders;

		public List<AngleRange> angleRanges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D fillTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<CornerSprite> cornerSprites
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float fillOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useSpriteBorders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private CornerSprite GetCornerSprite(CornerType cornerType)
		{
			return null;
		}

		private void ResetCornerList()
		{
		}

		private void OnValidate()
		{
		}

		private void Reset()
		{
		}

		internal static int GetSpriteShapeHashCode(SpriteShape spriteShape)
		{
			return 0;
		}
	}
}
