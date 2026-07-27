namespace UnityEngine.U2D.Common.UTess
{
	internal sealed class ArrayDebugView<T> where T : struct
	{
		private Array<T> array;

		public T[] Items => null;

		public ArrayDebugView(Array<T> array)
		{
		}
	}
}
