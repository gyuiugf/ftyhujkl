using Unity.Jobs;

namespace UnityEngine.U2D.Animation
{
	internal class CpuDeformationSystem : BaseDeformationSystem
	{
		private const string k_GpuSkinningShaderKeyword = "SKINNED_SPRITE";

		private JobHandle m_CopyJobHandle;

		public override DeformationMethods deformationMethod => default(DeformationMethods);

		internal override void Cleanup()
		{
		}

		internal override void UpdateMaterial(SpriteSkin spriteSkin)
		{
		}

		internal override void Update()
		{
		}
	}
}
