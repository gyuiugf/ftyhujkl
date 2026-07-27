using Unity.Collections;

namespace UnityEngine.U2D.Animation
{
	internal class NativeByteArray
	{
		public int Length => 0;

		public bool IsCreated => false;

		public byte this[int index] => 0;

		public NativeArray<byte> array { get; }

		public NativeByteArray(NativeArray<byte> array)
		{
		}

		public void Dispose()
		{
		}
	}
}
