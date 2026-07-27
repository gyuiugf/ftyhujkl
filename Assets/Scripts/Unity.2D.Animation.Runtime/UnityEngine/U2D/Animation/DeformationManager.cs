namespace UnityEngine.U2D.Animation
{
	internal class DeformationManager : ScriptableObject
	{
		private static DeformationManager s_Instance;

		private BaseDeformationSystem[] m_DeformationSystems;

		[SerializeField]
		private GameObject m_Helper;

		private bool m_WasUsingGpuDeformationLastFrame;

		public static DeformationManager instance => null;

		internal GameObject helperGameObject => null;

		private bool canUseGpuDeformation { get; set; }

		private void OnEnable()
		{
		}

		private void Init()
		{
		}

		private void CreateBatchSystems()
		{
		}

		private void CreateHelper()
		{
		}

		private void OnHelperDestroyed(GameObject helperGo)
		{
		}

		private void OnDisable()
		{
		}

		internal void Update()
		{
		}

		private bool HasToggledGpuDeformation()
		{
			return false;
		}

		private void MoveSpriteSkinsToActiveSystem()
		{
		}

		internal void AddSpriteSkin(SpriteSkin spriteSkin)
		{
		}

		internal void RemoveBoneTransforms(SpriteSkin spriteSkin)
		{
		}

		internal void AddSpriteSkinBoneTransform(SpriteSkin spriteSkin)
		{
		}
	}
}
