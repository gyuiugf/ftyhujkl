using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	internal class SpriteLibCategory : INameHash, ISpriteLibraryCategory
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_Hash;

		[SerializeField]
		private List<SpriteCategoryEntry> m_CategoryList;

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

		public List<SpriteCategoryEntry> categoryList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IEnumerable<ISpriteLibraryLabel> labels => null;

		public void UpdateHash()
		{
		}

		internal void ValidateLabels(bool log = true)
		{
		}
	}
}
