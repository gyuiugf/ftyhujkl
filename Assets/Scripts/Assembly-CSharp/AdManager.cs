using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class AdManager : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x000040F4 File Offset: 0x000022F4
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ACC8]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000418C File Offset: 0x0000238C
	private void Start()
	{
		Console.WriteLine("Unmanaged memory load: [523ACD0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523ACD8]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523ACE0]");
		object obj2 = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523ACE8]");
		object sdkKey = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		MaxSdkCallbacks.OnSdkInitializedEvent += obj;
		Console.WriteLine("Unmanaged memory load: [v51 @ X0_v12+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		MaxSdkAndroid.SetSdkKey(sdkKey);
		string[] adUnitIds;
		MaxSdkAndroid.InitializeSdk(adUnitIds);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000042E4 File Offset: 0x000024E4
	private void InitializeInterstitialAds()
	{
		Console.WriteLine("Unmanaged memory load: [523ACF0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523ACF8]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD00]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD08]");
		object method2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD10]");
		object method3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD18]");
		object method4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD20]");
		object method5 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD28]");
		object obj3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD30]");
		object method6 = (IntPtr)0;
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
		}
		for (;;)
		{
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method);
			MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj2..ctor(this, method2);
			MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += obj2;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method3);
			MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method4);
			MaxSdkCallbacks.Interstitial.OnAdClickedEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method5);
			MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor(this, method6);
			MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += obj3;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523AD38]");
			object method7 = (IntPtr)0;
			obj..ctor(this, method7);
			MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += obj;
			Console.WriteLine("Invalid instruction: 206 Invalid \"Jump target not found in method: 0x25CA414\"");
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000045A4 File Offset: 0x000027A4
	private void LoadInterstitial()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ACE0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X0_v4+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		MaxSdkAndroid.LoadInterstitial(this.InterstitialAdUnitId);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00004668 File Offset: 0x00002868
	private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
		int num;
		this.interstitialRetryAttempt = num;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00004680 File Offset: 0x00002880
	private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AD40]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		int val = obj;
		Console.WriteLine("Unmanaged memory load: [523AD48]");
		object methodName = (IntPtr)0;
		int num = (int)((long)this.interstitialRetryAttempt + 1L);
		this.interstitialRetryAttempt = num;
		Console.WriteLine("Unmanaged memory load: [v24 @ X0_v6 (System.Int32)+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		int num2 = Math.Min(val, adUnitId);
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		double x;
		double y;
		double time = Math.Pow(x, y);
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		base.Invoke(methodName, (float)time);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003F7E File Offset: 0x0000217E
	private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000047C0 File Offset: 0x000029C0
	private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
		/*
An exception occurred when decompiling this method (06000008)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void AdManager::OnInterstitialAdFailedToDisplayEvent(System.String,MaxSdkBase/ErrorInfo,MaxSdkBase/AdInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_54:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00003F80 File Offset: 0x00002180
	private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000482C File Offset: 0x00002A2C
	private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			this.adsTimer = this.startAdsTimer;
			this.LoadInterstitial();
			if (this.postAdAction != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523AD50]");
		object key = (IntPtr)0;
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
		int @int = PlayerPrefs.GetInt(key);
		Console.WriteLine("Unmanaged memory load: [523AD58]");
		object key2 = (IntPtr)0;
		PlayerPrefs.GetInt(key2);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00004918 File Offset: 0x00002B18
	private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
		if (adInfo != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (adInfo != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ACE0]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v24 @ X0_v5+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				MaxSdkBase.SdkConfiguration sdkConfiguration = MaxSdkAndroid.GetSdkConfiguration();
				if (sdkConfiguration != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00004A1C File Offset: 0x00002C1C
	public void ShowInterstitial(Action postAdAction_ = null, bool waitForTime = true)
	{
		string text;
		int stringLength;
		text._stringLength = stringLength;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		AdManager adManager;
		for (;;)
		{
			this.postAdAction = postAdAction_;
			Console.WriteLine("Method not found @24D64EC");
			bool flag = postAdAction_ == 0;
			if (flag)
			{
				Console.WriteLine("Unmanaged memory load: [523AD78]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v45 @ X0_v17+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v83 @ X0_v19+B8]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v87 @ X8_v1+8]");
				bool flag3 = (IntPtr)0 == 0;
				object obj3 = !flag3;
				Console.WriteLine("Unmanaged memory load: [v87 @ X8_v1+8]");
				Action action = (IntPtr)0;
				if (obj3 == null)
				{
					Console.WriteLine("Unmanaged memory load: [v83 @ X0_v19+E4]");
					bool flag4 = (IntPtr)0 == 0;
					object obj4 = !flag4;
					object @object = obj2;
					if (obj4 == null)
					{
						Console.WriteLine("Method not found @24D66BC");
						Console.WriteLine("Unmanaged memory load: [v210 @ X8_v2+B8]");
						@object = (IntPtr)0;
					}
					Console.WriteLine("Unmanaged memory load: [523AD60]");
					object obj5 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					Console.WriteLine("Unmanaged memory load: [523AD70]");
					object method = (IntPtr)0;
					obj5..ctor(@object, method);
					Console.WriteLine("Unmanaged memory load: [v114 @ X8_v7+B8]");
					object obj6 = (IntPtr)0;
					Console.WriteLine("Method not found @24D64EC");
				}
				Console.WriteLine("Method not found @24D64EC");
			}
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523AD68]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v95 @ X8_v12+B8]");
			object obj8 = (IntPtr)0;
			if (obj8 != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [523AD58]");
				object key = (IntPtr)0;
				int @int = PlayerPrefs.GetInt(key);
				adManager = this;
				AdManager adManager2 = this;
				for (;;)
				{
					Console.WriteLine("Unmanaged memory load: [523ACE0]");
					object obj9 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v245 @ X0_v29+E4]");
					bool flag5 = (IntPtr)0 == 0;
					if (flag5)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					bool flag6 = text == 0;
					bool flag7 = MaxSdkAndroid.IsInterstitialReady(adManager.InterstitialAdUnitId);
					if (flag6)
					{
						goto Block_6;
					}
					bool flag8 = adManager2 == 0;
					if (flag8)
					{
						break;
					}
					Console.WriteLine("Indirect call: 186 IndirectCall [v140 @ X8_v19+18] (should have been resolved before IL gen)");
					Console.WriteLine("Unmanaged memory load: [v0 @ X31 (System.String)+38]");
					adManager = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v0 @ X31 (System.String)+30]");
					adManager2 = (IntPtr)0;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Block_6:
		Console.WriteLine("Unmanaged memory load: [v257 @ X0_v33+E4]");
		bool flag9 = (IntPtr)0 == 0;
		if (flag9)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		MaxSdkAndroid.ShowInterstitial(adManager.InterstitialAdUnitId, text, text);
		Console.WriteLine("Unmanaged memory load: [523AD50]");
		object key2 = (IntPtr)0;
		int int2 = PlayerPrefs.GetInt(key2);
		PlayerPrefs.SetInt(key2, text);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00004EDC File Offset: 0x000030DC
	public void InitializeRewardedAds()
	{
		Console.WriteLine("Unmanaged memory load: [523ACF0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD80]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD00]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD88]");
		object method2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD90]");
		object method3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD98]");
		object method4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523ADA0]");
		object method5 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523ADA8]");
		object method6 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AD28]");
		object obj3 = (IntPtr)0;
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
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method);
			MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj2..ctor(this, method2);
			MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += obj2;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method3);
			MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method4);
			MaxSdkCallbacks.Rewarded.OnAdClickedEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method5);
			MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor(this, method6);
			MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += obj;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523ADB8]");
			object method7 = (IntPtr)0;
			obj3..ctor(this, method7);
			MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += obj3;
			Console.WriteLine("Unmanaged memory load: [523ADB0]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523ADC0]");
			object method8 = (IntPtr)0;
			obj4..ctor(this, method8);
			MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += obj4;
			Console.WriteLine("Invalid instruction: 233 Invalid \"Jump target not found in method: 0x25CAB7C\"");
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000051FC File Offset: 0x000033FC
	private void LoadRewardedAd()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ACE0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X0_v4+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		MaxSdkAndroid.LoadRewardedAd(this.RewardedAdUnitId);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000052C0 File Offset: 0x000034C0
	private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
		int num;
		this.retryAttempt = num;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000052D8 File Offset: 0x000034D8
	private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AD40]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		int val = obj;
		Console.WriteLine("Unmanaged memory load: [523ADC8]");
		object methodName = (IntPtr)0;
		int num = (int)((long)this.retryAttempt + 1L);
		this.retryAttempt = num;
		Console.WriteLine("Unmanaged memory load: [v24 @ X0_v6 (System.Int32)+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		int num2 = Math.Min(val, adUnitId);
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		double x;
		double y;
		double time = Math.Pow(x, y);
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		base.Invoke(methodName, (float)time);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00003F82 File Offset: 0x00002182
	private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00005418 File Offset: 0x00003618
	private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
		this.LoadRewardedAd();
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00003F84 File Offset: 0x00002184
	private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000542C File Offset: 0x0000362C
	private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
		this.LoadRewardedAd();
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00005440 File Offset: 0x00003640
	private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
	{
		Action action = this.rewardAction;
		if (this.rewardAction != 0)
		{
			Console.WriteLine("Indirect call: 10 IndirectCall [v0 @ X8_v1 (System.Action)+18] (should have been resolved before IL gen)");
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00005488 File Offset: 0x00003688
	private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
		if (adInfo != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (adInfo != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ACE0]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v24 @ X0_v5+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				MaxSdkBase.SdkConfiguration sdkConfiguration = MaxSdkAndroid.GetSdkConfiguration();
				if (sdkConfiguration != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000558C File Offset: 0x0000378C
	public void ShowRewardedAd(Action action, string placementName)
	{
		string text;
		int stringLength;
		text._stringLength = stringLength;
		Console.WriteLine("Unmanaged memory load: [523ACE0]");
		object obj = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		this.rewardAction = action;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [v37 @ X0_v5+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		bool flag2 = text == 0;
		bool flag3 = MaxSdkAndroid.IsRewardedAdReady(action);
		if (flag2)
		{
			Console.WriteLine("Unmanaged memory load: [v52 @ X0_v8+E4]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			MaxSdkAndroid.ShowRewardedAd(this.RewardedAdUnitId, placementName, text);
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00003F86 File Offset: 0x00002186
	private void TrackAdRevenue(MaxSdkBase.AdInfo adInfo)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00005714 File Offset: 0x00003914
	public void RemoveAds()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AD58]");
		object key = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			int value;
			PlayerPrefs.SetInt(key, value);
			if (this.uiManager != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		this.uiManager.DeactivateNoAdsButtons();
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000057C8 File Offset: 0x000039C8
	private void Update()
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000057F4 File Offset: 0x000039F4
	public AdManager()
	{
		Console.WriteLine("Unmanaged memory load: [523ADD0]");
		object interstitialAdUnitId = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523ADD8]");
		object rewardedAdUnitId = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		this.InterstitialAdUnitId = interstitialAdUnitId;
		Console.WriteLine("Method not found @24D64EC");
		this.RewardedAdUnitId = rewardedAdUnitId;
		Console.WriteLine("Method not found @24D64EC");
		base..ctor();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000058BC File Offset: 0x00003ABC
	private void <Start>b__14_0(MaxSdkBase.SdkConfiguration sdkConfiguration)
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AD58]");
		object key = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			int @int = PlayerPrefs.GetInt(key);
			object obj;
			bool flag2 = obj == 0;
			if (flag2)
			{
				this.InitializeInterstitialAds();
			}
			this.adsTimer = this.startAdsTimer;
			this.InitializeRewardedAds();
			if (this.sdksObject != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		bool active;
		this.sdksObject.SetActive(active);
	}

	// Token: 0x04000001 RID: 1
	public static AdManager Instance;

	// Token: 0x04000002 RID: 2
	public int interstitialRetryAttempt;

	// Token: 0x04000003 RID: 3
	public float adsTimer;

	// Token: 0x04000004 RID: 4
	public float startAdsTimer;

	// Token: 0x04000005 RID: 5
	public float firstAdTime;

	// Token: 0x04000006 RID: 6
	public Action postAdAction;

	// Token: 0x04000007 RID: 7
	private const string MaxSdkKey = "bF61hlGGdIsQMX2ZrGvetq7TAQG4AwDcJcGiHn6N291ctQJk0ME_epRlk1RfqssewEqSqVKyyBV98p2uCqNT9b";

	// Token: 0x04000008 RID: 8
	private string InterstitialAdUnitId;

	// Token: 0x04000009 RID: 9
	private string RewardedAdUnitId;

	// Token: 0x0400000A RID: 10
	private int retryAttempt;

	// Token: 0x0400000B RID: 11
	public Action rewardAction;

	// Token: 0x0400000C RID: 12
	public UIManager uiManager;

	// Token: 0x0400000D RID: 13
	public GameObject sdksObject;

	// Token: 0x0200007D RID: 125
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00042558 File Offset: 0x00040758
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
			Console.WriteLine("Unmanaged memory load: [523AD78]");
			object obj = (IntPtr)0;
			object obj2;
			if (obj2 == null)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			Console.WriteLine("Unmanaged memory load: [v27 @ X8_v1+B8]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000040B3 File Offset: 0x000022B3
		internal void <ShowInterstitial>b__24_0()
		{
		}

		// Token: 0x040003E6 RID: 998
		public static readonly AdManager.<>c <>9;

		// Token: 0x040003E7 RID: 999
		public static Action <>9__24_0;
	}
}
