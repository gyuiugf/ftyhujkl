using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace UnityEngine.U2D.Common.UTess
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct TessEdgeCompare : IComparer<int2>
	{
		public int Compare(int2 a, int2 b)
		{
			return 0;
		}
	}
}
