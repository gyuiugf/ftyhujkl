using System;
using UnityEngine.U2D.Animation;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	internal class ShadowShape2DProvider_SpriteSkin : ShadowShape2DProvider
	{
		private const float k_InitialTrim = 0.05f;

		private ShadowShape2D m_PersistantShapeData;

		private int m_LastDeformedVertexHash;

		private void TryToSetPersistantShapeData(SpriteSkin spriteSkin, ShadowShape2D persistantShadowShape, bool force)
		{
		}

		private void UpdatePersistantShapeData(SpriteRenderer spriteRenderer)
		{
		}

		public override int Priority()
		{
			return 0;
		}

		public override bool IsShapeSource(Component sourceComponent)
		{
			return false;
		}

		public override void OnPersistantDataCreated(Component sourceComponent, ShadowShape2D persistantShadowShape)
		{
		}

		public override void OnBeforeRender(Component sourceComponent, Bounds worldCullingBounds, ShadowShape2D persistantShadowShape)
		{
		}
	}
}
