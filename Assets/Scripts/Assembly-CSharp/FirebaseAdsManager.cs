using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class FirebaseAdsManager : MonoBehaviour
{
	// Token: 0x06000059 RID: 89 RVA: 0x000083A0 File Offset: 0x000065A0
	private void Start()
	{
		Console.WriteLine("Unmanaged memory load: [523ACD0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AE60]");
		object method = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.OnSdkInitializedEvent += obj;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x0000845C File Offset: 0x0000665C
	private void OnAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo impressionData)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (impressionData != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AE70]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AE78]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AEC0]");
				object parameterName = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AE90]");
				object parameterValue = (IntPtr)0;
				Console.WriteLine("Method not found @24D662C");
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(parameterName, parameterValue);
				if (obj != 0)
				{
					if (obj2 == 0)
					{
						goto IL_1CC;
					}
					Console.WriteLine("Method not found @24D66C0");
					if (obj2 != 0)
					{
						goto IL_1CC;
					}
					IL_28D:
					Console.WriteLine("Method not found @24D680C");
					Console.WriteLine("Method not found @24D66AC");
					goto IL_2A6;
					IL_1CC:
					Console.WriteLine("Unmanaged memory load: [v43 @ X0_v26+18]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523AEA0]");
						object parameterName2 = (IntPtr)0;
						Console.WriteLine("Method not found @24D64EC");
						Console.WriteLine("Method not found @24D67D8");
						obj2..ctor(parameterName2, impressionData.<NetworkName>k__BackingField);
						if (obj2 != 0)
						{
							Console.WriteLine("Method not found @24D66C0");
							if (obj2 == 0)
							{
								goto IL_28D;
							}
						}
					}
					Console.WriteLine("Method not found @24D67F0");
					goto IL_28D;
				}
			}
			IL_2A6:
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003FB0 File Offset: 0x000021B0
	private void Update()
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0000874C File Offset: 0x0000694C
	private void <Start>b__1_0(MaxSdkBase.SdkConfiguration sdkConfiguration)
	{
		Console.WriteLine("Unmanaged memory load: [523ACF0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AEC8]");
		object method = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.MRec.OnAdRevenuePaidEvent += obj;
	}

	// Token: 0x04000050 RID: 80
	public FirebaseRCManager firebaseManager;
}
