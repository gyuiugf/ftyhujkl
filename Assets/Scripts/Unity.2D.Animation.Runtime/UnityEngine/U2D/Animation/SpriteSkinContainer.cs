using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.U2D.Animation
{
	internal class SpriteSkinContainer : ScriptableObject
	{
		private static SpriteSkinContainer s_Instance;

		private List<SpriteSkin> m_SpriteSkin;

		public static SpriteSkinContainer instance => null;

		public IReadOnlyList<SpriteSkin> spriteSkins => null;

		public static event Action<SpriteSkin> onAddedSpriteSkin
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<SpriteSkin> onRemovedSpriteSkin
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<SpriteSkin> onBoneTransformChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AddSpriteSkin(SpriteSkin spriteSkin)
		{
		}

		public void RemoveSpriteSkin(SpriteSkin spriteSkin)
		{
		}

		public void BoneTransformsChanged(SpriteSkin spriteSkin)
		{
		}
	}
}
