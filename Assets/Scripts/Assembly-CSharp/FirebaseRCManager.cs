using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase;
using Firebase.Analytics;
using Firebase.Extensions;
using Firebase.RemoteConfig;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class FirebaseRCManager : MonoBehaviour
{
	// Token: 0x06000072 RID: 114 RVA: 0x0000A448 File Offset: 0x00008648
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AF70]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0000A4E0 File Offset: 0x000086E0
	public void ApplyRemoteConfig()
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		GameManager gameManager;
		for (;;)
		{
			AdManager adManager = this.adManager;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			if (this.adManager != 0)
			{
				gameManager = this.gameManager;
				adManager.firstAdTime = this.firstAdTime;
				if (this.gameManager != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		gameManager.inGameAds = this.inGameAds;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003FB6 File Offset: 0x000021B6
	private void Start()
	{
		/*
An exception occurred when decompiling this method (06000074)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void FirebaseRCManager::Start()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Invalid instruction: 0 Invalid \"Jump target not found in method: 0x25CE11C\"")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0000A59C File Offset: 0x0000879C
	private void InitializeFirebase()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AF78]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523AF80]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AF88]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v25 @ X0_v10+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Task<DependencyStatus> task = FirebaseApp.CheckAndFixDependenciesAsync();
		Console.WriteLine("Method not found @24D67D8");
		obj2..ctor(this, method);
		TaskExtension.ContinueWithOnMainThread<Int32Enum>(task, obj2);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000A6DC File Offset: 0x000088DC
	private void OnRemoteConfigFetched()
	{
		object obj2;
		object obj = obj2 - 80L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AF98]");
		object obj3 = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		FirebaseRemoteConfig defaultInstance;
		for (;;)
		{
			obj = obj;
			Console.WriteLine("Unmanaged memory load: [v29 @ X0_v16+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			defaultInstance = FirebaseRemoteConfig.DefaultInstance;
			if (defaultInstance != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523AFC0]");
		object key = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AFA0]");
		object obj4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AFB0]");
		object key2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AFB8]");
		object key3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AFA8]");
		object key4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AFC8]");
		object key5 = (IntPtr)0;
		ConfigValue value = defaultInstance.GetValue(key);
		obj = value;
		Console.WriteLine("Unmanaged memory load: [v68 @ X0_v21+E4]");
		bool flag3 = (IntPtr)0 == 0;
		if (flag3)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		ConfigValue configValue = obj + 0L;
		double doubleValue = configValue.DoubleValue;
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		float num;
		this.adTime = num;
		ConfigValue value2 = defaultInstance.GetValue(key2);
		obj = value2;
		ConfigValue configValue2 = obj + 0L;
		double doubleValue2 = configValue2.DoubleValue;
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		this.sessionAdStartTime = num;
		ConfigValue value3 = defaultInstance.GetValue(key3);
		obj = value3;
		ConfigValue configValue3 = obj + 0L;
		double doubleValue3 = configValue3.DoubleValue;
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		this.firstAdTime = num;
		ConfigValue value4 = defaultInstance.GetValue(key4);
		obj = value4;
		ConfigValue configValue4 = obj + 0L;
		double doubleValue4 = configValue4.DoubleValue;
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		this.reviewTime = num;
		ConfigValue value5 = defaultInstance.GetValue(key5);
		obj = value5;
		ConfigValue configValue5 = obj + 0L;
		bool booleanValue = configValue5.BooleanValue;
		object obj5;
		bool flag4 = (obj5 & 1L) != null;
		this.inGameAds = flag4;
		this.ApplyRemoteConfig();
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0000AAA8 File Offset: 0x00008CA8
	private void SetRemoteConfigDefaults()
	{
		object obj2;
		object obj = obj2 - 112L;
		Console.WriteLine("Unmanaged memory load: [523AFD0]");
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
		}
		FirebaseRemoteConfig defaultInstance;
		for (;;)
		{
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor();
			Console.WriteLine("Unmanaged memory load: [523AFF8]");
			object obj4 = (IntPtr)0;
			float num = this.adTime;
			Console.WriteLine("Method not found @24D66C4");
			if (obj3 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AFC0]");
				object obj5 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AFB0]");
				object obj6 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AFB8]");
				object obj7 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AFA8]");
				object obj8 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AFC8]");
				object obj9 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AF98]");
				object obj10 = (IntPtr)0;
				Dictionary<object, object> dictionary = obj3;
				object key = obj5;
				Console.WriteLine("Unmanaged memory load: [v45 @ X21_v3+78]");
				dictionary.Add(key, (IntPtr)0);
				float num2 = this.sessionAdStartTime;
				Console.WriteLine("Method not found @24D66C4");
				Dictionary<object, object> dictionary2 = obj3;
				object key2 = obj6;
				Console.WriteLine("Unmanaged memory load: [v45 @ X21_v3+78]");
				dictionary2.Add(key2, (IntPtr)0);
				float num3 = this.firstAdTime;
				Console.WriteLine("Method not found @24D66C4");
				Dictionary<object, object> dictionary3 = obj3;
				object key3 = obj7;
				Console.WriteLine("Unmanaged memory load: [v45 @ X21_v3+78]");
				dictionary3.Add(key3, (IntPtr)0);
				float num4 = this.reviewTime;
				Console.WriteLine("Method not found @24D66C4");
				Dictionary<object, object> dictionary4 = obj3;
				object key4 = obj8;
				Console.WriteLine("Unmanaged memory load: [v45 @ X21_v3+78]");
				dictionary4.Add(key4, (IntPtr)0);
				bool flag = this.inGameAds;
				Console.WriteLine("Method not found @24D66C4");
				Dictionary<object, object> dictionary5 = obj3;
				object key5 = obj9;
				Console.WriteLine("Unmanaged memory load: [v45 @ X21_v3+28]");
				dictionary5.Add(key5, (IntPtr)0);
				Console.WriteLine("Unmanaged memory load: [v198 @ X0_v36+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				defaultInstance = FirebaseRemoteConfig.DefaultInstance;
				if (defaultInstance != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523AFE0]");
		object obj11 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AFF0]");
		object method = (IntPtr)0;
		Task task = defaultInstance.SetDefaultsAsync(obj3);
		Console.WriteLine("Method not found @24D67D8");
		obj11..ctor(this, method);
		Task task2 = TaskExtension.ContinueWithOnMainThread(task, obj11);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0000AE2C File Offset: 0x0000902C
	public void UpdateTotalTime(float totalTime)
	{
		object obj2;
		object obj = obj2 - 48L;
		object obj3 = 46583808L;
		object format = obj3;
		bool flag = obj3 == 0;
		Console.WriteLine("Unmanaged memory load: [523AE68]");
		object obj4 = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		float num = obj + 12L;
		Console.WriteLine("Unmanaged memory load: [523B008]");
		object name = (IntPtr)0;
		string property = num.ToString(format);
		Console.WriteLine("Unmanaged memory load: [v38 @ X8_v1+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		FirebaseAnalytics.SetUserProperty(name, property);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0000AF6C File Offset: 0x0000916C
	public void FetchRemoteConfig(Action onFetchAndActivateSuccessful)
	{
		Console.WriteLine("Unmanaged memory load: [523B010]");
		object obj = (IntPtr)0;
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
		FirebaseRemoteConfig defaultInstance;
		for (;;)
		{
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			if (obj != 0)
			{
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Method not found @24D64EC");
				if (this.app == 0)
				{
					goto IL_243;
				}
				Console.WriteLine("Unmanaged memory load: [523AF98]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B020]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v116 @ X0_v20+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				defaultInstance = FirebaseRemoteConfig.DefaultInstance;
				Console.WriteLine("Unmanaged memory load: [v49 @ X8_v5+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				if (defaultInstance != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [v140 @ X8_v6+B8]");
		object cacheExpiration = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523AFE0]");
		object obj4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B028]");
		object method = (IntPtr)0;
		Task task = defaultInstance.FetchAsync(cacheExpiration);
		Console.WriteLine("Method not found @24D67D8");
		obj4..ctor(obj, method);
		TaskExtension.ContinueWithOnMainThread(task, obj4);
		return;
		IL_243:
		Console.WriteLine("Unmanaged memory load: [523B018]");
		object obj5 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v123 @ X0_v29+E4]");
		bool flag3 = (IntPtr)0 == 0;
		if (flag3)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Unmanaged memory load: [523B030]");
		object message = (IntPtr)0;
		Debug.LogError(message);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000B268 File Offset: 0x00009468
	private void ActivateRetrievedRemoteConfigValues(Action onFetchAndActivateSuccessful)
	{
		bool flag = onFetchAndActivateSuccessful == 0;
		Console.WriteLine("Unmanaged memory load: [523B038]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		FirebaseRemoteConfig defaultInstance;
		ConfigInfo info;
		for (;;)
		{
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			if (obj != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AF98]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Unmanaged memory load: [v60 @ X0_v15+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				defaultInstance = FirebaseRemoteConfig.DefaultInstance;
				if (defaultInstance != 0)
				{
					info = defaultInstance.Info;
					if (info != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		if (info.<LastFetchStatus>k__BackingField != LastFetchStatus.Success)
		{
			return;
		}
		Task<bool> task = defaultInstance.ActivateAsync();
		Console.WriteLine("Unmanaged memory load: [523B040]");
		object obj3 = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		Console.WriteLine("Unmanaged memory load: [523B050]");
		object method = (IntPtr)0;
		obj3..ctor(obj, method);
		Console.WriteLine("Method not found @2A9FD20");
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00003FC1 File Offset: 0x000021C1
	private void Update()
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000B494 File Offset: 0x00009694
	private void <InitializeFirebase>b__12_0(Task<DependencyStatus> previousTask)
	{
		object obj2;
		object obj = obj2 - 48L;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		while (previousTask == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
		Int32Enum result = previousTask.Result;
		object obj3;
		if (obj3 != 0)
		{
			Console.WriteLine("Unmanaged memory load: [523B058]");
			object arg = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B070]");
			object format = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B068]");
			object str = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B018]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Method not found @24D66C4");
			string str2 = string.Format(format, arg);
			string message = str2 + str;
			Console.WriteLine("Unmanaged memory load: [v53 @ X8_v8+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Debug.LogError(message);
			return;
		}
		Console.WriteLine("Unmanaged memory load: [523AF78]");
		object obj5 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v94 @ X0_v24+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		FirebaseApp defaultInstance = FirebaseApp.DefaultInstance;
		this.app = defaultInstance;
		Console.WriteLine("Method not found @24D64EC");
		this.SetRemoteConfigDefaults();
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000B6E0 File Offset: 0x000098E0
	private void <SetRemoteConfigDefaults>b__14_0(Task previousTask)
	{
		Console.WriteLine("Unmanaged memory load: [523AD60]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B078]");
		object method = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		this.FetchRemoteConfig(obj);
	}

	// Token: 0x04000053 RID: 83
	public static FirebaseRCManager Instance;

	// Token: 0x04000054 RID: 84
	public FirebaseApp app;

	// Token: 0x04000055 RID: 85
	public float adTime;

	// Token: 0x04000056 RID: 86
	public float sessionAdStartTime;

	// Token: 0x04000057 RID: 87
	public float firstAdTime;

	// Token: 0x04000058 RID: 88
	public float reviewTime;

	// Token: 0x04000059 RID: 89
	public bool inGameAds;

	// Token: 0x0400005A RID: 90
	public AdManager adManager;

	// Token: 0x0400005B RID: 91
	public GameManager gameManager;

	// Token: 0x0200007E RID: 126
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00042624 File Offset: 0x00040824
		internal void <FetchRemoteConfig>b__0(Task previousTask)
		{
			object obj2;
			object obj = obj2 - 48L;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			bool isCompleted;
			for (;;)
			{
				if (previousTask != 0)
				{
					bool flag = obj == 0;
					isCompleted = previousTask.IsCompleted;
					if (!flag)
					{
						goto IL_F2;
					}
					if (this.<>4__this != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			isCompleted.ActivateRetrievedRemoteConfigValues(this.onFetchAndActivateSuccessful);
			return;
			IL_F2:
			TaskStatus status = previousTask.Status;
			Console.WriteLine("Unmanaged memory load: [523B080]");
			object arg = (IntPtr)0;
			Console.WriteLine("Method not found @24D66C4");
			Console.WriteLine("Unmanaged memory load: [523B090]");
			object format = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B088]");
			object arg2 = (IntPtr)0;
			string message = string.Format(format, arg2, arg);
			Console.WriteLine("Unmanaged memory load: [523B018]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v63 @ X8_v11+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Debug.LogError(message);
		}

		// Token: 0x040003E8 RID: 1000
		public FirebaseRCManager <>4__this;

		// Token: 0x040003E9 RID: 1001
		public Action onFetchAndActivateSuccessful;
	}

	// Token: 0x0200007F RID: 127
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06000343 RID: 835 RVA: 0x00042824 File Offset: 0x00040A24
		internal void <ActivateRetrievedRemoteConfigValues>b__0(Task<bool> previousTask)
		{
			/*
An exception occurred when decompiling this method (06000343)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void FirebaseRCManager/<>c__DisplayClass17_0::<ActivateRetrievedRemoteConfigValues>b__0(System.Threading.Tasks.Task`1<System.Boolean>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_38:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x040003EA RID: 1002
		public Action onFetchAndActivateSuccessful;
	}
}
