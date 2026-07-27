using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/AssetUpgrader.html%23upgrading-sprite-libraries")]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	public class SpriteLibraryAsset : ScriptableObject
	{
		[SerializeField]
		private List<SpriteLibCategory> m_Labels;

		[SerializeField]
		private long m_ModificationHash;

		[SerializeField]
		private int m_Version;

		internal List<SpriteLibCategory> categories
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal long modificationHash
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal int version
		{
			set
			{
			}
		}

		internal static SpriteLibraryAsset CreateAsset(List<SpriteLibCategory> categories, string assetName, long modificationHash)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void UpdateToVersionOne()
		{
		}

		internal Sprite GetSprite(int categoryHash, int labelHash)
		{
			return null;
		}

		internal Sprite GetSprite(int categoryHash, int labelHash, out bool validEntry)
		{
			validEntry = default(bool);
			return null;
		}

		public Sprite GetSprite(string category, string label)
		{
			return null;
		}

		public IEnumerable<string> GetCategoryNames()
		{
			return null;
		}

		[Obsolete("GetCategorylabelNames has been deprecated. Please use GetCategoryLabelNames (UnityUpgradable) -> GetCategoryLabelNames(*)")]
		public IEnumerable<string> GetCategorylabelNames(string category)
		{
			return null;
		}

		public IEnumerable<string> GetCategoryLabelNames(string category)
		{
			return null;
		}

		public void AddCategoryLabel(Sprite sprite, string category, string label)
		{
		}

		public void RemoveCategoryLabel(string category, string label, bool deleteCategory)
		{
		}

		internal void UpdateHashes()
		{
		}

		internal void ValidateCategories(bool log = true)
		{
		}

		internal static void RenameDuplicate(IEnumerable<INameHash> nameHashList, Action<string, string> onRename)
		{
		}
	}
}
