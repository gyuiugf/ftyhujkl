using System;
using Unity.Profiling;

namespace UnityEngine.U2D.Animation
{
	[AddComponentMenu(null)]
	[DefaultExecutionOrder(10)]
	[ExecuteInEditMode]
	internal class DeformationManagerUpdater : MonoBehaviour
	{
		private ProfilerMarker m_ProfilerMarker;

		public Action<GameObject> onDestroyingComponent { get; set; }

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
