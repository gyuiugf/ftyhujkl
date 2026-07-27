using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200004D RID: 77
public class UIManager : MonoBehaviour
{
	// Token: 0x060001F2 RID: 498 RVA: 0x000238BC File Offset: 0x00021ABC
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B190]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00004071 File Offset: 0x00002271
	public void OpenStartPanel()
	{
		/*
An exception occurred when decompiling this method (060001F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::OpenStartPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Invalid instruction: 2 Invalid \"Jump target not found in method: 0x25DF504\"")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00023954 File Offset: 0x00021B54
	public void OpenGamePanel()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE38]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			this.OpenPanel(this.gamePanel);
			Console.WriteLine("Unmanaged memory load: [v27 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00023A1C File Offset: 0x00021C1C
	public void CloseGamePanel()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.gameScene != 0)
			{
				bool active;
				this.gameScene.SetActive(active);
				if (this.gamePanel != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523AE38]");
					object obj = (IntPtr)0;
					this.gamePanel.SetActive(active);
					Console.WriteLine("Unmanaged memory load: [v60 @ X8_v2+B8]");
					object obj2 = (IntPtr)0;
					if (obj2 != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00023B28 File Offset: 0x00021D28
	public void OpenLevelSelectPanel()
	{
		this.OpenPanel(this.levelSelectPanel);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00023B44 File Offset: 0x00021D44
	public void OpenComingSoonPanel()
	{
		this.OpenPanel(this.comingSoonPanel);
		this.CloseGamePanel();
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00023B74 File Offset: 0x00021D74
	public void OpenPrevPanel()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ADE0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v24 @ X0_v6+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj2;
			bool flag3 = obj2 == 0;
			bool flag4 = this.prevPanel == this.gamePanel;
			if (!flag3)
			{
				break;
			}
			Console.WriteLine("Unmanaged memory load: [523AE38]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v48 @ X8_v4+B8]");
			object obj4 = (IntPtr)0;
			if (obj4 != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		this.OpenPanel(this.prevPanel);
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00023CE4 File Offset: 0x00021EE4
	public void OpenPanel(GameObject panel)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		SoundManager soundManager;
		for (;;)
		{
			object obj = this + 64L;
			if (obj != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj2 = (IntPtr)0;
				obj.SetActive(panel != null);
				Console.WriteLine("Unmanaged memory load: [v76 @ X0_v6+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				object obj3;
				bool flag2 = obj3 == 0;
				bool flag3 = this.currentPanel == this.gamePanel;
				if (flag2)
				{
					if (this.gameScene == 0)
					{
						goto IL_253;
					}
					this.gameScene.SetActive(this.gamePanel != null);
				}
				if (panel != 0)
				{
					panel.SetActive(this.gamePanel != null);
					Console.WriteLine("Unmanaged memory load: [v133 @ X0_v12+E4]");
					bool flag4 = (IntPtr)0 == 0;
					if (flag4)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					bool flag5 = obj3 == 0;
					bool flag6 = panel == this.gamePanel;
					if (!flag5)
					{
						goto IL_289;
					}
					if (this.gameScene != 0)
					{
						this.gameScene.SetActive(this.gamePanel != null);
						soundManager = this.soundManager;
						if (this.soundManager != 0)
						{
							break;
						}
					}
				}
			}
			IL_253:
			Console.WriteLine("Method not found @24D67E8");
		}
		soundManager.soundCooldown = 0.5f;
		IL_289:
		this.prevPanel = this.currentPanel;
		Console.WriteLine("Method not found @24D64EC");
		this.currentPanel = panel;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00023FA4 File Offset: 0x000221A4
	public void OpenFirstScreen()
	{
		/*
An exception occurred when decompiling this method (060001FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::OpenFirstScreen()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_51:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x060001FB RID: 507 RVA: 0x0002400C File Offset: 0x0002220C
	private void OnEnable()
	{
		bool flag = this == 0;
		UIManager uimanager = this;
		Console.WriteLine("Unmanaged memory load: [5592161]");
		object obj = (IntPtr)0;
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
			Console.WriteLine("Unmanaged memory load: [523B128]");
			uimanager = (IntPtr)0;
			obj = 1L;
		}
		for (;;)
		{
			Button button = this.backToStartButton;
			bool flag2 = this.backToStartButton == 0;
			object obj3;
			object obj2 = obj3;
			object obj5;
			object obj4 = obj5;
			object obj7;
			object obj6 = obj7;
			object obj9;
			object obj8 = obj9;
			object obj11;
			object obj10 = obj11;
			object obj13;
			object obj12 = obj13;
			object obj15;
			object obj14 = obj15;
			object obj17;
			object obj16 = obj17;
			IntPtr intPtr2;
			IntPtr intPtr = intPtr2;
			object obj19;
			object obj18 = obj19;
			IntPtr intPtr4;
			IntPtr intPtr3 = intPtr4;
			UnityAction unityAction2;
			UnityAction unityAction = unityAction2;
			object obj21;
			object obj20 = obj21;
			UnityAction unityAction3 = uimanager;
			object obj22 = 1;
			object obj23 = obj;
			UnityEvent unityEvent = 50016256L;
			if (flag2)
			{
				goto IL_B8C;
			}
			Console.WriteLine("Unmanaged memory load: [523B128]");
			object obj24 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B820]");
			object obj25 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			obj24..ctor(this, obj25);
			bool flag3 = button.m_OnClick == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			IntPtr intPtr5;
			intPtr = intPtr5;
			obj18 = this;
			intPtr3 = obj25;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = obj24;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button.m_OnClick;
			if (flag3)
			{
				goto IL_B8C;
			}
			button.m_OnClick.AddListener(obj24);
			Button button2 = this.backToStartButton2;
			bool flag4 = this.backToStartButton2 == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = obj24;
			intPtr3 = intPtr5;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = button.m_OnClick;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button.m_OnClick;
			if (flag4)
			{
				goto IL_B8C;
			}
			Console.WriteLine("Unmanaged memory load: [523B848]");
			object obj26 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			obj24..ctor(this, obj26);
			bool flag5 = button2.m_OnClick == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = this;
			intPtr3 = obj26;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = obj24;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button2.m_OnClick;
			if (flag5)
			{
				goto IL_B8C;
			}
			button2.m_OnClick.AddListener(obj24);
			Button button3 = this.backToGameButton;
			bool flag6 = this.backToGameButton == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = obj24;
			intPtr3 = intPtr5;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = button2.m_OnClick;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button2.m_OnClick;
			if (flag6)
			{
				goto IL_B8C;
			}
			Console.WriteLine("Unmanaged memory load: [523B850]");
			object obj27 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			obj24..ctor(this, obj27);
			bool flag7 = button3.m_OnClick == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = this;
			intPtr3 = obj27;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = obj24;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button3.m_OnClick;
			if (flag7)
			{
				goto IL_B8C;
			}
			button3.m_OnClick.AddListener(obj24);
			Button button4 = this.closeNoAdsButton;
			bool flag8 = this.closeNoAdsButton == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = obj24;
			intPtr3 = intPtr5;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = button3.m_OnClick;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button3.m_OnClick;
			if (flag8)
			{
				goto IL_B8C;
			}
			Console.WriteLine("Unmanaged memory load: [523B858]");
			object obj28 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			obj24..ctor(this, obj28);
			bool flag9 = button4.m_OnClick == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = this;
			intPtr3 = obj28;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = obj24;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button4.m_OnClick;
			if (flag9)
			{
				goto IL_B8C;
			}
			button4.m_OnClick.AddListener(obj24);
			Button button5 = this.closePurchaseSuccessButton;
			bool flag10 = this.closePurchaseSuccessButton == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = obj24;
			intPtr3 = intPtr5;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = button4.m_OnClick;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button4.m_OnClick;
			if (flag10)
			{
				goto IL_B8C;
			}
			Console.WriteLine("Unmanaged memory load: [523B860]");
			object obj29 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			obj24..ctor(this, obj29);
			bool flag11 = button5.m_OnClick == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = this;
			intPtr3 = obj29;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = obj24;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button5.m_OnClick;
			if (flag11)
			{
				goto IL_B8C;
			}
			button5.m_OnClick.AddListener(obj24);
			Button button6 = this.closePurchaseFailButton;
			bool flag12 = this.closePurchaseFailButton == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = obj24;
			intPtr3 = intPtr5;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = button5.m_OnClick;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button5.m_OnClick;
			if (flag12)
			{
				goto IL_B8C;
			}
			Console.WriteLine("Unmanaged memory load: [523B868]");
			object obj30 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			obj24..ctor(this, obj30);
			bool flag13 = button6.m_OnClick == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = this;
			intPtr3 = obj30;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = obj24;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button6.m_OnClick;
			if (flag13)
			{
				goto IL_B8C;
			}
			button6.m_OnClick.AddListener(obj24);
			UnityAction unityAction4 = this.noAdsButtons;
			bool flag14 = this.noAdsButtons == 0;
			obj2 = obj3;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			intPtr = intPtr5;
			obj18 = obj24;
			intPtr3 = intPtr5;
			unityAction = obj24;
			obj20 = obj24;
			unityAction3 = this.noAdsButtons;
			obj22 = 1;
			obj23 = obj;
			unityEvent = button6.m_OnClick;
			if (flag14)
			{
				goto IL_B8C;
			}
			object obj32;
			object obj31 = obj32;
			Console.WriteLine("Unmanaged memory load: [v137 @ X0_v52 (UnityEngine.Events.UnityAction)+18]");
			object obj33 = obj31 - (IntPtr)0;
			object obj34 = obj3;
			object obj35 = obj32;
			Console.WriteLine("Unmanaged memory load: [523B888]");
			object obj36 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B880]");
			object obj37 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B878]");
			object obj38 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B870]");
			object obj39 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B840]");
			object obj40 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B398]");
			object obj41 = (IntPtr)0;
			IntPtr intPtr6 = intPtr5;
			object obj42 = obj24;
			IntPtr intPtr7 = intPtr5;
			UnityAction unityAction5 = obj24;
			object obj43 = obj24;
			UnityAction unityAction6 = this.noAdsButtons;
			object obj44 = obj33;
			Console.WriteLine("Unmanaged memory load: [v137 @ X0_v52 (UnityEngine.Events.UnityAction)+18]");
			object obj45 = (IntPtr)0;
			UnityEvent unityEvent2 = button6.m_OnClick;
			IL_C23:
			Button[] array = this.starButtons;
			bool flag15 = this.starButtons == 0;
			obj2 = obj34;
			obj4 = obj35;
			obj6 = obj36;
			obj8 = obj37;
			obj10 = obj38;
			obj12 = obj39;
			obj14 = obj40;
			obj16 = obj41;
			intPtr = intPtr6;
			obj18 = obj42;
			intPtr3 = intPtr7;
			unityAction = unityAction5;
			obj20 = obj43;
			unityAction3 = unityAction6;
			obj22 = obj44;
			obj23 = obj45;
			unityEvent = unityEvent2;
			if (!flag15)
			{
				Console.WriteLine("Unmanaged memory load: [v68 @ X8_v9 (UnityEngine.UI.Button[])+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v68 @ X8_v9 (UnityEngine.UI.Button[])+20]");
					object obj46 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v68 @ X8_v9 (UnityEngine.UI.Button[])+20]");
					bool flag16 = (IntPtr)0 == 0;
					Console.WriteLine("Unmanaged memory load: [v68 @ X8_v9 (UnityEngine.UI.Button[])+18]");
					obj2 = (IntPtr)0;
					obj4 = obj35;
					obj6 = obj36;
					obj8 = obj37;
					obj10 = obj38;
					obj12 = obj39;
					obj14 = obj40;
					obj16 = obj41;
					intPtr = intPtr6;
					obj18 = obj42;
					intPtr3 = intPtr7;
					unityAction = unityAction5;
					obj20 = obj43;
					unityAction3 = unityAction6;
					obj22 = obj44;
					obj23 = obj45;
					unityEvent = unityEvent2;
					if (flag16)
					{
						goto IL_B8C;
					}
					Console.WriteLine("Method not found @24D67D8");
					obj43..ctor(this, obj39);
					Console.WriteLine("Unmanaged memory load: [v69 @ X8_v10+100]");
					bool flag17 = (IntPtr)0 == 0;
					Console.WriteLine("Unmanaged memory load: [v68 @ X8_v9 (UnityEngine.UI.Button[])+18]");
					obj2 = (IntPtr)0;
					obj4 = obj35;
					obj6 = obj36;
					obj8 = obj37;
					obj10 = obj38;
					obj12 = obj39;
					obj14 = obj40;
					obj16 = obj41;
					intPtr = intPtr5;
					obj18 = this;
					intPtr3 = obj39;
					unityAction = obj43;
					obj20 = obj43;
					unityAction3 = obj43;
					obj22 = obj44;
					obj23 = obj45;
					Console.WriteLine("Unmanaged memory load: [v69 @ X8_v10+100]");
					unityEvent = (IntPtr)0;
					if (flag17)
					{
						goto IL_B8C;
					}
					Console.WriteLine("Unmanaged memory load: [v69 @ X8_v10+100]");
					((IntPtr)0).AddListener(obj43);
					bool flag18 = this.starButtons == 0;
					Console.WriteLine("Unmanaged memory load: [v68 @ X8_v9 (UnityEngine.UI.Button[])+18]");
					obj2 = (IntPtr)0;
					obj4 = obj35;
					obj6 = obj36;
					obj8 = obj37;
					obj10 = obj38;
					obj12 = obj39;
					obj14 = obj40;
					obj16 = obj41;
					intPtr = intPtr5;
					obj18 = obj43;
					intPtr3 = intPtr5;
					unityAction = obj43;
					obj20 = obj43;
					Console.WriteLine("Unmanaged memory load: [v69 @ X8_v10+100]");
					unityAction3 = (IntPtr)0;
					obj22 = obj44;
					obj23 = obj45;
					Console.WriteLine("Unmanaged memory load: [v69 @ X8_v10+100]");
					unityEvent = (IntPtr)0;
					if (flag18)
					{
						goto IL_B8C;
					}
				}
				Console.WriteLine("Method not found @24D67F0");
				continue;
			}
			IL_B8C:
			Console.WriteLine("Method not found @24D67E8");
			obj34 = obj2;
			obj35 = obj4;
			obj36 = obj6;
			obj37 = obj8;
			obj38 = obj10;
			obj39 = obj12;
			obj40 = obj14;
			obj41 = obj16;
			intPtr6 = intPtr;
			obj42 = obj18;
			intPtr7 = intPtr3;
			unityAction5 = unityAction;
			obj43 = obj20;
			unityAction6 = unityAction3;
			obj44 = obj22;
			obj45 = obj23;
			unityEvent2 = unityEvent;
			goto IL_C23;
		}
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00025128 File Offset: 0x00023328
	private void OnDisable()
	{
		bool flag = this == 0;
		UIManager uimanager = this;
		Console.WriteLine("Unmanaged memory load: [5592162]");
		PersistentCallGroup persistentCallGroup = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Unmanaged memory load: [523B128]");
			uimanager = (IntPtr)0;
			persistentCallGroup = 1L;
		}
		for (;;)
		{
			Button button = this.backToStartButton;
			bool flag2 = this.backToStartButton == 0;
			object obj2;
			object obj = obj2;
			object obj4;
			object obj3 = obj4;
			object obj6;
			object obj5 = obj6;
			object obj8;
			object obj7 = obj8;
			object obj10;
			object obj9 = obj10;
			object obj12;
			object obj11 = obj12;
			object obj14;
			object obj13 = obj14;
			UnityEventBase unityEventBase = uimanager;
			object obj15 = 1;
			PersistentCallGroup persistentCallGroup2 = persistentCallGroup;
			if (flag2)
			{
				goto IL_6E2;
			}
			bool flag3 = button.m_OnClick == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj14;
			unityEventBase = button.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag3)
			{
				goto IL_6E2;
			}
			button.m_OnClick.RemoveAllListeners();
			Button button2 = this.backToStartButton2;
			bool flag4 = this.backToStartButton2 == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			object obj16;
			obj13 = obj16;
			unityEventBase = button.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag4)
			{
				goto IL_6E2;
			}
			bool flag5 = button2.m_OnClick == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button2.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag5)
			{
				goto IL_6E2;
			}
			button2.m_OnClick.RemoveAllListeners();
			Button button3 = this.backToGameButton;
			bool flag6 = this.backToGameButton == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button2.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag6)
			{
				goto IL_6E2;
			}
			bool flag7 = button3.m_OnClick == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button3.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag7)
			{
				goto IL_6E2;
			}
			button3.m_OnClick.RemoveAllListeners();
			Button button4 = this.closeNoAdsButton;
			bool flag8 = this.closeNoAdsButton == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button3.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag8)
			{
				goto IL_6E2;
			}
			bool flag9 = button4.m_OnClick == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button4.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag9)
			{
				goto IL_6E2;
			}
			button4.m_OnClick.RemoveAllListeners();
			Button button5 = this.closePurchaseSuccessButton;
			bool flag10 = this.closePurchaseSuccessButton == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button4.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag10)
			{
				goto IL_6E2;
			}
			bool flag11 = button5.m_OnClick == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button5.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag11)
			{
				goto IL_6E2;
			}
			button5.m_OnClick.RemoveAllListeners();
			Button button6 = this.closePurchaseFailButton;
			bool flag12 = this.closePurchaseFailButton == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button5.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag12)
			{
				goto IL_6E2;
			}
			bool flag13 = button6.m_OnClick == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = button6.m_OnClick;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag13)
			{
				goto IL_6E2;
			}
			button6.m_OnClick.RemoveAllListeners();
			UnityEventBase unityEventBase2 = this.noAdsButtons;
			bool flag14 = this.noAdsButtons == 0;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj16;
			unityEventBase = this.noAdsButtons;
			obj15 = 1;
			persistentCallGroup2 = persistentCallGroup;
			if (flag14)
			{
				goto IL_6E2;
			}
			object obj18;
			object obj17 = obj18 - unityEventBase2.m_PersistentCalls;
			object obj19 = obj2;
			object obj20 = obj18;
			Console.WriteLine("Unmanaged memory load: [523B810]");
			object obj21 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B818]");
			object obj22 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B128]");
			object obj23 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B398]");
			object obj24 = (IntPtr)0;
			object obj25 = obj16;
			UnityEventBase unityEventBase3 = this.noAdsButtons;
			object obj26 = obj17;
			PersistentCallGroup persistentCallGroup3 = unityEventBase2.m_PersistentCalls;
			IL_741:
			Button[] array = this.starButtons;
			bool flag15 = this.starButtons == 0;
			obj = obj19;
			obj3 = obj20;
			obj5 = obj21;
			obj7 = obj22;
			obj9 = obj23;
			obj11 = obj24;
			obj13 = obj25;
			unityEventBase = unityEventBase3;
			obj15 = obj26;
			persistentCallGroup2 = persistentCallGroup3;
			if (!flag15)
			{
				Console.WriteLine("Unmanaged memory load: [v54 @ X8_v9 (UnityEngine.UI.Button[])+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v54 @ X8_v9 (UnityEngine.UI.Button[])+20]");
					object obj27 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v54 @ X8_v9 (UnityEngine.UI.Button[])+20]");
					bool flag16 = (IntPtr)0 == 0;
					Console.WriteLine("Unmanaged memory load: [v54 @ X8_v9 (UnityEngine.UI.Button[])+18]");
					obj = (IntPtr)0;
					obj3 = obj20;
					obj5 = obj21;
					obj7 = obj22;
					obj9 = obj23;
					obj11 = obj24;
					obj13 = obj25;
					unityEventBase = unityEventBase3;
					obj15 = obj26;
					persistentCallGroup2 = persistentCallGroup3;
					if (flag16)
					{
						goto IL_6E2;
					}
					Console.WriteLine("Unmanaged memory load: [v55 @ X8_v10+100]");
					bool flag17 = (IntPtr)0 == 0;
					Console.WriteLine("Unmanaged memory load: [v54 @ X8_v9 (UnityEngine.UI.Button[])+18]");
					obj = (IntPtr)0;
					obj3 = obj20;
					obj5 = obj21;
					obj7 = obj22;
					obj9 = obj23;
					obj11 = obj24;
					obj13 = obj25;
					Console.WriteLine("Unmanaged memory load: [v55 @ X8_v10+100]");
					unityEventBase = (IntPtr)0;
					obj15 = obj26;
					persistentCallGroup2 = persistentCallGroup3;
					if (flag17)
					{
						goto IL_6E2;
					}
					Console.WriteLine("Unmanaged memory load: [v55 @ X8_v10+100]");
					((IntPtr)0).RemoveAllListeners();
					bool flag18 = this.starButtons == 0;
					Console.WriteLine("Unmanaged memory load: [v54 @ X8_v9 (UnityEngine.UI.Button[])+18]");
					obj = (IntPtr)0;
					obj3 = obj20;
					obj5 = obj21;
					obj7 = obj22;
					obj9 = obj23;
					obj11 = obj24;
					obj13 = obj16;
					Console.WriteLine("Unmanaged memory load: [v55 @ X8_v10+100]");
					unityEventBase = (IntPtr)0;
					obj15 = obj26;
					persistentCallGroup2 = persistentCallGroup3;
					if (flag18)
					{
						goto IL_6E2;
					}
				}
				Console.WriteLine("Method not found @24D67F0");
				continue;
			}
			IL_6E2:
			Console.WriteLine("Method not found @24D67E8");
			obj19 = obj;
			obj20 = obj3;
			obj21 = obj5;
			obj22 = obj7;
			obj23 = obj9;
			obj24 = obj11;
			obj25 = obj13;
			unityEventBase3 = unityEventBase;
			obj26 = obj15;
			persistentCallGroup3 = persistentCallGroup2;
			goto IL_741;
		}
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00025BCC File Offset: 0x00023DCC
	public void OpenNoAdsPanel()
	{
		/*
An exception occurred when decompiling this method (060001FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::OpenNoAdsPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_90:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00025C74 File Offset: 0x00023E74
	public void CloseNoAdsPanel()
	{
		if (~this.inCourutine && !(~this.noAdsPanelOpened))
		{
			float transitionTime;
			IEnumerator routine = this.CloseNoAdsPanel(transitionTime);
			base.StartCoroutine(routine);
			return;
		}
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00025CDC File Offset: 0x00023EDC
	public IEnumerator OpenNoAdsPanel(float transitionTime)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		object obj;
		obj..ctor();
		Console.WriteLine("Method not found @24D64EC");
		return obj;
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00025D74 File Offset: 0x00023F74
	public IEnumerator CloseNoAdsPanel(float transitionTime)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		object obj;
		obj..ctor();
		Console.WriteLine("Method not found @24D64EC");
		return obj;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00025E0C File Offset: 0x0002400C
	public void DeactivateNoAdsButtons()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [5592165]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			obj = 1L;
		}
		List<Button> list = this.noAdsButtons;
		bool flag2 = this.noAdsButtons == 0;
		object obj3;
		object obj2 = obj3;
		object obj5;
		object obj4 = obj5;
		object obj7;
		object obj6 = obj7;
		object obj9;
		object obj8 = obj9;
		object obj10 = 1;
		object obj11 = obj;
		object obj13;
		object obj15;
		object obj16;
		object obj17;
		object obj18;
		object obj19;
		object obj20;
		if (!flag2)
		{
			object obj12 = obj13;
			Console.WriteLine("Unmanaged memory load: [v22 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.UI.Button>)+18]");
			object obj14 = obj12 - (IntPtr)0;
			obj15 = obj3;
			obj16 = obj5;
			obj17 = obj13;
			Console.WriteLine("Unmanaged memory load: [523B398]");
			obj18 = (IntPtr)0;
			obj19 = obj14;
			Console.WriteLine("Unmanaged memory load: [v22 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.UI.Button>)+18]");
			obj20 = (IntPtr)0;
			goto IL_BF;
		}
		IL_80:
		Console.WriteLine("Method not found @24D67E8");
		obj15 = obj2;
		obj16 = obj4;
		obj17 = obj6;
		obj18 = obj8;
		obj19 = obj10;
		obj20 = obj11;
		IL_BF:
		bool flag3 = this.speedrunAdsText == 0;
		obj2 = obj15;
		obj4 = obj16;
		obj6 = obj17;
		obj8 = obj18;
		obj10 = obj19;
		obj11 = obj20;
		if (flag3)
		{
			goto IL_80;
		}
		bool active;
		this.speedrunAdsText.SetActive(active);
		bool flag4 = this.speedrunNoAdsText == 0;
		object obj21;
		obj2 = obj21;
		obj4 = obj13;
		obj6 = obj17;
		obj8 = obj18;
		obj10 = obj19;
		obj11 = obj20;
		if (!flag4)
		{
			this.speedrunNoAdsText.SetActive(active);
			return;
		}
		goto IL_80;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00026048 File Offset: 0x00024248
	public void OpenPurchaseSuccessPanel()
	{
		/*
An exception occurred when decompiling this method (06000202)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::OpenPurchaseSuccessPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_44:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x000260A4 File Offset: 0x000242A4
	public void ClosePurchaseSuccessPanel()
	{
		/*
An exception occurred when decompiling this method (06000203)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::ClosePurchaseSuccessPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_2F:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000204 RID: 516 RVA: 0x000260F0 File Offset: 0x000242F0
	public void OpenPurchaseFailPanel()
	{
		/*
An exception occurred when decompiling this method (06000204)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::OpenPurchaseFailPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_49:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00026154 File Offset: 0x00024354
	public void ClosePurchaseFailPanel()
	{
		/*
An exception occurred when decompiling this method (06000205)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::ClosePurchaseFailPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_2F:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000206 RID: 518 RVA: 0x000261A0 File Offset: 0x000243A0
	public void OnPurchaseButtonClicked()
	{
		/*
An exception occurred when decompiling this method (06000206)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::OnPurchaseButtonClicked()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_57:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00026210 File Offset: 0x00024410
	public void OnPurchaseSuccessful()
	{
		if (!(~this.isNewPurchase))
		{
			this.OpenPurchaseSuccessPanel();
			bool flag;
			this.isNewPurchase = flag;
		}
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00026258 File Offset: 0x00024458
	public void OpenReviewPanel()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE38]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v24 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		if (obj2 != 0)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			return;
		}
		bool active;
		for (;;)
		{
			Console.WriteLine("Method not found @24D67E8");
			if (this.reviewInputSection != 0)
			{
				this.reviewInputSection.SetActive(active);
				if (this.reviewOnlyStarsObject != 0)
				{
					break;
				}
			}
		}
		this.reviewOnlyStarsObject.SetActive(active);
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00026390 File Offset: 0x00024590
	public void CloseReviewPanel()
	{
		/*
An exception occurred when decompiling this method (06000209)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::CloseReviewPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_2F:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600020A RID: 522 RVA: 0x000263DC File Offset: 0x000245DC
	public void GiveAStar(int rating)
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [5592167]");
		bool flag2 = (IntPtr)0 != 0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			flag2 = (1L != 0L);
		}
		Button[] array = this.starButtons;
		int num;
		this.starRating = num;
		bool flag3 = this.starButtons == 0;
		object obj2;
		object obj = obj2;
		object obj4;
		object obj3 = obj4;
		bool flag4 = rating != 0;
		Button[] array2 = this.starButtons;
		object obj6;
		object obj5 = obj6;
		int num2 = num;
		object obj8;
		object obj7 = obj8;
		bool flag5 = flag2;
		int num3 = (int)50012160L;
		object obj9;
		object obj10;
		bool flag6;
		Button[] array3;
		object obj11;
		int num4;
		object obj13;
		object obj12;
		bool flag7;
		int num5;
		if (!flag3)
		{
			Console.WriteLine("Unmanaged memory load: [v26 @ X8_v1 (UnityEngine.UI.Button[])+18]");
			obj9 = (IntPtr)0;
			obj10 = obj4;
			flag6 = (rating != 0);
			array3 = this.starButtons;
			obj11 = obj6;
			num4 = num;
			obj12 = obj13;
			flag7 = flag2;
			num5 = num;
			goto IL_DC;
		}
		IL_85:
		Console.WriteLine("Method not found @24D67E8");
		obj9 = obj;
		obj10 = obj3;
		flag6 = flag4;
		array3 = array2;
		obj11 = obj5;
		num4 = num2;
		obj12 = obj7;
		flag7 = flag5;
		num5 = num3;
		IL_DC:
		bool flag8 = this.reviewOnlyStarsObject == 0;
		obj = obj9;
		obj3 = obj10;
		flag4 = flag6;
		array2 = array3;
		obj5 = obj11;
		num2 = num4;
		obj7 = obj12;
		flag5 = flag7;
		num3 = num5;
		if (flag8)
		{
			goto IL_85;
		}
		this.reviewOnlyStarsObject.SetActive(flag6);
		bool flag9 = this.reviewInputSection == 0;
		obj = obj9;
		obj3 = obj10;
		flag4 = flag6;
		array2 = array3;
		obj5 = obj13;
		num2 = (int)1L;
		obj7 = obj12;
		flag5 = flag7;
		num3 = num5;
		if (flag9)
		{
			goto IL_85;
		}
		this.reviewInputSection.SetActive(flag6);
		Console.WriteLine("Unmanaged memory load: [523B5D0]");
		object obj14 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v95 @ X8_v6+B8]");
		Button[] array4 = (IntPtr)0;
		bool flag10 = array4 == 0;
		obj = obj9;
		obj3 = obj10;
		flag4 = flag6;
		array2 = array4;
		obj5 = obj13;
		int num6;
		num2 = num6;
		obj7 = obj12;
		flag5 = flag7;
		num3 = num5;
		if (flag10)
		{
			goto IL_85;
		}
		array4.RequestReview();
		float time;
		IEnumerator enumerator = array4.ClosePanelCoroutine(this.reviewPanel, time);
		Coroutine coroutine = base.StartCoroutine(enumerator);
		if (!(~this.ratingSelected))
		{
			return;
		}
		Console.WriteLine("Unmanaged memory load: [523AED0]");
		object obj15 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v122 @ X8_v11+B8]");
		Button[] array5 = (IntPtr)0;
		this.ratingSelected = (1L != 0L);
		bool flag11 = array5 == 0;
		obj = obj9;
		obj3 = 0.5;
		flag4 = (enumerator != null);
		array2 = array5;
		obj5 = obj13;
		num2 = num6;
		obj7 = obj12;
		flag5 = (1L != 0L);
		num3 = num5;
		if (!flag11)
		{
			array5.LogHighRating(enumerator);
			return;
		}
		goto IL_85;
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00026824 File Offset: 0x00024A24
	public void SubmitRating()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		bool flag;
		InputField inputField;
		object obj2;
		for (;;)
		{
			if (this.reviewPanel != 0)
			{
				this.reviewPanel.SetActive(flag);
				inputField = this.reviewInput;
				if (this.reviewInput != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523AED0]");
					object obj = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v64 @ X9_v4+B8]");
					obj2 = (IntPtr)0;
					if (obj2 != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj2.LogReview(flag ? 1 : 0, inputField.m_Text);
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0002693C File Offset: 0x00024B3C
	public void ClosePanel(GameObject panel, float time)
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		IEnumerator routine = this.ClosePanelCoroutine(panel, time);
		base.StartCoroutine(routine);
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00026984 File Offset: 0x00024B84
	public IEnumerator ClosePanelCoroutine(GameObject panel, float time)
	{
		if (panel != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		object obj;
		obj..ctor();
		Console.WriteLine("Method not found @24D64EC");
		return obj;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000407C File Offset: 0x0000227C
	public void ShowMessage(string message, MessageType messageType)
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00026A24 File Offset: 0x00024C24
	private void Start()
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
			if (this.restorePurchaseButton != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		bool active;
		this.restorePurchaseButton.SetActive(active);
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000407E File Offset: 0x0000227E
	private void Update()
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00026AF4 File Offset: 0x00024CF4
	private void <OnEnable>b__48_0()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		for (;;)
		{
			SoundManager soundManager = this.soundManager;
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				this.soundManager.PlaySound(soundManager.clickSound);
				this.OpenPrevPanel();
				Console.WriteLine("Unmanaged memory load: [v56 @ X8_v2+B8]");
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

	// Token: 0x06000213 RID: 531 RVA: 0x00026BF8 File Offset: 0x00024DF8
	private void <OnEnable>b__48_1()
	{
		/*
An exception occurred when decompiling this method (06000213)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::<OnEnable>b__48_1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_89:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00026C98 File Offset: 0x00024E98
	private void <OnEnable>b__48_2()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			SoundManager soundManager = this.soundManager;
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AE38]");
				object obj = (IntPtr)0;
				this.soundManager.PlaySound(soundManager.clickSound);
				this.OpenPrevPanel();
				Console.WriteLine("Unmanaged memory load: [v68 @ X8_v2+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523ACC8]");
					object obj3 = (IntPtr)0;
					obj2.Restart();
					Console.WriteLine("Unmanaged memory load: [v74 @ X8_v4+B8]");
					object obj4 = (IntPtr)0;
					if (obj4 != 0)
					{
						Action postAdAction_;
						bool waitForTime;
						obj4.ShowInterstitial(postAdAction_, waitForTime);
						if (this.levelManager != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		this.levelManager.OnLevelPanelClosed();
	}

	// Token: 0x06000215 RID: 533 RVA: 0x00026E24 File Offset: 0x00025024
	private void <OnEnable>b__48_3()
	{
		/*
An exception occurred when decompiling this method (06000215)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::<OnEnable>b__48_3()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_53:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00026E90 File Offset: 0x00025090
	private void <OnEnable>b__48_4()
	{
		/*
An exception occurred when decompiling this method (06000216)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::<OnEnable>b__48_4()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_53:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00026EFC File Offset: 0x000250FC
	private void <OnEnable>b__48_5()
	{
		/*
An exception occurred when decompiling this method (06000217)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::<OnEnable>b__48_5()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_53:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00026F68 File Offset: 0x00025168
	private void <OnEnable>b__48_13()
	{
		/*
An exception occurred when decompiling this method (06000218)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::<OnEnable>b__48_13()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_53:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00026FD4 File Offset: 0x000251D4
	private void <OnEnable>b__48_6()
	{
		int rating;
		this.GiveAStar(rating);
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00026FEC File Offset: 0x000251EC
	private void <OnEnable>b__48_7()
	{
		int rating;
		this.GiveAStar(rating);
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00027004 File Offset: 0x00025204
	private void <OnEnable>b__48_8()
	{
		int rating;
		this.GiveAStar(rating);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0002701C File Offset: 0x0002521C
	private void <OnEnable>b__48_9()
	{
		int rating;
		this.GiveAStar(rating);
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00027034 File Offset: 0x00025234
	private void <OnEnable>b__48_10()
	{
		int rating;
		this.GiveAStar(rating);
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0002704C File Offset: 0x0002524C
	private void <OnEnable>b__48_11()
	{
		/*
An exception occurred when decompiling this method (0600021E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::<OnEnable>b__48_11()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_7B:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x000270E0 File Offset: 0x000252E0
	private void <OnEnable>b__48_12()
	{
		/*
An exception occurred when decompiling this method (0600021F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager::<OnEnable>b__48_12()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_A5:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x04000212 RID: 530
	public static UIManager Instance;

	// Token: 0x04000213 RID: 531
	public GameObject startPanel;

	// Token: 0x04000214 RID: 532
	public GameObject gamePanel;

	// Token: 0x04000215 RID: 533
	public GameObject levelSelectPanel;

	// Token: 0x04000216 RID: 534
	public GameObject comingSoonPanel;

	// Token: 0x04000217 RID: 535
	public GameObject currentPanel;

	// Token: 0x04000218 RID: 536
	public GameObject prevPanel;

	// Token: 0x04000219 RID: 537
	public Button backToStartButton;

	// Token: 0x0400021A RID: 538
	public Button backToStartButton2;

	// Token: 0x0400021B RID: 539
	public Button backToGameButton;

	// Token: 0x0400021C RID: 540
	public Transform noAdsPanel;

	// Token: 0x0400021D RID: 541
	public bool noAdsPanelOpened;

	// Token: 0x0400021E RID: 542
	public bool inCourutine;

	// Token: 0x0400021F RID: 543
	public List<Button> noAdsButtons;

	// Token: 0x04000220 RID: 544
	public Button closeNoAdsButton;

	// Token: 0x04000221 RID: 545
	public GameObject purchaseSuccessPanel;

	// Token: 0x04000222 RID: 546
	public GameObject purchaseFailPanel;

	// Token: 0x04000223 RID: 547
	public Button closePurchaseSuccessButton;

	// Token: 0x04000224 RID: 548
	public Button closePurchaseFailButton;

	// Token: 0x04000225 RID: 549
	public bool isNewPurchase;

	// Token: 0x04000226 RID: 550
	public UpdatePriceText priceText;

	// Token: 0x04000227 RID: 551
	public GameObject speedrunAdsText;

	// Token: 0x04000228 RID: 552
	public GameObject speedrunNoAdsText;

	// Token: 0x04000229 RID: 553
	public GameObject reviewPanel;

	// Token: 0x0400022A RID: 554
	public Button[] starButtons;

	// Token: 0x0400022B RID: 555
	public GameObject reviewInputSection;

	// Token: 0x0400022C RID: 556
	public GameObject reviewOnlyStarsObject;

	// Token: 0x0400022D RID: 557
	public int starRating;

	// Token: 0x0400022E RID: 558
	public bool ratingSelected;

	// Token: 0x0400022F RID: 559
	public InputField reviewInput;

	// Token: 0x04000230 RID: 560
	public Button submitButton;

	// Token: 0x04000231 RID: 561
	public Button closeReviewPanelButton;

	// Token: 0x04000232 RID: 562
	public GameObject restorePurchaseButton;

	// Token: 0x04000233 RID: 563
	public SoundManager soundManager;

	// Token: 0x04000234 RID: 564
	public Button settingsButton;

	// Token: 0x04000235 RID: 565
	public Button closeSettingsButton;

	// Token: 0x04000236 RID: 566
	public GameObject settingsPanel;

	// Token: 0x04000237 RID: 567
	public LevelManager levelManager;

	// Token: 0x04000238 RID: 568
	public GameObject gameScene;

	// Token: 0x0200008C RID: 140
	private sealed class <CloseNoAdsPanel>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000385 RID: 901 RVA: 0x000441AC File Offset: 0x000423AC
		public <CloseNoAdsPanel>d__53(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000040CB File Offset: 0x000022CB
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000441D8 File Offset: 0x000423D8
		bool IEnumerator.MoveNext()
		{
			int num = (int)(~(int)0L);
			this.<>1__state = num;
			for (;;)
			{
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				if (this.<>4__this != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
			return this != null;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00044268 File Offset: 0x00042468
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0004427C File Offset: 0x0004247C
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000389)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager/<CloseNoAdsPanel>d__53::System.Collections.IEnumerator.Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67D8")); 	call:void(Console::WriteLine, ldstr:string("Unmanaged memory load: [523B230]")); 	call:void(NotSupportedException::.ctor, conv.i:native int[exp:NotSupportedException](ldc.i4:int32[exp:native int](0))); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D66AC")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000442E0 File Offset: 0x000424E0
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000421 RID: 1057
		private int <>1__state;

		// Token: 0x04000422 RID: 1058
		private object <>2__current;

		// Token: 0x04000423 RID: 1059
		public UIManager <>4__this;

		// Token: 0x04000424 RID: 1060
		public float transitionTime;

		// Token: 0x04000425 RID: 1061
		private float <time>5__2;
	}

	// Token: 0x0200008D RID: 141
	private sealed class <ClosePanelCoroutine>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600038B RID: 907 RVA: 0x000442F4 File Offset: 0x000424F4
		public <ClosePanelCoroutine>d__66(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000040CD File Offset: 0x000022CD
		void IDisposable.Dispose()
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00044320 File Offset: 0x00042520
		bool IEnumerator.MoveNext()
		{
			bool flag = this == 0;
			UIManager.<ClosePanelCoroutine>d__66 <ClosePanelCoroutine>d__ = this;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				UIManager.<ClosePanelCoroutine>d__66 <ClosePanelCoroutine>d__2;
				<ClosePanelCoroutine>d__ = <ClosePanelCoroutine>d__2;
			}
			bool result;
			if (this.<>1__state != 0)
			{
				result = (<ClosePanelCoroutine>d__ != null);
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00044434 File Offset: 0x00042634
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00044448 File Offset: 0x00042648
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (0600038F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager/<ClosePanelCoroutine>d__66::System.Collections.IEnumerator.Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67D8")); 	call:void(Console::WriteLine, ldstr:string("Unmanaged memory load: [523B230]")); 	call:void(NotSupportedException::.ctor, conv.i:native int[exp:NotSupportedException](ldc.i4:int32[exp:native int](0))); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D66AC")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000444AC File Offset: 0x000426AC
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000426 RID: 1062
		private int <>1__state;

		// Token: 0x04000427 RID: 1063
		private object <>2__current;

		// Token: 0x04000428 RID: 1064
		public float time;

		// Token: 0x04000429 RID: 1065
		public GameObject panel;
	}

	// Token: 0x0200008E RID: 142
	private sealed class <OpenNoAdsPanel>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000391 RID: 913 RVA: 0x000444C0 File Offset: 0x000426C0
		public <OpenNoAdsPanel>d__52(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000040CF File Offset: 0x000022CF
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000444EC File Offset: 0x000426EC
		bool IEnumerator.MoveNext()
		{
			int num = (int)(~(int)0L);
			this.<>1__state = num;
			for (;;)
			{
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				if (this.<>4__this != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
			return this != null;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0004457C File Offset: 0x0004277C
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00044590 File Offset: 0x00042790
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000395)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UIManager/<OpenNoAdsPanel>d__52::System.Collections.IEnumerator.Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67D8")); 	call:void(Console::WriteLine, ldstr:string("Unmanaged memory load: [523B230]")); 	call:void(NotSupportedException::.ctor, conv.i:native int[exp:NotSupportedException](ldc.i4:int32[exp:native int](0))); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D66AC")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000445F4 File Offset: 0x000427F4
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x0400042A RID: 1066
		private int <>1__state;

		// Token: 0x0400042B RID: 1067
		private object <>2__current;

		// Token: 0x0400042C RID: 1068
		public UIManager <>4__this;

		// Token: 0x0400042D RID: 1069
		public float transitionTime;

		// Token: 0x0400042E RID: 1070
		private float <time>5__2;
	}
}
