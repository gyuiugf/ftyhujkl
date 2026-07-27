namespace UnityEngine.U2D.Common.UTess
{
	internal sealed class ArraySliceDebugView<T> where T : struct
	{
		private ArraySlice<T> m_Slice;

		public T[] Items => null;

		public ArraySliceDebugView(ArraySlice<T> slice)
		{
		}
	}
}
