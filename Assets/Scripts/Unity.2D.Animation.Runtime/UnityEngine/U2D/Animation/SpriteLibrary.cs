using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.U2D.Common;

namespace UnityEngine.U2D.Animation
{
	[DisallowMultipleComponent]
	[AddComponentMenu("2D Animation/Sprite Library")]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/SL-component.html")]
	public class SpriteLibrary : MonoBehaviour, IPreviewable, UnityEngine.Animations.IAnimationPreviewable
	{
		private struct CategoryEntrySprite
		{
			public string category;

			public string entry;

			public Sprite sprite;
		}

		[SerializeField]
		private List<SpriteLibCategory> m_Library;

		[SerializeField]
		private SpriteLibraryAsset m_SpriteLibraryAsset;

		private Dictionary<int, CategoryEntrySprite> m_CategoryEntryHashCache;

		private Dictionary<string, HashSet<string>> m_CategoryEntryCache;

		private int m_PreviousSpriteLibraryAsset;

		private long m_PreviousModificationHash;

		public SpriteLibraryAsset spriteLibraryAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal IEnumerable<string> categoryNames => null;

		private void OnEnable()
		{
		}

		public void OnPreviewUpdate()
		{
		}

		public Sprite GetSprite(string category, string label)
		{
			return null;
		}

		private Sprite GetSprite(int hash)
		{
			return null;
		}

		private void UpdateCacheOverridesIfNeeded()
		{
		}

		internal bool GetCategoryAndEntryNameFromHash(int hash, out string category, out string entry)
		{
			category = null;
			entry = null;
			return false;
		}

		internal static int GetHashForCategoryAndEntry(string category, string entry)
		{
			return 0;
		}

		internal Sprite GetSpriteFromCategoryAndEntryHash(int hash, out bool validEntry)
		{
			validEntry = default(bool);
			return null;
		}

		private List<SpriteCategoryEntry> GetEntries(string category, bool addIfNotExist)
		{
			return null;
		}

		private static SpriteCategoryEntry GetEntry(List<SpriteCategoryEntry> entries, string entry, bool addIfNotExist)
		{
			return null;
		}

		public void AddOverride(SpriteLibraryAsset spriteLib, string category, string label)
		{
		}

		public void AddOverride(SpriteLibraryAsset spriteLib, string category)
		{
		}

		public void AddOverride(Sprite sprite, string category, string label)
		{
		}

		public void RemoveOverride(string category)
		{
		}

		public void RemoveOverride(string category, string label)
		{
		}

		public bool HasOverride(string category, string label)
		{
			return false;
		}

		public void RefreshSpriteResolvers()
		{
		}

		internal IEnumerable<string> GetEntryNames(string category)
		{
			return null;
		}

		internal void CacheOverrides()
		{
		}
	}
}
