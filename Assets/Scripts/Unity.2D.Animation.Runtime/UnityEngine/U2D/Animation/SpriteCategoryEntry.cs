using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	internal class SpriteCategoryEntry : INameHash, ISpriteLibraryLabel
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		[HideInInspector]
		private int m_Hash;

		[SerializeField]
		private Sprite m_Sprite;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int hash => 0;

		public Sprite sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void UpdateHash()
		{
		}
	}
}
