using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class NeedleTop : MonoBehaviour
{
	// Token: 0x0600013F RID: 319 RVA: 0x0001A600 File Offset: 0x00018800
	private void OnTriggerEnter2D(Collider2D collision)
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Needle needle;
		for (;;)
		{
			if (collision != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AE38]");
				object obj = (IntPtr)0;
				Transform transform = collision.transform;
				Console.WriteLine("Unmanaged memory load: [v94 @ X8_v2+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523ADE0]");
					object obj3 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v128 @ X0_v11+E4]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					bool flag2 = @object == 0;
					UnityEngine.Object x = transform;
					Console.WriteLine("Unmanaged memory load: [v54 @ X8_v4+20]");
					bool flag3 = x == (IntPtr)0;
					if (flag2)
					{
						Console.WriteLine("Unmanaged memory load: [v140 @ X8_v5+B8]");
						object obj4 = (IntPtr)0;
						if (obj4 == 0)
						{
							goto IL_449;
						}
						Console.WriteLine("Unmanaged memory load: [v55 @ X8_v7+30]");
						if ((IntPtr)0 == 0)
						{
							goto IL_449;
						}
						Console.WriteLine("Unmanaged memory load: [v55 @ X8_v7+30]");
						((IntPtr)0).OnSpike();
					}
					Transform transform2 = collision.transform;
					Console.WriteLine("Unmanaged memory load: [v152 @ X8_v9+B8]");
					object obj5 = (IntPtr)0;
					if (obj5 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [v158 @ X0_v18+E4]");
						bool flag4 = (IntPtr)0 == 0;
						if (flag4)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag5 = @object == 0;
						UnityEngine.Object x2 = transform2;
						Console.WriteLine("Unmanaged memory load: [v56 @ X8_v11+28]");
						bool flag6 = x2 == (IntPtr)0;
						if (flag5)
						{
							Console.WriteLine("Unmanaged memory load: [v171 @ X8_v12+B8]");
							object obj6 = (IntPtr)0;
							if (obj6 == 0)
							{
								goto IL_449;
							}
							Console.WriteLine("Unmanaged memory load: [v57 @ X8_v14+38]");
							if ((IntPtr)0 == 0)
							{
								goto IL_449;
							}
							Console.WriteLine("Unmanaged memory load: [v57 @ X8_v14+38]");
							((IntPtr)0).OnSpike();
						}
						Console.WriteLine("Method not found @2894080");
						Console.WriteLine("Unmanaged memory load: [v58 @ X8_v18+E4]");
						bool flag7 = (IntPtr)0 == 0;
						if (flag7)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag8 = @object == 0;
						bool flag9 = collision != @object;
						if (!flag8)
						{
							return;
						}
						if (collision != 0)
						{
							RigidbodyType2D bodyType = collision.bodyType;
							object obj7;
							if (obj7 == 0)
							{
								return;
							}
							needle = this.needle;
							if (this.needle != 0)
							{
								break;
							}
						}
					}
				}
			}
			IL_449:
			Console.WriteLine("Method not found @24D67E8");
		}
		needle.staticHit = (1L != 0L);
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00004011 File Offset: 0x00002211
	private void Start()
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00004013 File Offset: 0x00002213
	private void Update()
	{
	}

	// Token: 0x04000166 RID: 358
	public Needle needle;
}
