using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000060 RID: 96
	public class Benchmark04 : MonoBehaviour
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00035AC0 File Offset: 0x00033CC0
		private void Start()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Camera main;
			for (;;)
			{
				Transform transform = base.transform;
				this.m_Transform = transform;
				Console.WriteLine("Method not found @24D64EC");
				main = Camera.main;
				int height = Screen.height;
				Console.WriteLine("Not implemented instruction: Instruction CINC not yet implemented.");
				if (main != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Not implemented instruction: Instruction SBFM not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			float orthographicSize;
			main.orthographicSize = orthographicSize;
			int width = Screen.width;
			int height2 = Screen.height;
			int minPointSize = this.MinPointSize;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00035C3C File Offset: 0x00033E3C
		public Benchmark04()
		{
			Console.WriteLine("Unmanaged memory load: [DC1F50]");
			this.MinPointSize = (int)((IntPtr)0);
			base..ctor();
		}

		// Token: 0x04000330 RID: 816
		public int SpawnType;

		// Token: 0x04000331 RID: 817
		public int MinPointSize;

		// Token: 0x04000332 RID: 818
		public int MaxPointSize;

		// Token: 0x04000333 RID: 819
		public int Steps = (int)4L;

		// Token: 0x04000334 RID: 820
		private Transform m_Transform;
	}
}
