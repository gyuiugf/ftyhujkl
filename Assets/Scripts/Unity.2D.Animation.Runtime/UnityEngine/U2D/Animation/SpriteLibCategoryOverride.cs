using System;
using System.Collections.Generic;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	internal class SpriteLibCategoryOverride : SpriteLibCategory
	{
		[SerializeField]
		private List<SpriteCategoryEntryOverride> m_OverrideEntries;

		[SerializeField]
		private bool m_FromMain;

		[SerializeField]
		private int m_EntryOverrideCount;

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

		public int entryOverrideCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<SpriteCategoryEntryOverride> overrideEntries
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void UpdateOverrideCount()
		{
		}

		public void RenameDuplicateOverrideEntries()
		{
		}
	}
}
