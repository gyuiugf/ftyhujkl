using System.Collections.Generic;

namespace UnityEngine.U2D.Animation
{
	internal class SpriteLibrarySourceAsset : ScriptableObject
	{
		public const string defaultName = "New Sprite Library Asset";

		public const string extension = ".spriteLib";

		[SerializeField]
		private List<SpriteLibCategoryOverride> m_Library;

		[SerializeField]
		private string m_PrimaryLibraryGUID;

		[SerializeField]
		private long m_ModificationHash;

		[SerializeField]
		private int m_Version;

		public IReadOnlyList<SpriteLibCategoryOverride> library => null;

		public string primaryLibraryGUID => null;

		public long modificationHash => 0L;

		public int version => 0;

		public void InitializeWithAsset(SpriteLibrarySourceAsset source)
		{
		}

		public void SetLibrary(IList<SpriteLibCategoryOverride> newLibrary)
		{
		}

		public void SetPrimaryLibraryGUID(string newPrimaryLibraryGUID)
		{
		}

		public void AddCategory(SpriteLibCategoryOverride newCategory)
		{
		}

		public void RemoveCategory(SpriteLibCategoryOverride categoryToRemove)
		{
		}

		public void ClearCategories()
		{
		}

		public void RemoveCategory(int indexToRemove)
		{
		}

		private void UpdateModificationHash()
		{
		}
	}
}
