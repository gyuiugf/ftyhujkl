using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.U2D.Common.UTess
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct XCompare : IComparer<double>
	{
		public int Compare(double a, double b)
		{
			return 0;
		}
	}
}
