using System;
using UnityEngine.U2D;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	internal class ShadowShape2DProvider_SpriteShape : ShadowShape2DProvider
	{
		private const float k_InitialTrim = 0.02f;

		internal void UpdateShadows(SpriteShapeController spriteShapeController, ShadowShape2D persistantShapeData)
		{
		}

		public override int Priority()
		{
			return 0;
		}

		public override void Enabled(Component sourceComponent, ShadowShape2D persistantShadowShape)
		{
		}

		public override void Disabled(Component sourceComponent, ShadowShape2D persistantShadowShape)
		{
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
