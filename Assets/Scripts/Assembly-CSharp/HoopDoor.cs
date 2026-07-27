using System;
using UnityEngine;

// Token: 0x0200001D RID: 29
public class HoopDoor : MonoBehaviour
{
	// Token: 0x060000C8 RID: 200 RVA: 0x00011DFC File Offset: 0x0000FFFC
	private void OnTriggerExit2D(Collider2D other)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Hoop hoop;
		for (;;)
		{
			if (other != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AE38]");
				object obj = (IntPtr)0;
				Transform transform = other.transform;
				Console.WriteLine("Unmanaged memory load: [v59 @ X8_v2+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523ADE0]");
					object obj3 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v86 @ X0_v9+E4]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					object obj4;
					bool flag2 = obj4 == 0;
					UnityEngine.Object x = transform;
					Console.WriteLine("Unmanaged memory load: [v44 @ X8_v4+28]");
					bool flag3 = x == (IntPtr)0;
					if (!flag2)
					{
						return;
					}
					hoop = this.hoop;
					if (this.hoop != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		hoop.entrance = this.entrance;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00003FD9 File Offset: 0x000021D9
	private void Start()
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00003FDB File Offset: 0x000021DB
	private void Update()
	{
	}

	// Token: 0x040000E0 RID: 224
	public Hoop hoop;

	// Token: 0x040000E1 RID: 225
	public bool entrance;
}
