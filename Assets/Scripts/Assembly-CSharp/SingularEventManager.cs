using System;
using Singular;
using UnityEngine;
using UnityEngine.Purchasing;

// Token: 0x0200003B RID: 59
public class SingularEventManager : MonoBehaviour
{
	// Token: 0x06000194 RID: 404 RVA: 0x0001F0A8 File Offset: 0x0001D2A8
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B640]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0001F140 File Offset: 0x0001D340
	public void LogIAPEvent(ConfirmedOrder order)
	{
		bool flag = order == 0;
		Console.WriteLine("Unmanaged memory load: [523B648]");
		object key = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		int @int = PlayerPrefs.GetInt(key);
		object obj;
		if (obj != 0)
		{
			return;
		}
		Console.WriteLine("Unmanaged memory load: [523B628]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v39 @ X0_v9+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		SingularSDK.InAppPurchase(order);
		int value;
		PlayerPrefs.SetInt(key, value);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0001F260 File Offset: 0x0001D460
	public void LogLevelSolved(int levelCount)
	{
		object obj2;
		object obj = obj2 - 64L;
		Console.WriteLine("Unmanaged memory load: [523AFD0]");
		object obj3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B650]");
		object obj4 = (IntPtr)0;
		object obj5;
		if (obj5 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor();
			Console.WriteLine("Method not found @24D662C");
			if (obj4 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B660]");
				object obj6 = (IntPtr)0;
				if (obj6 == 0)
				{
					goto IL_145;
				}
				Console.WriteLine("Method not found @24D66C0");
				if (obj6 != 0)
				{
					goto IL_145;
				}
				IL_205:
				Console.WriteLine("Method not found @24D680C");
				Console.WriteLine("Method not found @24D66AC");
				goto IL_21E;
				IL_145:
				Console.WriteLine("Unmanaged memory load: [v40 @ X0_v15+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Unmanaged memory load: [523AFF8]");
					object obj7 = (IntPtr)0;
					Console.WriteLine("Method not found @24D66C4");
					Console.WriteLine("Unmanaged memory load: [v111 @ X8_v4+48]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Method not found @24D66C0");
						Console.WriteLine("Unmanaged memory load: [v111 @ X8_v4+48]");
						if ((IntPtr)0 == 0)
						{
							goto IL_205;
						}
					}
				}
				Console.WriteLine("Method not found @24D67F0");
				goto IL_205;
			}
			IL_21E:
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000404B File Offset: 0x0000224B
	private void Start()
	{
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000404D File Offset: 0x0000224D
	private void Update()
	{
	}

	// Token: 0x040001A6 RID: 422
	public static SingularEventManager Instance;
}
