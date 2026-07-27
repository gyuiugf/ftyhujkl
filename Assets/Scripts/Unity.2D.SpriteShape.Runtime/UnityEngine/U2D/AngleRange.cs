using System;
using System.Collections.Generic;

namespace UnityEngine.U2D
{
	[Serializable]
	public class AngleRange : ICloneable
	{
		[SerializeField]
		private float m_Start;

		[SerializeField]
		private float m_End;

		[SerializeField]
		private int m_Order;

		[SerializeField]
		private List<Sprite> m_Sprites;

		public float start
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float end
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int order
		{
			get
			{
				return 0;
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
