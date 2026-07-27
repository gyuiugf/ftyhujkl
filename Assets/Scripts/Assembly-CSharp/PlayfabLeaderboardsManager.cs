using System;
using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000033 RID: 51
public class PlayfabLeaderboardsManager : MonoBehaviour
{
	// Token: 0x0600015E RID: 350 RVA: 0x0001BCC8 File Offset: 0x00019EC8
	private void OnEnable()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj;
		Button button2;
		for (;;)
		{
			Button button = this.backButton;
			if (this.backButton != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B128]");
				obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B520]");
				object method = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor(this, method);
				if (button.m_OnClick != 0)
				{
					button.m_OnClick.AddListener(obj);
					button2 = this.editUsernameButton;
					if (this.editUsernameButton != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523B528]");
						object method2 = (IntPtr)0;
						Console.WriteLine("Method not found @24D67D8");
						obj..ctor(this, method2);
						if (button2.m_OnClick != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		button2.m_OnClick.AddListener(obj);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0001BE78 File Offset: 0x0001A078
	private void OnDisable()
	{
		/*
An exception occurred when decompiling this method (0600015F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void PlayfabLeaderboardsManager::OnDisable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_BD:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0001BF4C File Offset: 0x0001A14C
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B198]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0001BFE4 File Offset: 0x0001A1E4
	public void OpenLeaderboardsPanel()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Transform transform2;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [5592131]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523B400]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v35 @ X8_v3+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v39 @ X8_v5+21]");
				if ((IntPtr)0 == 0)
				{
					return;
				}
				if (this.leaderboardsPanel != 0)
				{
					bool active;
					this.leaderboardsPanel.SetActive(active);
					if (this.loadingAnimation != 0)
					{
						GameObject gameObject = this.loadingAnimation.gameObject;
						if (gameObject != 0)
						{
							bool active2;
							gameObject.SetActive(active2);
							this.myScoreField = active2;
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
							if (this != 0)
							{
								Transform transform = base.transform;
								if (transform != 0)
								{
									int childCount = transform.childCount;
									if (this.aroundScoresContent != 0)
									{
										transform2 = this.aroundScoresContent.transform;
										if (transform2 != 0)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		int childCount2 = transform2.childCount;
		this.RequestSpeedrunLeaderboard();
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0001C27C File Offset: 0x0001A47C
	public void RequestSpeedrunLeaderboard()
	{
		object obj2;
		object obj = obj2 - 80L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B530]");
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
			Console.WriteLine("Method not found @24D6540");
		}
		GetLeaderboardRequest getLeaderboardRequest;
		for (;;)
		{
			getLeaderboardRequest = obj3;
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor();
			if (obj3 != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523B538]");
		object obj4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B548]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B558]");
		object obj5 = (IntPtr)0;
		getLeaderboardRequest.StatisticName = this.speedrunLeaderboardID;
		Console.WriteLine("Method not found @24D64EC");
		int? num = obj + 8L;
		num = new int?(this.speedrunLeaderboardID);
		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Object)+8]");
		IntPtr intPtr = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		obj4..ctor(this, method);
		Console.WriteLine("Unmanaged memory load: [v131 @ X0_v23+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Unmanaged memory load: [v137 @ X0_v25+B8]");
		object obj6 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B3D0]");
		object obj7 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v141 @ X8_v3+8]");
		bool flag3 = (IntPtr)0 == 0;
		object obj8 = !flag3;
		Console.WriteLine("Unmanaged memory load: [v141 @ X8_v3+8]");
		Action<PlayFabError> errorCallback = (IntPtr)0;
		if (obj8 == null)
		{
			Console.WriteLine("Unmanaged memory load: [v137 @ X0_v25+E4]");
			bool flag4 = (IntPtr)0 == 0;
			object obj9 = !flag4;
			object @object = obj6;
			if (obj9 == null)
			{
				Console.WriteLine("Method not found @24D66BC");
				Console.WriteLine("Unmanaged memory load: [v187 @ X8_v4+B8]");
				@object = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [523B3B0]");
			object obj10 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523B550]");
			object method2 = (IntPtr)0;
			obj10..ctor(@object, method2);
			Console.WriteLine("Unmanaged memory load: [v156 @ X8_v9+B8]");
			object obj11 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			errorCallback = obj10;
		}
		Console.WriteLine("Unmanaged memory load: [v170 @ X0_v29+E4]");
		bool flag5 = (IntPtr)0 == 0;
		if (flag5)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		PlayFabClientAPI.GetLeaderboard(obj3, obj4, errorCallback, obj, obj);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0001C638 File Offset: 0x0001A838
	private void DisplaySpeedrunLeaderboard(GetLeaderboardResult result, bool displayAroundLeaderboard = false)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			bool flag = this.loadingAnimation == 0;
			bool flag2 = flag;
			if (flag)
			{
				goto IL_14B;
			}
			GameObject gameObject = this.loadingAnimation.gameObject;
			bool flag3 = gameObject == 0;
			flag2 = flag3;
			if (flag3)
			{
				goto IL_14B;
			}
			bool active;
			gameObject.SetActive(active);
			bool flag4 = result == 0;
			flag2 = flag4;
			if (flag4)
			{
				goto IL_14B;
			}
			List<PlayerLeaderboardEntry> leaderboard = result.Leaderboard;
			bool flag5 = result.Leaderboard == 0;
			flag2 = flag5;
			if (flag5)
			{
				goto IL_14B;
			}
			object obj2;
			object obj = obj2;
			Console.WriteLine("Unmanaged memory load: [v49 @ X0_v14 (System.Collections.Generic.List`1<PlayFab.ClientModels.PlayerLeaderboardEntry>)+18]");
			object obj3 = obj - (IntPtr)0;
			bool flag6 = obj3 == 0;
			bool flag7 = flag6;
			IL_162:
			if (flag7)
			{
				break;
			}
			Console.WriteLine("Invalid instruction: 249 Invalid \"Jump target not found in method: 0x25DA13C\"");
			continue;
			IL_14B:
			Console.WriteLine("Method not found @24D67E8");
			flag7 = flag2;
			goto IL_162;
		}
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0001C824 File Offset: 0x0001AA24
	public void RequestSpeedrunLeaderboardAroundPlayer()
	{
		object obj2;
		object obj = obj2 - 80L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B580]");
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
			Console.WriteLine("Method not found @24D6540");
		}
		GetLeaderboardAroundPlayerRequest getLeaderboardAroundPlayerRequest;
		for (;;)
		{
			getLeaderboardAroundPlayerRequest = obj3;
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor();
			if (obj3 != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523B588]");
		object obj4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B590]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B558]");
		object obj5 = (IntPtr)0;
		getLeaderboardAroundPlayerRequest.StatisticName = this.speedrunLeaderboardID;
		Console.WriteLine("Method not found @24D64EC");
		int? num = obj + 8L;
		num = new int?(this.speedrunLeaderboardID);
		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Object)+8]");
		IntPtr intPtr = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		obj4..ctor(this, method);
		Console.WriteLine("Unmanaged memory load: [v130 @ X0_v23+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Unmanaged memory load: [v136 @ X0_v25+B8]");
		object obj6 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B3D0]");
		object obj7 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v140 @ X8_v3+10]");
		bool flag3 = (IntPtr)0 == 0;
		object obj8 = !flag3;
		Console.WriteLine("Unmanaged memory load: [v140 @ X8_v3+10]");
		Action<PlayFabError> errorCallback = (IntPtr)0;
		if (obj8 == null)
		{
			Console.WriteLine("Unmanaged memory load: [v136 @ X0_v25+E4]");
			bool flag4 = (IntPtr)0 == 0;
			object obj9 = !flag4;
			object @object = obj6;
			if (obj9 == null)
			{
				Console.WriteLine("Method not found @24D66BC");
				Console.WriteLine("Unmanaged memory load: [v186 @ X8_v4+B8]");
				@object = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [523B3B0]");
			object obj10 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523B598]");
			object method2 = (IntPtr)0;
			obj10..ctor(@object, method2);
			Console.WriteLine("Unmanaged memory load: [v155 @ X8_v9+B8]");
			object obj11 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			errorCallback = obj10;
		}
		Console.WriteLine("Unmanaged memory load: [v169 @ X0_v29+E4]");
		bool flag5 = (IntPtr)0 == 0;
		if (flag5)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		PlayFabClientAPI.GetLeaderboardAroundPlayer(obj3, obj4, errorCallback, obj, obj);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0001CBDC File Offset: 0x0001ADDC
	private void DisplaySpeedrunLeaderboardAroundThePlayer(GetLeaderboardAroundPlayerResult result)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		if (this.aroundScoresContent != 0)
		{
			GameObject gameObject = this.aroundScoresContent.gameObject;
			if (gameObject != 0)
			{
				bool active;
				gameObject.SetActive(active);
				if (result != 0 && result.Leaderboard != 0)
				{
					return;
				}
			}
		}
		Console.WriteLine("Method not found @24D67E8");
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0001CD44 File Offset: 0x0001AF44
	public void SubmitScoreSpeedrun(int playerScore, Action successAction = null, Action failureAction = null, int delay = 1)
	{
		Console.WriteLine("Unmanaged memory load: [523B3A0]");
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
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj4;
		object obj6;
		object obj7;
		object obj8;
		UpdatePlayerStatisticsRequest updatePlayerStatisticsRequest;
		object obj9;
		for (;;)
		{
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			if (obj != 0)
			{
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Unmanaged memory load: [5592131]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [523B400]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v209 @ X8_v4+B8]");
				object obj3 = (IntPtr)0;
				if (obj3 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v80 @ X8_v6+21]");
					if ((IntPtr)0 == 0)
					{
						break;
					}
					bool flag2 = obj4 == 0;
					Console.WriteLine("Unmanaged memory load: [v80 @ X8_v6+40]");
					bool flag3 = string.IsNullOrEmpty((IntPtr)0);
					if (flag2)
					{
						Console.WriteLine("Unmanaged memory load: [5592132]");
						bool flag4 = (IntPtr)0 == 0;
						if (flag4)
						{
							Console.WriteLine("Method not found @24D6540");
						}
						Console.WriteLine("Unmanaged memory load: [523B408]");
						object obj5 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v248 @ X8_v9+B8]");
						obj6 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [523AD60]");
						obj7 = (IntPtr)0;
						Console.WriteLine("Method not found @24D67D8");
						Console.WriteLine("Unmanaged memory load: [523B3E0]");
						object method = (IntPtr)0;
						obj7..ctor(obj, method);
						if (obj6 != 0)
						{
							goto Block_13;
						}
					}
					else
					{
						Console.WriteLine("Unmanaged memory load: [523B3F8]");
						obj8 = (IntPtr)0;
						updatePlayerStatisticsRequest = obj8;
						Console.WriteLine("Method not found @24D67D8");
						obj8..ctor();
						Console.WriteLine("Unmanaged memory load: [523B3C8]");
						obj9 = (IntPtr)0;
						Console.WriteLine("Method not found @24D67D8");
						obj9..ctor();
						Console.WriteLine("Unmanaged memory load: [523B3D8]");
						object obj10 = (IntPtr)0;
						StatisticUpdate statisticUpdate = obj10;
						Console.WriteLine("Method not found @24D67D8");
						obj10..ctor();
						if (obj10 != 0)
						{
							statisticUpdate.StatisticName = this.speedrunLeaderboardID;
							Console.WriteLine("Method not found @24D64EC");
							object obj12;
							object obj11 = obj12;
							Console.WriteLine("Unmanaged memory load: [v40 @ X0_v28 (System.Object)+18]");
							object obj13 = obj11 - (IntPtr)0;
							if (obj9 != 0)
							{
								Console.WriteLine("Unmanaged memory load: [v264 @ X0_v44 (System.Collections.Generic.List`1<System.Object>)+1C]");
								object obj14 = (IntPtr)0 + 1;
								Console.WriteLine("Unmanaged memory load: [v264 @ X0_v44 (System.Collections.Generic.List`1<System.Object>)+10]");
								if ((IntPtr)0 != 0)
								{
									Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
									obj9.AddWithResize(obj10);
									if (obj8 != 0)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_9:
		updatePlayerStatisticsRequest.Statistics = obj9;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Unmanaged memory load: [523B3A8]");
		object obj15 = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		Console.WriteLine("Unmanaged memory load: [523B3E8]");
		object method2 = (IntPtr)0;
		obj15..ctor(obj, method2);
		Console.WriteLine("Unmanaged memory load: [523B3B0]");
		object obj16 = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		Console.WriteLine("Unmanaged memory load: [523B3F0]");
		object method3 = (IntPtr)0;
		obj16..ctor(obj, method3);
		Console.WriteLine("Unmanaged memory load: [523B3D0]");
		object obj17 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v330 @ X0_v51+E4]");
		bool flag5 = (IntPtr)0 == 0;
		if (flag5)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		PlayFabClientAPI.UpdatePlayerStatistics(obj8, obj15, obj16, obj4, obj4);
		return;
		Block_13:
		obj6.OpenUsernamePopup(obj7);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0001D348 File Offset: 0x0001B548
	public void InvokeDelayed(Action action, float delay)
	{
		IEnumerator routine = this.InvokeDelayedRoutine(action, delay);
		base.StartCoroutine(routine);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0001D380 File Offset: 0x0001B580
	private IEnumerator InvokeDelayedRoutine(Action action, float delay)
	{
		if (action != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		object obj;
		obj..ctor();
		Console.WriteLine("Method not found @24D64EC");
		return obj;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00004031 File Offset: 0x00002231
	private void Start()
	{
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00004033 File Offset: 0x00002233
	private void Update()
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0001D434 File Offset: 0x0001B634
	private void <OnEnable>b__14_0()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE28]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				obj2.PlayClickSound();
				if (this.leaderboardsPanel != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		bool active;
		this.leaderboardsPanel.SetActive(active);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0001D51C File Offset: 0x0001B71C
	private void <OnEnable>b__14_1()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE28]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj3;
		object obj5;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v25 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AD60]");
				obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B5A8]");
				object method = (IntPtr)0;
				obj2.PlayClickSound();
				Console.WriteLine("Unmanaged memory load: [5592132]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [523B408]");
				object obj4 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v99 @ X8_v6+B8]");
				obj5 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj3..ctor(this, method);
				if (obj5 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj5.OpenUsernamePopup(obj3);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0001D6D4 File Offset: 0x0001B8D4
	private void <OnEnable>b__14_2()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ADE0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v23 @ X0_v4+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag3 = @object == 0;
			bool flag4 = this.myScoreField != @object;
			if (!flag3)
			{
				return;
			}
			Console.WriteLine("Unmanaged memory load: [5592131]");
			bool flag5 = (IntPtr)0 == 0;
			if (flag5)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523B400]");
			object obj2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v61 @ X8_v4+B8]");
			object obj3 = (IntPtr)0;
			if (obj3 != 0 && this.myScoreField != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		ScoreField scoreField = this.myScoreField;
		Console.WriteLine("Unmanaged memory load: [v65 @ X8_v6+40]");
		scoreField.ChangeUsername((IntPtr)0);
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
	private void <RequestSpeedrunLeaderboard>b__18_0(GetLeaderboardResult result)
	{
		bool displayAroundLeaderboard;
		this.DisplaySpeedrunLeaderboard(result, displayAroundLeaderboard);
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0001D8D0 File Offset: 0x0001BAD0
	private void <RequestSpeedrunLeaderboardAroundPlayer>b__20_0(GetLeaderboardAroundPlayerResult result)
	{
		this.DisplaySpeedrunLeaderboardAroundThePlayer(result);
	}

	// Token: 0x04000182 RID: 386
	public static PlayfabLeaderboardsManager Instance;

	// Token: 0x04000183 RID: 387
	public string speedrunLeaderboardID;

	// Token: 0x04000184 RID: 388
	public GameObject scoreFieldPrefab;

	// Token: 0x04000185 RID: 389
	public Transform topScoresContent;

	// Token: 0x04000186 RID: 390
	public Transform aroundScoresContent;

	// Token: 0x04000187 RID: 391
	public Color firstPlaceColor;

	// Token: 0x04000188 RID: 392
	public Color topTenColor;

	// Token: 0x04000189 RID: 393
	public Color normalColor;

	// Token: 0x0400018A RID: 394
	public Color myColor;

	// Token: 0x0400018B RID: 395
	public GameObject loadingAnimation;

	// Token: 0x0400018C RID: 396
	public GameObject leaderboardsPanel;

	// Token: 0x0400018D RID: 397
	public Button backButton;

	// Token: 0x0400018E RID: 398
	public ScoreField myScoreField;

	// Token: 0x0400018F RID: 399
	public Button editUsernameButton;

	// Token: 0x02000084 RID: 132
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000358 RID: 856 RVA: 0x00043098 File Offset: 0x00041298
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
			Console.WriteLine("Unmanaged memory load: [523B558]");
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

		// Token: 0x0600035A RID: 858 RVA: 0x000040BB File Offset: 0x000022BB
		internal void <RequestSpeedrunLeaderboard>b__18_1(PlayFabError err)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000040BD File Offset: 0x000022BD
		internal void <RequestSpeedrunLeaderboardAroundPlayer>b__20_1(PlayFabError err)
		{
		}

		// Token: 0x040003FA RID: 1018
		public static readonly PlayfabLeaderboardsManager.<>c <>9;

		// Token: 0x040003FB RID: 1019
		public static Action<PlayFabError> <>9__18_1;

		// Token: 0x040003FC RID: 1020
		public static Action<PlayFabError> <>9__20_1;
	}

	// Token: 0x02000085 RID: 133
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x0600035D RID: 861 RVA: 0x00043164 File Offset: 0x00041364
		internal void <SubmitScoreSpeedrun>b__0()
		{
			/*
An exception occurred when decompiling this method (0600035D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void PlayfabLeaderboardsManager/<>c__DisplayClass22_0::<SubmitScoreSpeedrun>b__0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_3F:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000431C0 File Offset: 0x000413C0
		internal void <SubmitScoreSpeedrun>b__1(UpdatePlayerStatisticsResult result)
		{
			Action action = this.successAction;
			if (this.successAction != 0)
			{
				Console.WriteLine("Indirect call: 10 IndirectCall [v0 @ X8_v1 (System.Action)+18] (should have been resolved before IL gen)");
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00043208 File Offset: 0x00041408
		internal void <SubmitScoreSpeedrun>b__2(PlayFabError err)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Action action = this.failureAction;
			if (this.failureAction != 0)
			{
				Console.WriteLine("Indirect call: 88 IndirectCall [v28 @ X8_v1 (System.Action)+18] (should have been resolved before IL gen)");
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000432BC File Offset: 0x000414BC
		internal void <SubmitScoreSpeedrun>b__3()
		{
			/*
An exception occurred when decompiling this method (06000360)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void PlayfabLeaderboardsManager/<>c__DisplayClass22_0::<SubmitScoreSpeedrun>b__3()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_3F:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x040003FD RID: 1021
		public PlayfabLeaderboardsManager <>4__this;

		// Token: 0x040003FE RID: 1022
		public int playerScore;

		// Token: 0x040003FF RID: 1023
		public Action successAction;

		// Token: 0x04000400 RID: 1024
		public Action failureAction;

		// Token: 0x04000401 RID: 1025
		public int delay;

		// Token: 0x04000402 RID: 1026
		public Action <>9__3;
	}

	// Token: 0x02000086 RID: 134
	private sealed class <InvokeDelayedRoutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000361 RID: 865 RVA: 0x00043318 File Offset: 0x00041518
		public <InvokeDelayedRoutine>d__24(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000040BF File Offset: 0x000022BF
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00043344 File Offset: 0x00041544
		bool IEnumerator.MoveNext()
		{
			bool flag = this == 0;
			PlayfabLeaderboardsManager.<InvokeDelayedRoutine>d__24 <InvokeDelayedRoutine>d__ = this;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				PlayfabLeaderboardsManager.<InvokeDelayedRoutine>d__24 <InvokeDelayedRoutine>d__2;
				<InvokeDelayedRoutine>d__ = <InvokeDelayedRoutine>d__2;
			}
			bool result;
			if (this.<>1__state != 0)
			{
				result = (<InvokeDelayedRoutine>d__ != null);
			}
			else
			{
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				Console.WriteLine("Method not found @24D67D8");
				WaitForSeconds waitForSeconds;
				float seconds;
				waitForSeconds..ctor(seconds);
				this.<>2__current = waitForSeconds;
				Console.WriteLine("Method not found @24D64EC");
				this.<>1__state = (int)1L;
				bool flag2;
				result = flag2;
			}
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			return result;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00043458 File Offset: 0x00041658
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0004346C File Offset: 0x0004166C
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000365)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void PlayfabLeaderboardsManager/<InvokeDelayedRoutine>d__24::System.Collections.IEnumerator.Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67D8")); 	call:void(Console::WriteLine, ldstr:string("Unmanaged memory load: [523B230]")); 	call:void(NotSupportedException::.ctor, conv.i:native int[exp:NotSupportedException](ldc.i4:int32[exp:native int](0))); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D66AC")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000434D0 File Offset: 0x000416D0
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000403 RID: 1027
		private int <>1__state;

		// Token: 0x04000404 RID: 1028
		private object <>2__current;

		// Token: 0x04000405 RID: 1029
		public float delay;

		// Token: 0x04000406 RID: 1030
		public Action action;
	}
}
