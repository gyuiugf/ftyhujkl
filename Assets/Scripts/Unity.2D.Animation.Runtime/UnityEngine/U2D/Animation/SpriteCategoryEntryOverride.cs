using System;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	internal class SpriteCategoryEntryOverride : SpriteCategoryEntry
	{
		[SerializeField]
		private bool m_FromMain;

		[SerializeField]
		private Sprite m_SpriteOverride;

		public bool fromMain
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Sprite spriteOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
