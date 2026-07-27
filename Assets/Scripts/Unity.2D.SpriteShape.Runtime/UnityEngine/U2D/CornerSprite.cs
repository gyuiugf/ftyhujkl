using System;
using System.Collections.Generic;

namespace UnityEngine.U2D
{
	[Serializable]
	public class CornerSprite : ICloneable
	{
		[SerializeField]
		private CornerType m_CornerType;

		[SerializeField]
		private List<Sprite> m_Sprites;

		public CornerType cornerType
		{
			get
			{
				return default(CornerType);
			}
			set
			{
			}
		}

		public List<Sprite> sprites
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object Clone()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
