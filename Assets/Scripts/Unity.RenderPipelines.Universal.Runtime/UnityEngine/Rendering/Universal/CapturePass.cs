using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class CapturePass : ScriptableRenderPass
	{
		private class UnsafePassData
		{
			internal TextureHandle source;

			public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions;
		}

		public CapturePass(RenderPassEvent evt)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}
	}
}
