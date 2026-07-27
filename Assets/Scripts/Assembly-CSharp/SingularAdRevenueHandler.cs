using System;
using UnityEngine;

// Token: 0x0200003A RID: 58
public class SingularAdRevenueHandler : MonoBehaviour
{
	// Token: 0x06000190 RID: 400 RVA: 0x0001ECE0 File Offset: 0x0001CEE0
	private void Start()
	{
		Console.WriteLine("Unmanaged memory load: [523ACF0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B618]");
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
		MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.MRec.OnAdRevenuePaidEvent += obj;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0001EE14 File Offset: 0x0001D014
	private void OnAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
		if (adInfo != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		while (adInfo == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [523B018]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v32 @ X0_v15+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Unmanaged memory load: [523B638]");
		object message = (IntPtr)0;
		Debug.LogError(message);
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0001EF60 File Offset: 0x0001D160
	private void OnDestroy()
	{
		Console.WriteLine("Unmanaged memory load: [523ACF0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B618]");
		object method = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent -= obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent -= obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent -= obj;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.MRec.OnAdRevenuePaidEvent -= obj;
	}
}
