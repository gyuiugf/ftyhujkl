using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200002A RID: 42
public class LevelManager : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600010B RID: 267 RVA: 0x00016540 File Offset: 0x00014740
	// (set) Token: 0x0600010C RID: 268 RVA: 0x00016558 File Offset: 0x00014758
	public List<Level> Levels
	{
		get
		{
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			return this;
		}
		set
		{
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			Console.WriteLine("Method not found @24D64EC");
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600010D RID: 269 RVA: 0x0001658C File Offset: 0x0001478C
	// (set) Token: 0x0600010E RID: 270 RVA: 0x000165A4 File Offset: 0x000147A4
	public int CurrentIndex
	{
		get
		{
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			return this;
		}
		set
		{
			int num;
			if (!(~this.extreme))
			{
				this.currentIndexExtreme = num;
				return;
			}
			this.currentIndex = num;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600010F RID: 271 RVA: 0x000165E0 File Offset: 0x000147E0
	// (set) Token: 0x06000110 RID: 272 RVA: 0x000165F8 File Offset: 0x000147F8
	public int Progress
	{
		get
		{
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			return this;
		}
		set
		{
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00016618 File Offset: 0x00014818
	public void SkipLevel()
	{
		if (this != 0)
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
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			if (this != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				int index;
				object obj = base.get_Item(index);
				if (obj != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v46 @ X0_v16 (System.Object)+20]");
					int @int = PlayerPrefs.GetInt((IntPtr)0);
					object obj2;
					bool flag = obj2 == 0;
					if (flag)
					{
						Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
						if (this == 0)
						{
							goto IL_1B3;
						}
						Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
						int num;
						object obj3 = base.get_Item(num);
						if (obj3 == 0)
						{
							goto IL_1B3;
						}
						Console.WriteLine("Unmanaged memory load: [v71 @ X0_v20 (System.Object)+20]");
						PlayerPrefs.SetInt((IntPtr)0, num);
					}
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					if (this != 0)
					{
						break;
					}
				}
			}
			IL_1B3:
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00016808 File Offset: 0x00014A08
	public void OpenSpeedrunPopup()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.levels != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				if (this.speedrunPanel != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		bool active;
		this.speedrunPanel.SetActive(active);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x000168E0 File Offset: 0x00014AE0
	public void SetLevelsPanel()
	{
		object obj;
		bool flag = obj - 112L != null;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		GameObject gameObject5;
		for (;;)
		{
			if (this.levelButtons != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
				bool active;
				GameObject gameObject2;
				if (this.pageNum != 0)
				{
					if (this.prevPageButton == 0)
					{
						goto IL_277;
					}
					GameObject gameObject = this.prevPageButton.gameObject;
					if (gameObject == 0)
					{
						goto IL_277;
					}
					active = flag;
					gameObject2 = gameObject;
				}
				else
				{
					if (this.prevPageButton == 0)
					{
						goto IL_277;
					}
					GameObject gameObject3 = this.prevPageButton.gameObject;
					if (gameObject3 == 0)
					{
						goto IL_277;
					}
					active = flag;
					gameObject2 = gameObject3;
				}
				gameObject2.SetActive(active);
				if (this.levelButtons != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					if (this != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction MADD not yet implemented.");
						if (this.nextPageButton != 0)
						{
							GameObject gameObject4 = this.nextPageButton.gameObject;
							if (gameObject4 != 0)
							{
								gameObject4.SetActive(flag);
								Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
								if (this != 0)
								{
									Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
									if (this.skipButton != 0)
									{
										gameObject5 = this.skipButton.gameObject;
										if (gameObject5 != 0)
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
			IL_277:
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @24D67F0");
		}
		gameObject5.SetActive(flag);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00016C18 File Offset: 0x00014E18
	public void SwitchMode()
	{
		/*
An exception occurred when decompiling this method (06000114)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::SwitchMode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_74:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x06000115 RID: 277 RVA: 0x00016CA8 File Offset: 0x00014EA8
	public void ChangePage(int dir)
	{
		object obj;
		int num = this.pageNum + obj;
		this.pageNum = num;
		this.SetLevelsPanel();
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00016CD4 File Offset: 0x00014ED4
	public void PlayEndless()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		GameObject gameObject;
		for (;;)
		{
			GameManager gameManager = this.gameManager;
			if (this.gameManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B190]");
				object obj = (IntPtr)0;
				gameManager.endless = (1L != 0L);
				bool speedrun;
				gameManager.speedrun = speedrun;
				this.LoadLevel(this.endlessLevel);
				Console.WriteLine("Unmanaged memory load: [v49 @ X8_v3+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					obj2.OpenGamePanel();
					if (this.levelsButton != 0)
					{
						gameObject = this.levelsButton.gameObject;
						if (gameObject != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		bool active;
		gameObject.SetActive(active);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00016E34 File Offset: 0x00015034
	public void PlaySpeedrun()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj5;
		for (;;)
		{
			bool endless;
			this.extreme = endless;
			if (this.speedrunPanel != 0)
			{
				bool flag;
				this.speedrunPanel.SetActive(flag);
				GameManager gameManager = this.gameManager;
				if (this.gameManager != 0 && gameManager.SpeedrunCompletedPanel != 0)
				{
					gameManager.SpeedrunCompletedPanel.SetActive(flag);
					GameManager gameManager2 = this.gameManager;
					if (this.gameManager != 0)
					{
						gameManager2.endless = endless;
						gameManager2.speedrun = (1L != 0L);
						if (!(~this.extreme))
						{
							this.currentIndexExtreme = (endless ? 1 : 0);
						}
						else
						{
							this.currentIndex = (endless ? 1 : 0);
						}
						Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
						if (this != 0)
						{
							Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
							object level = base.get_Item(flag ? 1 : 0);
							this.LoadLevel(level);
							if (this.gameManager != 0)
							{
								Console.WriteLine("Unmanaged memory load: [523B190]");
								object obj = (IntPtr)0;
								this.gameManager.StartSpeedrun();
								Console.WriteLine("Unmanaged memory load: [v129 @ X8_v3+B8]");
								object obj2 = (IntPtr)0;
								if (obj2 != 0)
								{
									obj2.OpenGamePanel();
									Console.WriteLine("Unmanaged memory load: [v134 @ X8_v5+B8]");
									object obj3 = (IntPtr)0;
									if (obj3 != 0)
									{
										Console.WriteLine("Unmanaged memory load: [523AED0]");
										object obj4 = (IntPtr)0;
										Console.WriteLine("Unmanaged memory load: [v64 @ X0_v16+20]");
										IntPtr intPtr = (IntPtr)0;
										Console.WriteLine("Method not found @24D64EC");
										Console.WriteLine("Unmanaged memory load: [v140 @ X8_v7+B8]");
										obj5 = (IntPtr)0;
										if (obj5 != 0)
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
		obj5.LogSpeedrunPlayed();
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0001712C File Offset: 0x0001532C
	public void LoadCurrentLevel()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		for (;;)
		{
			GameManager gameManager = this.gameManager;
			if (this.gameManager != 0)
			{
				bool flag;
				gameManager.endless = flag;
				gameManager.speedrun = flag;
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				if (this != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [523B190]");
					object obj = (IntPtr)0;
					int index;
					object level = base.get_Item(index);
					this.LoadLevel(level);
					Console.WriteLine("Unmanaged memory load: [v94 @ X8_v5+B8]");
					obj2 = (IntPtr)0;
					if (obj2 != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj2.OpenGamePanel();
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00017280 File Offset: 0x00015480
	public void OnLevelPanelClosed()
	{
		this.extreme = this.playingExtreme;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0001729C File Offset: 0x0001549C
	public void LoadLevel(Level level)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (level != 0)
			{
				GameObject gameObject = level.gameObject;
				if (gameObject != 0)
				{
					bool flag;
					gameObject.SetActive(flag);
					if (this.gameManager != 0)
					{
						this.gameManager.LoadLevel(level);
						GameManager gameManager = this.gameManager;
						if (this.gameManager != 0)
						{
							if (!(~gameManager.speedrun))
							{
								if (this.levelsButton == 0)
								{
									goto IL_3EB;
								}
								GameObject gameObject2 = this.levelsButton.gameObject;
								if (gameObject2 == 0)
								{
									goto IL_3EB;
								}
								gameObject2.SetActive(flag);
								if (this.speedrunProgressText == 0)
								{
									goto IL_3EB;
								}
								GameObject gameObject3 = this.speedrunProgressText.gameObject;
								if (gameObject3 == 0)
								{
									goto IL_3EB;
								}
								gameObject3.SetActive(flag);
								int num = (int)((flag ? 1L : 0L) + 12L);
								Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
								string str = num.ToString();
								Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
								if (this == 0)
								{
									goto IL_3EB;
								}
								Console.WriteLine("Unmanaged memory load: [523B290]");
								object str2 = (IntPtr)0;
								int num2 = (int)((flag ? 1L : 0L) + 12L);
								Console.WriteLine("Unmanaged memory load: [v51 @ X8_v3+18]");
								IntPtr intPtr = (IntPtr)0;
								string str3 = num2.ToString();
								string text = str + str2 + str3;
								if (this.speedrunProgressText == 0)
								{
									goto IL_3EB;
								}
								Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
							}
							else
							{
								if (this.levelsButton == 0)
								{
									goto IL_3EB;
								}
								GameObject gameObject4 = this.levelsButton.gameObject;
								if (gameObject4 == 0)
								{
									goto IL_3EB;
								}
								gameObject4.SetActive(flag);
								if (this.speedrunProgressText == 0)
								{
									goto IL_3EB;
								}
								GameObject gameObject5 = this.speedrunProgressText.gameObject;
								if (gameObject5 == 0)
								{
									goto IL_3EB;
								}
								gameObject5.SetActive(flag);
							}
							int num3 = (int)((flag ? 1L : 0L) + 12L);
							Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
							Console.WriteLine("Unmanaged memory load: [523B438]");
							object str4 = (IntPtr)0;
							object obj = this + 1L;
							string str5 = num3.ToString();
							string text2 = str4 + str5;
							if (this.levelText != 0)
							{
								break;
							}
						}
					}
				}
			}
			IL_3EB:
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000176C0 File Offset: 0x000158C0
	public void SetProgress()
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
		}
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000177A8 File Offset: 0x000159A8
	public void LoadNextLevel()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj8;
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			if (this != 0)
			{
				object obj = this + 372L;
				object obj2 = this + 40L;
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				int index;
				object obj3 = base.get_Item(index);
				if (obj3 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v46 @ X0_v16 (System.Object)+20]");
					int @int = PlayerPrefs.GetInt((IntPtr)0);
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					object obj4 = this + 1L;
					if (!(~this.extreme))
					{
					}
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					if (this != 0)
					{
						if (!(~this.extreme))
						{
						}
						GameManager gameManager = this.gameManager;
						if (this.gameManager != 0)
						{
							if (!(~gameManager.speedrun))
							{
								this.gameManager.OnSpeedrunFinished();
							}
							else
							{
								Console.WriteLine("Unmanaged memory load: [523B190]");
								object obj5 = (IntPtr)0;
								Console.WriteLine("Unmanaged memory load: [v183 @ X8_v4+B8]");
								object obj6 = (IntPtr)0;
								if (obj6 == 0)
								{
									goto IL_366;
								}
								obj6.OpenComingSoonPanel();
								if (this.extremeComingSoon == 0)
								{
									goto IL_366;
								}
								bool active;
								this.extremeComingSoon.SetActive(active);
								if (this.normalComingSoon == 0)
								{
									goto IL_366;
								}
								Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
								this.normalComingSoon.SetActive(active);
							}
							Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
							if (this != 0)
							{
								Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
								GameManager gameManager2 = this.gameManager;
								if (this.gameManager != 0)
								{
									if (!(~gameManager2.speedrun))
									{
										break;
									}
									Console.WriteLine("Unmanaged memory load: [523B190]");
									object obj7 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [v219 @ X8_v10+B8]");
									obj8 = (IntPtr)0;
									if (obj8 != 0)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
			}
			IL_366:
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_13:
		obj8.OpenReviewPanel();
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00017B78 File Offset: 0x00015D78
	private void OnEnable()
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
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj;
		Button button16;
		for (;;)
		{
			Button button = this.endlessButton;
			if (this.endlessButton != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B128]");
				obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B440]");
				object method = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor(this, method);
				if (button.m_OnClick != 0)
				{
					button.m_OnClick.AddListener(obj);
					Button button2 = this.endlessButton2;
					if (this.endlessButton2 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523B478]");
						object method2 = (IntPtr)0;
						Console.WriteLine("Method not found @24D67D8");
						obj..ctor(this, method2);
						if (button2.m_OnClick != 0)
						{
							button2.m_OnClick.AddListener(obj);
							Button button3 = this.soonExtremeButton;
							if (this.soonExtremeButton != 0)
							{
								Console.WriteLine("Unmanaged memory load: [523B480]");
								object method3 = (IntPtr)0;
								Console.WriteLine("Method not found @24D67D8");
								obj..ctor(this, method3);
								if (button3.m_OnClick != 0)
								{
									button3.m_OnClick.AddListener(obj);
									Button button4 = this.playSpeedrunButton;
									if (this.playSpeedrunButton != 0)
									{
										Console.WriteLine("Unmanaged memory load: [523B488]");
										object method4 = (IntPtr)0;
										Console.WriteLine("Method not found @24D67D8");
										obj..ctor(this, method4);
										if (button4.m_OnClick != 0)
										{
											button4.m_OnClick.AddListener(obj);
											Button button5 = this.speedrunAgainButton;
											if (this.speedrunAgainButton != 0)
											{
												Console.WriteLine("Unmanaged memory load: [523B490]");
												object method5 = (IntPtr)0;
												Console.WriteLine("Method not found @24D67D8");
												obj..ctor(this, method5);
												if (button5.m_OnClick != 0)
												{
													button5.m_OnClick.AddListener(obj);
													Button button6 = this.closeSpeedrunPanelButton;
													if (this.closeSpeedrunPanelButton != 0)
													{
														Console.WriteLine("Unmanaged memory load: [523B498]");
														object method6 = (IntPtr)0;
														Console.WriteLine("Method not found @24D67D8");
														obj..ctor(this, method6);
														if (button6.m_OnClick != 0)
														{
															button6.m_OnClick.AddListener(obj);
															Button button7 = this.closeUnlockSpeedrunPanelButton;
															if (this.closeUnlockSpeedrunPanelButton != 0)
															{
																Console.WriteLine("Unmanaged memory load: [523B4A0]");
																object method7 = (IntPtr)0;
																Console.WriteLine("Method not found @24D67D8");
																obj..ctor(this, method7);
																if (button7.m_OnClick != 0)
																{
																	button7.m_OnClick.AddListener(obj);
																	Button button8 = this.speedrunButton;
																	if (this.speedrunButton != 0)
																	{
																		Console.WriteLine("Unmanaged memory load: [523B4A8]");
																		object method8 = (IntPtr)0;
																		Console.WriteLine("Method not found @24D67D8");
																		obj..ctor(this, method8);
																		if (button8.m_OnClick != 0)
																		{
																			button8.m_OnClick.AddListener(obj);
																			Button button9 = this.speedrunButton2;
																			if (this.speedrunButton2 != 0)
																			{
																				Console.WriteLine("Unmanaged memory load: [523B4B0]");
																				object method9 = (IntPtr)0;
																				Console.WriteLine("Method not found @24D67D8");
																				obj..ctor(this, method9);
																				if (button9.m_OnClick != 0)
																				{
																					button9.m_OnClick.AddListener(obj);
																					Button button10 = this.playButton;
																					if (this.playButton != 0)
																					{
																						Console.WriteLine("Unmanaged memory load: [523B4B8]");
																						object method10 = (IntPtr)0;
																						Console.WriteLine("Method not found @24D67D8");
																						obj..ctor(this, method10);
																						if (button10.m_OnClick != 0)
																						{
																							button10.m_OnClick.AddListener(obj);
																							Button button11 = this.levelsButton;
																							if (this.levelsButton != 0)
																							{
																								Console.WriteLine("Unmanaged memory load: [523B448]");
																								object method11 = (IntPtr)0;
																								Console.WriteLine("Method not found @24D67D8");
																								obj..ctor(this, method11);
																								if (button11.m_OnClick != 0)
																								{
																									button11.m_OnClick.AddListener(obj);
																									Button button12 = this.prevPageButton;
																									if (this.prevPageButton != 0)
																									{
																										Console.WriteLine("Unmanaged memory load: [523B450]");
																										object method12 = (IntPtr)0;
																										Console.WriteLine("Method not found @24D67D8");
																										obj..ctor(this, method12);
																										if (button12.m_OnClick != 0)
																										{
																											button12.m_OnClick.AddListener(obj);
																											Button button13 = this.nextPageButton;
																											if (this.nextPageButton != 0)
																											{
																												Console.WriteLine("Unmanaged memory load: [523B458]");
																												object method13 = (IntPtr)0;
																												Console.WriteLine("Method not found @24D67D8");
																												obj..ctor(this, method13);
																												if (button13.m_OnClick != 0)
																												{
																													button13.m_OnClick.AddListener(obj);
																													Button button14 = this.speedrunHomeButton;
																													if (this.speedrunHomeButton != 0)
																													{
																														Console.WriteLine("Unmanaged memory load: [523B460]");
																														object method14 = (IntPtr)0;
																														Console.WriteLine("Method not found @24D67D8");
																														obj..ctor(this, method14);
																														if (button14.m_OnClick != 0)
																														{
																															button14.m_OnClick.AddListener(obj);
																															Button button15 = this.skipButton;
																															if (this.skipButton != 0)
																															{
																																Console.WriteLine("Unmanaged memory load: [523B468]");
																																object method15 = (IntPtr)0;
																																Console.WriteLine("Method not found @24D67D8");
																																obj..ctor(this, method15);
																																if (button15.m_OnClick != 0)
																																{
																																	button15.m_OnClick.AddListener(obj);
																																	button16 = this.modeButton;
																																	if (this.modeButton != 0)
																																	{
																																		Console.WriteLine("Unmanaged memory load: [523B470]");
																																		object method16 = (IntPtr)0;
																																		Console.WriteLine("Method not found @24D67D8");
																																		obj..ctor(this, method16);
																																		if (button16.m_OnClick != 0)
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
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
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
		button16.m_OnClick.AddListener(obj);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00018560 File Offset: 0x00016760
	private void OnDisable()
	{
		/*
An exception occurred when decompiling this method (0600011E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::OnDisable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_59B:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00018B14 File Offset: 0x00016D14
	private void Start()
	{
		/*
An exception occurred when decompiling this method (0600011F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::Start()

 ---> System.Exception: Inconsistent stack size at IL_26D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000400D File Offset: 0x0000220D
	private void Update()
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00018DF8 File Offset: 0x00016FF8
	private void <SkipLevel>b__57_0()
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
		}
		object obj6;
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			int num = this + 1L;
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			if (this != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction SDIV not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [523B220]");
				object str = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B1F8]");
				object str2 = (IntPtr)0;
				Console.WriteLine("Not implemented instruction: Instruction MSUB not yet implemented.");
				if (!(~this.extreme))
				{
					this.currentIndexExtreme = num;
				}
				else
				{
					this.currentIndex = num;
				}
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				object obj;
				string key = str + obj;
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				PlayerPrefs.SetInt(key, obj);
				string key2 = str2 + obj;
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				PlayerPrefs.SetInt(key2, obj);
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				if (this != 0)
				{
					if (!(~this.extreme))
					{
						int num2;
						this.currentIndexExtreme = num2;
					}
					else
					{
						int num2;
						this.currentIndex = num2;
					}
					Console.WriteLine("Unmanaged memory load: [523B190]");
					object obj2 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v221 @ X8_v2+B8]");
					object obj3 = (IntPtr)0;
					if (obj3 != 0)
					{
						obj3.OpenGamePanel();
						Console.WriteLine("Unmanaged memory load: [v226 @ X8_v4+B8]");
						object obj4 = (IntPtr)0;
						if (obj4 != 0)
						{
							obj4.OpenComingSoonPanel();
							if (this.extremeComingSoon != 0)
							{
								bool flag;
								this.extremeComingSoon.SetActive(flag);
								if (this.normalComingSoon != 0)
								{
									Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
									this.normalComingSoon.SetActive(flag);
									Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
									if (this != 0)
									{
										Console.WriteLine("Unmanaged memory load: [523AED0]");
										object obj5 = (IntPtr)0;
										Console.WriteLine("Unmanaged memory load: [v250 @ X8_v8+B8]");
										obj6 = (IntPtr)0;
										object obj7 = base.get_Item(flag ? 1 : 0);
										if (obj7 != 0 && obj6 != 0)
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
		FirebaseEventManager firebaseEventManager = obj6;
		Console.WriteLine("Unmanaged memory load: [v112 @ X0_v29 (System.Object)+20]");
		firebaseEventManager.LogLevelSkipped((IntPtr)0);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000191E0 File Offset: 0x000173E0
	private void <OnEnable>b__69_0()
	{
		/*
An exception occurred when decompiling this method (06000123)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_40:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x06000124 RID: 292 RVA: 0x00019238 File Offset: 0x00017438
	private void <OnEnable>b__69_1()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B190]");
				object obj = (IntPtr)0;
				this.soundManager.PlayClickSound();
				this.PlayEndless();
				Console.WriteLine("Unmanaged memory load: [v50 @ X8_v2+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [v32 @ X0_v7+20]");
		IntPtr intPtr = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00019338 File Offset: 0x00017538
	private void <OnEnable>b__69_2()
	{
		/*
An exception occurred when decompiling this method (06000125)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_4A:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x06000126 RID: 294 RVA: 0x00019398 File Offset: 0x00017598
	private void <OnEnable>b__69_3()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		object obj3;
		for (;;)
		{
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AD58]");
				object key = (IntPtr)0;
				this.soundManager.PlayClickSound();
				int @int = PlayerPrefs.GetInt(key);
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v91 @ X8_v4+B8]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AD60]");
				obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				Console.WriteLine("Unmanaged memory load: [523B4E8]");
				object method = (IntPtr)0;
				obj3..ctor(this, method);
				if (obj2 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523B4F0]");
		object placementName = (IntPtr)0;
		obj2.ShowRewardedAd(obj3, placementName);
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0001952C File Offset: 0x0001772C
	private void <OnEnable>b__69_16()
	{
		this.PlaySpeedrun();
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00019540 File Offset: 0x00017740
	private void <OnEnable>b__69_4()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		object obj3;
		for (;;)
		{
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AD58]");
				object key = (IntPtr)0;
				this.soundManager.PlayClickSound();
				int @int = PlayerPrefs.GetInt(key);
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v91 @ X8_v4+B8]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AD60]");
				obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				Console.WriteLine("Unmanaged memory load: [523B4F8]");
				object method = (IntPtr)0;
				obj3..ctor(this, method);
				if (obj2 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523B4F0]");
		object placementName = (IntPtr)0;
		obj2.ShowRewardedAd(obj3, placementName);
	}

	// Token: 0x06000129 RID: 297 RVA: 0x000196D4 File Offset: 0x000178D4
	private void <OnEnable>b__69_17()
	{
		this.PlaySpeedrun();
	}

	// Token: 0x0600012A RID: 298 RVA: 0x000196E8 File Offset: 0x000178E8
	private void <OnEnable>b__69_5()
	{
		/*
An exception occurred when decompiling this method (0600012A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_5()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_63:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00019764 File Offset: 0x00017964
	private void <OnEnable>b__69_6()
	{
		/*
An exception occurred when decompiling this method (0600012B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_6()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_63:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x000197E0 File Offset: 0x000179E0
	private void <OnEnable>b__69_7()
	{
		/*
An exception occurred when decompiling this method (0600012C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_7()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_40:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x0600012D RID: 301 RVA: 0x00019838 File Offset: 0x00017A38
	private void <OnEnable>b__69_8()
	{
		/*
An exception occurred when decompiling this method (0600012D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_8()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_40:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x0600012E RID: 302 RVA: 0x00019890 File Offset: 0x00017A90
	private void <OnEnable>b__69_9()
	{
		/*
An exception occurred when decompiling this method (0600012E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_9()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_40:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x0600012F RID: 303 RVA: 0x000198E8 File Offset: 0x00017AE8
	private void <OnEnable>b__69_10()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B190]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj3;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			this.playingExtreme = this.extreme;
			if (obj2 != 0)
			{
				obj2.CloseGamePanel();
				if (this.soundManager != 0)
				{
					this.soundManager.PlayClickSound();
					Button[] array = this.levelButtons;
					if (this.levelButtons != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
						Console.WriteLine("Not implemented instruction: Instruction SDIV not yet implemented.");
						Console.WriteLine("Unmanaged memory load: [v40 @ X8_v4 (UnityEngine.UI.Button[])+18]");
						this.pageNum = (int)((IntPtr)0);
						this.SetLevelsPanel();
						Console.WriteLine("Unmanaged memory load: [v87 @ X8_v5+B8]");
						obj3 = (IntPtr)0;
						if (obj3 != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj3.OpenLevelSelectPanel();
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00019A6C File Offset: 0x00017C6C
	private void <OnEnable>b__69_11()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		for (;;)
		{
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				this.soundManager.PlayClickSound();
				int num = (int)((long)this.pageNum - 1L);
				this.pageNum = num;
				this.SetLevelsPanel();
				Console.WriteLine("Unmanaged memory load: [v58 @ X8_v2+B8]");
				obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Action postAdAction_;
		bool waitForTime;
		obj2.ShowInterstitial(postAdAction_, waitForTime);
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00019B7C File Offset: 0x00017D7C
	private void <OnEnable>b__69_12()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		for (;;)
		{
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				this.soundManager.PlayClickSound();
				int num = (int)((long)this.pageNum + 1L);
				this.pageNum = num;
				this.SetLevelsPanel();
				Console.WriteLine("Unmanaged memory load: [v58 @ X8_v2+B8]");
				obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Action postAdAction_;
		bool waitForTime;
		obj2.ShowInterstitial(postAdAction_, waitForTime);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00019C8C File Offset: 0x00017E8C
	private void <OnEnable>b__69_13()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		for (;;)
		{
			if (this.soundManager != 0)
			{
				this.soundManager.PlayClickSound();
				GameManager gameManager = this.gameManager;
				if (this.gameManager != 0 && gameManager.SpeedrunCompletedPanel != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523B190]");
					object obj = (IntPtr)0;
					bool active;
					gameManager.SpeedrunCompletedPanel.SetActive(active);
					Console.WriteLine("Unmanaged memory load: [v65 @ X8_v3+B8]");
					obj2 = (IntPtr)0;
					if (obj2 != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj2.OpenStartPanel();
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00019DC8 File Offset: 0x00017FC8
	private void <OnEnable>b__69_14()
	{
		/*
An exception occurred when decompiling this method (06000133)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_14()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_40:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x06000134 RID: 308 RVA: 0x00019E20 File Offset: 0x00018020
	private void <OnEnable>b__69_15()
	{
		/*
An exception occurred when decompiling this method (06000134)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void LevelManager::<OnEnable>b__69_15()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_40:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x0400011D RID: 285
	public List<Level> levels;

	// Token: 0x0400011E RID: 286
	public int currentIndex;

	// Token: 0x0400011F RID: 287
	public Level endlessLevel;

	// Token: 0x04000120 RID: 288
	public GameManager gameManager;

	// Token: 0x04000121 RID: 289
	public Button endlessButton;

	// Token: 0x04000122 RID: 290
	public Button endlessButton2;

	// Token: 0x04000123 RID: 291
	public Button[] levelButtons;

	// Token: 0x04000124 RID: 292
	public Image[] levelButtonsImages;

	// Token: 0x04000125 RID: 293
	public Text[] levelButtonsTexts;

	// Token: 0x04000126 RID: 294
	public GameObject[] locks;

	// Token: 0x04000127 RID: 295
	public GameObject[] skips;

	// Token: 0x04000128 RID: 296
	public Image[] extremeIcons;

	// Token: 0x04000129 RID: 297
	public int progress;

	// Token: 0x0400012A RID: 298
	public Button playButton;

	// Token: 0x0400012B RID: 299
	public Text levelText;

	// Token: 0x0400012C RID: 300
	public Button levelsButton;

	// Token: 0x0400012D RID: 301
	public int pageNum;

	// Token: 0x0400012E RID: 302
	public Button prevPageButton;

	// Token: 0x0400012F RID: 303
	public Button nextPageButton;

	// Token: 0x04000130 RID: 304
	public Color solvedColor;

	// Token: 0x04000131 RID: 305
	public Color currentColor;

	// Token: 0x04000132 RID: 306
	public Color lockedColor;

	// Token: 0x04000133 RID: 307
	public Color skippedColor;

	// Token: 0x04000134 RID: 308
	public Button speedrunButton;

	// Token: 0x04000135 RID: 309
	public Button speedrunButton2;

	// Token: 0x04000136 RID: 310
	public GameObject tutorialText;

	// Token: 0x04000137 RID: 311
	public GameObject speedrunPanel;

	// Token: 0x04000138 RID: 312
	public GameObject unlockSpeedrunPanel;

	// Token: 0x04000139 RID: 313
	public Text levelProgressSpeedrunText;

	// Token: 0x0400013A RID: 314
	public Button playSpeedrunButton;

	// Token: 0x0400013B RID: 315
	public Button closeSpeedrunPanelButton;

	// Token: 0x0400013C RID: 316
	public Button closeUnlockSpeedrunPanelButton;

	// Token: 0x0400013D RID: 317
	public Text speedrunProgressText;

	// Token: 0x0400013E RID: 318
	public Button speedrunHomeButton;

	// Token: 0x0400013F RID: 319
	public Button speedrunAgainButton;

	// Token: 0x04000140 RID: 320
	public Button skipButton;

	// Token: 0x04000141 RID: 321
	public SoundManager soundManager;

	// Token: 0x04000142 RID: 322
	public List<Level> extremeLevels;

	// Token: 0x04000143 RID: 323
	private bool extreme;

	// Token: 0x04000144 RID: 324
	public int currentIndexExtreme;

	// Token: 0x04000145 RID: 325
	public int progressExtreme;

	// Token: 0x04000146 RID: 326
	public Button modeButton;

	// Token: 0x04000147 RID: 327
	public Sprite extremePurpleSprite;

	// Token: 0x04000148 RID: 328
	public Sprite extremeWhiteSprite;

	// Token: 0x04000149 RID: 329
	private bool playingExtreme;

	// Token: 0x0400014A RID: 330
	public Button soonExtremeButton;

	// Token: 0x0400014B RID: 331
	public GameObject normalComingSoon;

	// Token: 0x0400014C RID: 332
	public GameObject extremeComingSoon;

	// Token: 0x02000082 RID: 130
	private sealed class <>c__DisplayClass59_0
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00042C88 File Offset: 0x00040E88
		internal void <SetLevelsPanel>b__0()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			for (;;)
			{
				LevelManager levelManager = this.<>4__this;
				if (this.<>4__this != 0 && levelManager.soundManager != 0)
				{
					levelManager.soundManager.PlayClickSound();
					LevelManager levelManager2 = this.<>4__this;
					if (this.<>4__this != 0)
					{
						GameManager gameManager = levelManager2.gameManager;
						if (levelManager2.gameManager != 0)
						{
							bool flag;
							gameManager.endless = flag;
							gameManager.speedrun = flag;
							if (!(~levelManager2.extreme))
							{
								levelManager2.currentIndexExtreme = this.ind;
							}
							else
							{
								levelManager2.currentIndex = this.ind;
							}
							Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
							if (levelManager2 != 0)
							{
								Console.WriteLine("Unmanaged memory load: [523B190]");
								object obj = (IntPtr)0;
								int index;
								object level = levelManager2.get_Item(index);
								this.<>4__this.LoadLevel(level);
								Console.WriteLine("Unmanaged memory load: [v97 @ X8_v6+B8]");
								obj2 = (IntPtr)0;
								if (obj2 != 0)
								{
									break;
								}
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			obj2.OpenGamePanel();
		}

		// Token: 0x040003F5 RID: 1013
		public int ind;

		// Token: 0x040003F6 RID: 1014
		public LevelManager <>4__this;
	}
}
