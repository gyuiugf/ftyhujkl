using System.Collections.Generic;
using Unity.Mathematics;

namespace UnityEngine.U2D.Common.UTess
{
	internal struct IntersectionCompare : IComparer<int2>
	{
		public Array<double2> points;

		public Array<int2> edges;

		public unsafe fixed double xvasort[4];

		public unsafe fixed double xvbsort[4];

		public int Compare(int2 a, int2 b)
		{
			return 0;
		}
	}
}
