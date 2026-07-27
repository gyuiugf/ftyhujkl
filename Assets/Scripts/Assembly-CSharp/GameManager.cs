using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000012 RID: 18
public class GameManager : MonoBehaviour
{
	// Token: 0x06000081 RID: 129 RVA: 0x0000B7C4 File Offset: 0x000099C4
	public static float GetScreenWidth()
	{
		/*
An exception occurred when decompiling this method (06000081)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GameManager::GetScreenWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_7A:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000B854 File Offset: 0x00009A54
	public static float GetScreenHeight()
	{
		/*
An exception occurred when decompiling this method (06000082)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GameManager::GetScreenHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_3D:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x06000083 RID: 131 RVA: 0x0000B8A8 File Offset: 0x00009AA8
	public void OnGoalReached()
	{
		object obj2;
		object obj = obj2 - 160L;
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
			List<GoalObject> list = this.goalObjects;
			this.goalsReached = (1L != 0L);
			bool flag = this.goalObjects == 0;
			object obj4;
			object obj3 = obj4;
			ExpressionManager expressionManager2;
			ExpressionManager expressionManager = expressionManager2;
			bool flag3;
			bool flag2 = flag3;
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
			object obj16;
			object obj15 = obj16;
			object obj18;
			object obj17 = obj18;
			object obj20;
			object obj19 = obj20;
			object obj22;
			object obj21 = obj22;
			object obj24;
			object obj23 = obj24;
			object obj26;
			object obj25 = obj26;
			object obj28;
			object obj27 = obj28;
			object obj29 = 1;
			object obj30 = 50085888L;
			if (flag)
			{
				goto IL_F7;
			}
			object obj32;
			object obj31 = obj32;
			Console.WriteLine("Unmanaged memory load: [v29 @ X0_v22 (System.Collections.Generic.List`1<GoalObject>)+18]");
			object obj33 = obj31 - (IntPtr)0;
			object obj34 = obj4;
			ExpressionManager expressionManager3 = expressionManager2;
			bool flag4 = flag3;
			object obj35 = obj6;
			object obj36 = obj8;
			object obj37 = obj10;
			object obj38 = obj12;
			object obj39 = obj32;
			Console.WriteLine("Unmanaged memory load: [523B0A0]");
			object obj40 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B098]");
			object obj41 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B0B0]");
			object obj42 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B0D0]");
			object obj43 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B0A8]");
			object obj44 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B0C8]");
			object obj45 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B0E0]");
			object obj46 = (IntPtr)0;
			object obj47 = obj33;
			object obj48 = 50085888L;
			IL_18E:
			if (~this.goalsReached)
			{
				break;
			}
			bool flag5 = this.solvedText == 0;
			obj3 = obj34;
			expressionManager = expressionManager3;
			flag2 = flag4;
			obj5 = obj35;
			obj7 = obj36;
			obj9 = obj37;
			obj11 = obj38;
			obj13 = obj39;
			obj15 = obj40;
			obj17 = obj41;
			obj19 = obj42;
			obj21 = obj43;
			obj23 = obj44;
			obj25 = obj45;
			obj27 = obj46;
			obj29 = obj47;
			obj30 = obj48;
			if (!flag5)
			{
				this.solvedText.SetActive(flag4);
				object obj49 = (this.speedrun ? 1L : 0L) - 0L;
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				float num;
				this.nextLevelTimer = num;
				bool flag6 = this.obstacleObjects == 0;
				obj3 = obj34;
				expressionManager = expressionManager3;
				flag2 = flag4;
				obj5 = this;
				obj7 = 348L;
				obj9 = obj;
				obj11 = 1L;
				obj13 = obj39;
				obj15 = obj40;
				obj17 = obj41;
				obj19 = obj42;
				obj21 = obj43;
				obj23 = obj44;
				obj25 = obj45;
				obj27 = obj46;
				obj29 = obj49;
				obj30 = obj48;
				if (!flag6)
				{
					List<object>.Enumerator enumerator = this.obstacleObjects.GetEnumerator();
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+10]");
					IntPtr intPtr = (IntPtr)0;
					ExpressionManager expressionManager4 = obj + 48L;
					obj = obj;
					object obj50 = obj34;
					ExpressionManager expressionManager5 = expressionManager4;
					object obj51;
					for (;;)
					{
						bool flag7 = obj44 == 0;
						List<object>.Enumerator enumerator2 = obj + 48L;
						bool flag8 = enumerator2.MoveNext();
						obj51 = !flag7;
						if (obj51 != null)
						{
							goto IL_3EC;
						}
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+40]");
						object obj52 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+40]");
						if ((IntPtr)0 == 0)
						{
							goto IL_6D1;
						}
						ExpressionManager expressionManager6 = obj52;
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
						Console.WriteLine("Unmanaged memory load: [v219 @ X8_v8 (ExpressionManager)+1C8]");
						obj50 = (IntPtr)0;
						expressionManager5 = expressionManager6;
					}
					IL_6E0:
					Console.WriteLine("Method not found @24D67E8");
					Console.WriteLine("Method not found @21483DC");
					Console.WriteLine("Method not found @25C617C");
					Console.WriteLine("Method not found @21483A0");
					continue;
					IL_6D1:
					Console.WriteLine("Method not found @24D67E8");
					goto IL_6E0;
					IL_3EC:
					List<object>.Enumerator enumerator3 = obj + 48L;
					enumerator3.Dispose();
					bool flag9 = this.goalObjects == 0;
					obj3 = obj50;
					expressionManager = expressionManager5;
					flag2 = (obj40 != null);
					obj5 = obj;
					obj7 = 348L;
					obj9 = obj;
					obj11 = 1L;
					obj13 = obj39;
					obj15 = obj40;
					obj17 = obj41;
					obj19 = obj42;
					obj21 = obj43;
					obj23 = obj44;
					obj25 = obj45;
					obj27 = obj46;
					obj29 = obj51;
					obj30 = obj48;
					if (!flag9)
					{
						object obj53 = obj + 24L;
						List<object>.Enumerator enumerator4 = this.goalObjects.GetEnumerator();
						obj = obj;
						object obj54 = obj50;
						object obj55;
						for (;;)
						{
							bool flag10 = obj42 == 0;
							List<object>.Enumerator enumerator5 = obj + 24L;
							bool flag11 = enumerator5.MoveNext();
							obj55 = !flag10;
							if (obj55 != null)
							{
								break;
							}
							Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+28]");
							object obj56 = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+28]");
							if ((IntPtr)0 == 0)
							{
								goto IL_6E0;
							}
							Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
							Console.WriteLine("Unmanaged memory load: [v255 @ X8_v11+1B8]");
							obj54 = (IntPtr)0;
						}
						List<object>.Enumerator enumerator6 = obj + 24L;
						enumerator6.Dispose();
						bool flag12 = this.expression1 == 0;
						obj3 = obj54;
						expressionManager = this.expression1;
						flag2 = (obj41 != null);
						obj5 = obj;
						obj7 = 348L;
						obj9 = obj;
						obj11 = 1L;
						obj13 = obj39;
						obj15 = obj40;
						obj17 = obj41;
						obj19 = obj42;
						obj21 = obj43;
						obj23 = obj44;
						obj25 = obj45;
						obj27 = obj46;
						obj29 = obj55;
						obj30 = obj53;
						if (!flag12)
						{
							bool flag13 = this.expression2 == 0;
							obj3 = obj54;
							expressionManager = this.expression2;
							flag2 = (obj41 != null);
							obj5 = obj;
							obj7 = 348L;
							obj9 = obj;
							obj11 = 1L;
							obj13 = obj39;
							obj15 = obj40;
							obj17 = obj41;
							obj19 = obj42;
							obj21 = obj43;
							obj23 = obj44;
							obj25 = obj45;
							obj27 = obj46;
							obj29 = obj55;
							obj30 = obj53;
							if (!flag13)
							{
								break;
							}
						}
					}
				}
			}
			IL_F7:
			Console.WriteLine("Method not found @24D67E8");
			obj34 = obj3;
			expressionManager3 = expressionManager;
			flag4 = flag2;
			obj35 = obj5;
			obj36 = obj7;
			obj37 = obj9;
			obj38 = obj11;
			obj39 = obj13;
			obj40 = obj15;
			obj41 = obj17;
			obj42 = obj19;
			obj43 = obj21;
			obj44 = obj23;
			obj45 = obj25;
			obj46 = obj27;
			obj47 = obj29;
			obj48 = obj30;
			goto IL_18E;
		}
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0000C21C File Offset: 0x0000A41C
	public void OpenRestartPanelEndless(long score)
	{
		/*
An exception occurred when decompiling this method (06000084)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::OpenRestartPanelEndless(System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_74:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
	public static string ReturnTimeTextMilliseconds(long time_)
	{
		object obj2;
		object obj = obj2 - 80L;
		if (time_ != 0L)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction SMULH not yet implemented.");
			object obj3 = 10661L + time_;
			Console.WriteLine("Not implemented instruction: Instruction SBFM not yet implemented.");
			object obj5;
			object obj4 = obj5 + obj3;
			Console.WriteLine("Method not found @24D662C");
			long num = obj + 8L;
			string text = num.ToString();
			if (text != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				object obj6;
				if (obj6 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v47 @ X0_v15+18]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Method not found @24D64EC");
						long num2 = obj + 8L;
						string text2 = num2.ToString();
						Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					}
					Console.WriteLine("Method not found @24D67F0");
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0000C4BC File Offset: 0x0000A6BC
	public static string ReturnTimeText(long time_)
	{
		object obj2;
		object obj = obj2 - 80L;
		if (time_ != 0L)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Method not found @24D662C");
			long num = obj + 8L;
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction SMULH not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction SBFM not yet implemented.");
			object obj4;
			object obj3 = obj4 + 31749L;
			string text = num.ToString();
			if (text != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				object obj5;
				if (obj5 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v34 @ X0_v15+18]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Method not found @24D64EC");
						long num2 = obj + 8L;
						string text2 = num2.ToString();
						Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					}
					Console.WriteLine("Method not found @24D67F0");
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000C6BC File Offset: 0x0000A8BC
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE38]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000C754 File Offset: 0x0000A954
	private void OnEnable()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj;
		Button button4;
		for (;;)
		{
			Button button = this.restartButton;
			if (this.restartButton != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B128]");
				obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B108]");
				object method = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor(this, method);
				if (button.m_OnClick != 0)
				{
					button.m_OnClick.AddListener(obj);
					Button button2 = this.restartButton2;
					if (this.restartButton2 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523B110]");
						object method2 = (IntPtr)0;
						Console.WriteLine("Method not found @24D67D8");
						obj..ctor(this, method2);
						if (button2.m_OnClick != 0)
						{
							button2.m_OnClick.AddListener(obj);
							Button button3 = this.backButton;
							if (this.backButton != 0)
							{
								Console.WriteLine("Unmanaged memory load: [523B118]");
								object method3 = (IntPtr)0;
								Console.WriteLine("Method not found @24D67D8");
								obj..ctor(this, method3);
								if (button3.m_OnClick != 0)
								{
									button3.m_OnClick.AddListener(obj);
									button4 = this.hintButton;
									if (this.hintButton != 0)
									{
										Console.WriteLine("Unmanaged memory load: [523B120]");
										object method4 = (IntPtr)0;
										Console.WriteLine("Method not found @24D67D8");
										obj..ctor(this, method4);
										if (button4.m_OnClick != 0)
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
		button4.m_OnClick.AddListener(obj);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0000CA30 File Offset: 0x0000AC30
	private void OnDisable()
	{
		/*
An exception occurred when decompiling this method (06000089)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::OnDisable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_16F:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
	private void Start()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B130]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Vector3 vector;
		float num;
		Camera main2;
		for (;;)
		{
			int targetFrameRate = obj;
			Console.WriteLine("Unmanaged memory load: [v24 @ X0_v4 (System.Int32)+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Application.targetFrameRate = targetFrameRate;
			if (this.ball1 != 0)
			{
				Vector3 position = this.ball1.position;
				this.startPos1 = vector;
				if (this.ball2 != 0)
				{
					Vector3 position2 = this.ball2.position;
					this.startPos2 = vector;
					Camera main = Camera.main;
					if (main != 0)
					{
						float orthographicSize = main.orthographicSize;
						num = vector + vector;
						this.screenHeight = num;
						main2 = Camera.main;
						if (main2 != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		float aspect = main2.aspect;
		float num2 = num * vector;
		this.screenWidth = num2;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000CDAC File Offset: 0x0000AFAC
	public IEnumerator ShowTutorial()
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

	// Token: 0x0600008C RID: 140 RVA: 0x0000CE3C File Offset: 0x0000B03C
	public void LoadLevel(Level level)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Vector3 vector;
		for (;;)
		{
			if (level != 0)
			{
				this.startPos1 = level.startPosition1;
				this.startPos2 = level.startPosition2;
				this.startScale1 = level.scale1;
				if (this.startPlatform != 0)
				{
					Transform transform = this.startPlatform.transform;
					if (transform != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523ADE0]");
						object obj = (IntPtr)0;
						transform.position = vector;
						this.goalObjects = level.goalObjects;
						Console.WriteLine("Method not found @24D64EC");
						this.obstacleObjects = level.obstacleObjects;
						Console.WriteLine("Method not found @24D64EC");
						this.activateOnStart = level.activateOnStart;
						Console.WriteLine("Method not found @24D64EC");
						this.deactivateOnStart = level.deactivateOnStart;
						Console.WriteLine("Method not found @24D64EC");
						this.goalObjects = level.leftBorder;
						Console.WriteLine("Unmanaged memory load: [v185 @ X0_v11+E4]");
						bool flag = (IntPtr)0 == 0;
						if (flag)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag2 = vector == 0;
						bool flag3 = this.ball1Script != level;
						if (flag2)
						{
							Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
							Console.WriteLine("Unmanaged memory load: [v204 @ X0_v14+E4]");
							bool flag4 = (IntPtr)0 == 0;
							if (flag4)
							{
								Console.WriteLine("Method not found @24D66BC");
							}
							bool flag5 = vector == 0;
							bool flag6 = this.ball1Script != vector;
							if (flag5)
							{
								Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
								if (!flag6)
								{
									goto IL_4B6;
								}
								GameObject gameObject = flag6.gameObject;
								if (gameObject == 0)
								{
									goto IL_4B6;
								}
								gameObject.SetActive(vector != null);
							}
							GameObject gameObject2 = level.gameObject;
							if (gameObject2 == 0)
							{
								goto IL_4B6;
							}
							gameObject2.SetActive(vector != null);
							this.ball1Script = level;
							Console.WriteLine("Method not found @24D64EC");
						}
						PlayerManager playerManager = this.playerManager;
						if (this.playerManager != 0)
						{
							playerManager.restrictionTransform = level.restrictionTransform;
							Console.WriteLine("Method not found @24D64EC");
							this.Restart();
							if (this.solvedText != 0)
							{
								this.solvedText.SetActive(level.restrictionTransform != null);
								bool flag7 = ~this.speedrun;
								if (flag7)
								{
									if (this.speedrunTimerText == 0)
									{
										goto IL_4B6;
									}
									GameObject gameObject3 = this.speedrunTimerText.gameObject;
									if (gameObject3 == 0)
									{
										goto IL_4B6;
									}
									gameObject3.SetActive(vector != null);
								}
								if (this.solvedBadge != 0)
								{
									Vector3 position = this.solvedBadge.position;
									if (this.solvedBadge != 0)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
			IL_4B6:
			Console.WriteLine("Method not found @24D67E8");
		}
		Vector3 position2 = this.solvedBadge.position;
		this.solvedBadge.position = vector;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000D328 File Offset: 0x0000B528
	public void StartSpeedrun()
	{
		/*
An exception occurred when decompiling this method (0600008D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::StartSpeedrun()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_DC:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x0000D41C File Offset: 0x0000B61C
	public void OnSpeedrunFinished()
	{
		/*
An exception occurred when decompiling this method (0600008E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::OnSpeedrunFinished()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_1C5:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
	public void Restart()
	{
		object obj;
		Vector3 vector = obj - 288L;
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
			Console.WriteLine("Unmanaged memory load: [523B0D0]");
			GameManager gameManager = (IntPtr)0;
		}
		float num;
		for (;;)
		{
			if (this.ball1 != 0)
			{
				Vector3 position = this.ball1.position;
				this.ball1.position = vector;
				bool flag = this.ball2 == 0;
				Transform transform = this.ball1;
				if (!flag)
				{
					Vector3 position2 = this.ball2.position;
					this.ball2.position = vector;
					Console.WriteLine("Unmanaged memory load: [559212D]");
					bool flag2 = (IntPtr)0 == 0;
					object obj2 = !flag2;
					Transform transform2 = this.ball2;
					if (obj2 == null)
					{
						Console.WriteLine("Method not found @24D6540");
						Console.WriteLine("Unmanaged memory load: [523AE20]");
						transform2 = (IntPtr)0;
					}
					if (this.ball1 != 0)
					{
						this.ball1.localScale = vector;
						Console.WriteLine("Unmanaged memory load: [559212D]");
						bool flag3 = (IntPtr)0 == 0;
						object obj3 = !flag3;
						Transform transform3 = this.ball1;
						if (obj3 == null)
						{
							Console.WriteLine("Method not found @24D6540");
							Console.WriteLine("Unmanaged memory load: [523AE20]");
							transform3 = (IntPtr)0;
						}
						if (this.ball2 != 0)
						{
							this.ball2.localScale = vector;
							Console.WriteLine("Unmanaged memory load: [559212E]");
							bool flag4 = (IntPtr)0 == 0;
							object obj4 = !flag4;
							Transform transform4 = this.ball2;
							if (obj4 == null)
							{
								Console.WriteLine("Method not found @24D6540");
								Console.WriteLine("Unmanaged memory load: [523AE20]");
								transform4 = (IntPtr)0;
							}
							if (this.ball2 != 0)
							{
								this.ball2.eulerAngles = vector;
								this.currentGravityScale = 1f;
								bool flag5 = this.rb1 == 0;
								transform = this.rb1;
								if (!flag5)
								{
									float gravityScale;
									this.rb1.gravityScale = gravityScale;
									bool flag6 = this.rb2 == 0;
									transform = this.rb2;
									if (!flag6)
									{
										this.rb2.gravityScale = gravityScale;
										this.ResetVelocity();
										bool flag7 = this.ball1Script == 0;
										transform = this.ball1Script;
										if (!flag7)
										{
											this.ball1Script.Restart();
											bool flag8 = this.ball2Script == 0;
											transform = this.ball2Script;
											if (!flag8)
											{
												this.ball2Script.Restart();
												bool flag9 = this.startPlatform == 0;
												transform = this.startPlatform;
												if (!flag9)
												{
													this.startPlatform.SetActive(vector != null);
													bool flag10 = this.startPlatformSprite == 0;
													transform = this.startPlatformSprite;
													if (!flag10)
													{
														this.startPlatformSprite.color = vector;
														bool flag11 = this.startPlatformColider == 0;
														transform = this.startPlatformColider;
														if (!flag11)
														{
															this.startPlatformColider.enabled = (vector != null);
															this.platformTimer = num;
															bool flag12 = this.playerManager == 0;
															transform = this.startPlatformColider;
															if (!flag12)
															{
																Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
																this.lost = (num != null);
																bool flag13 = this.obstacleObjects == 0;
																transform = this.obstacleObjects;
																if (!flag13)
																{
																	Console.WriteLine("Unmanaged memory load: [523B0A8]");
																	object obj5 = (IntPtr)0;
																	Console.WriteLine("Unmanaged memory load: [523B0B0]");
																	object obj6 = (IntPtr)0;
																	Console.WriteLine("Unmanaged memory load: [523B150]");
																	object obj7 = (IntPtr)0;
																	Console.WriteLine("Unmanaged memory load: [523B158]");
																	object obj8 = (IntPtr)0;
																	List<object>.Enumerator enumerator = this.obstacleObjects.GetEnumerator();
																	Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
																	Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+28]");
																	IntPtr intPtr = (IntPtr)0;
																	object obj9 = vector + 144L;
																	for (;;)
																	{
																		bool flag14 = obj5 == 0;
																		List<object>.Enumerator enumerator2 = vector + 144L;
																		bool flag15 = enumerator2.MoveNext();
																		if (!flag14)
																		{
																			break;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+A0]");
																		if ((IntPtr)0 == 0)
																		{
																			goto IL_B3D;
																		}
																		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
																	}
																	List<object>.Enumerator enumerator3 = vector + 144L;
																	enumerator3.Dispose();
																	bool flag16 = this.goalObjects == 0;
																	transform = this.goalObjects;
																	if (flag16)
																	{
																		goto IL_BCF;
																	}
																	List<object>.Enumerator enumerator4 = this.goalObjects.GetEnumerator();
																	Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
																	Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+28]");
																	IntPtr intPtr2 = (IntPtr)0;
																	object obj10 = vector + 112L;
																	GameObject gameObject;
																	for (;;)
																	{
																		bool flag17 = obj6 == 0;
																		List<object>.Enumerator enumerator5 = vector + 112L;
																		bool flag18 = enumerator5.MoveNext();
																		if (!flag17)
																		{
																			break;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+80]");
																		bool flag19 = (IntPtr)0 == 0;
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+80]");
																		gameObject = (IntPtr)0;
																		if (flag19)
																		{
																			goto IL_B5C;
																		}
																		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
																	}
																	List<object>.Enumerator enumerator6 = vector + 112L;
																	enumerator6.Dispose();
																	bool flag20 = this.activateOnStart == 0;
																	transform = this.activateOnStart;
																	if (flag20)
																	{
																		goto IL_BCF;
																	}
																	List<object>.Enumerator enumerator7 = this.activateOnStart.GetEnumerator();
																	Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
																	Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+28]");
																	IntPtr intPtr3 = (IntPtr)0;
																	object obj11 = vector + 80L;
																	for (;;)
																	{
																		bool flag21 = ~(obj7 != null) != null;
																		List<object>.Enumerator enumerator8 = vector + 80L;
																		bool flag22 = enumerator8.MoveNext();
																		if (!flag21)
																		{
																			break;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+60]");
																		bool flag23 = (IntPtr)0 == 0;
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+60]");
																		GameObject gameObject2 = (IntPtr)0;
																		if (flag23)
																		{
																			goto IL_B73;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+60]");
																		((IntPtr)0).SetActive(obj7 != null);
																	}
																	List<object>.Enumerator enumerator9 = vector + 80L;
																	enumerator9.Dispose();
																	bool flag24 = this.deactivateOnStart == 0;
																	transform = this.deactivateOnStart;
																	if (flag24)
																	{
																		goto IL_BCF;
																	}
																	List<object>.Enumerator enumerator10 = this.deactivateOnStart.GetEnumerator();
																	Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
																	Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+28]");
																	IntPtr intPtr4 = (IntPtr)0;
																	object obj12 = vector + 80L;
																	for (;;)
																	{
																		bool flag25 = ~(obj7 != null) != null;
																		List<object>.Enumerator enumerator11 = vector + 80L;
																		bool flag26 = enumerator11.MoveNext();
																		if (!flag25)
																		{
																			break;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+60]");
																		bool flag27 = (IntPtr)0 == 0;
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+60]");
																		GameObject gameObject3 = (IntPtr)0;
																		if (flag27)
																		{
																			goto IL_B8A;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+60]");
																		((IntPtr)0).SetActive(obj7 != null);
																	}
																	List<object>.Enumerator enumerator12 = vector + 80L;
																	enumerator12.Dispose();
																	bool flag28 = this.sliceableObjects == 0;
																	transform = this.sliceableObjects;
																	if (flag28)
																	{
																		goto IL_BCF;
																	}
																	List<object>.Enumerator enumerator13 = this.sliceableObjects.GetEnumerator();
																	Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
																	Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+28]");
																	IntPtr intPtr5 = (IntPtr)0;
																	object obj13 = vector + 48L;
																	for (;;)
																	{
																		bool flag29 = obj8 == 0;
																		List<object>.Enumerator enumerator14 = vector + 48L;
																		bool flag30 = enumerator14.MoveNext();
																		if (!flag29)
																		{
																			break;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+40]");
																		bool flag31 = (IntPtr)0 == 0;
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+40]");
																		GameObject gameObject4 = (IntPtr)0;
																		if (flag31)
																		{
																			goto IL_BA1;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+40]");
																		((IntPtr)0).Reset();
																	}
																	List<object>.Enumerator enumerator15 = vector + 48L;
																	enumerator15.Dispose();
																	this.started = (num != null);
																	this.goalsReached = (num != null);
																	if (this.expression1 == 0 || this.expression2 == 0)
																	{
																		goto IL_BCF;
																	}
																	bool flag32 = this.affectedObstacles == 0;
																	transform = this.affectedObstacles;
																	if (flag32)
																	{
																		goto IL_BCF;
																	}
																	List<object>.Enumerator enumerator16 = this.affectedObstacles.GetEnumerator();
																	Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
																	Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+28]");
																	IntPtr intPtr6 = (IntPtr)0;
																	object obj14 = vector + 144L;
																	for (;;)
																	{
																		bool flag33 = obj5 == 0;
																		List<object>.Enumerator enumerator17 = vector + 144L;
																		bool flag34 = enumerator17.MoveNext();
																		if (!flag33)
																		{
																			break;
																		}
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+A0]");
																		bool flag35 = (IntPtr)0 == 0;
																		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+A0]");
																		Transform transform5 = (IntPtr)0;
																		if (flag35)
																		{
																			goto IL_BB8;
																		}
																		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
																	}
																	List<object>.Enumerator enumerator18 = vector + 144L;
																	enumerator18.Dispose();
																	List<ObstacleObject> list = this.affectedObstacles;
																	if (this.affectedObstacles != 0)
																	{
																		break;
																	}
																	goto IL_BCF;
																	IL_BB8:
																	Console.WriteLine("Method not found @24D67E8");
																	goto IL_BCF;
																	IL_BA1:
																	Console.WriteLine("Method not found @24D67E8");
																	goto IL_BB8;
																	IL_B8A:
																	Console.WriteLine("Method not found @24D67E8");
																	goto IL_BA1;
																	IL_B73:
																	Console.WriteLine("Method not found @24D67E8");
																	goto IL_B8A;
																	IL_B5C:
																	Console.WriteLine("Method not found @24D67E8");
																	goto IL_B73;
																	IL_B3D:
																	Console.WriteLine("Method not found @24D67E8");
																	Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+A0]");
																	gameObject = (IntPtr)0;
																	goto IL_B5C;
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
			IL_BCF:
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @21483AC");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
		}
		Console.WriteLine("Unmanaged memory load: [v104 @ X8_v39 (System.Collections.Generic.List`1<ObstacleObject>)+1C]");
		object obj15 = (IntPtr)0 + 1;
		this.loseTimer = num;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000E488 File Offset: 0x0000C688
	public void ResetVelocity()
	{
		Console.WriteLine("Unmanaged memory load: [559212F]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		float angularVelocity;
		for (;;)
		{
			if (this.rb1 != 0)
			{
				Vector2 linearVelocity;
				this.rb1.linearVelocity = linearVelocity;
				Console.WriteLine("Unmanaged memory load: [559212F]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				if (this.rb2 != 0)
				{
					this.rb2.linearVelocity = linearVelocity;
					if (this.rb1 != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
						this.rb1.angularVelocity = angularVelocity;
						if (this.rb2 != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		this.rb2.angularVelocity = angularVelocity;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000E624 File Offset: 0x0000C824
	public void OnLose()
	{
		object obj2;
		object obj = obj2 - 112L;
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
		object obj9;
		object obj10;
		object obj11;
		for (;;)
		{
			if (~this.endless)
			{
				goto IL_247;
			}
			if (this.goalObjects != 0)
			{
				int index;
				object obj3 = this.goalObjects.get_Item(index);
				if (obj3 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v40 @ X0_v28 (System.Object)+20]");
					if ((IntPtr)0 == 0)
					{
						goto IL_247;
					}
					if (this.playerManager != 0)
					{
						this.playerManager.OnLose();
						this.lost = (1L != 0L);
						if (this.obstacleObjects != 0)
						{
							List<object>.Enumerator enumerator = this.obstacleObjects.GetEnumerator();
							object obj4 = obj + 48L;
							Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+10]");
							IntPtr intPtr = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [523B0A8]");
							object obj5 = (IntPtr)0;
							obj = obj;
							for (;;)
							{
								bool flag = obj5 == 0;
								List<object>.Enumerator enumerator2 = obj + 48L;
								bool flag2 = enumerator2.MoveNext();
								if (!flag)
								{
									break;
								}
								Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+40]");
								if ((IntPtr)0 == 0)
								{
									goto IL_3FD;
								}
								Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
							}
							List<object>.Enumerator enumerator3 = obj + 48L;
							enumerator3.Dispose();
							if (this.goalObjects == 0)
							{
								goto IL_41B;
							}
							object obj6 = obj + 24L;
							List<object>.Enumerator enumerator4 = this.goalObjects.GetEnumerator();
							Console.WriteLine("Unmanaged memory load: [523B0B0]");
							object obj7 = (IntPtr)0;
							obj = obj;
							for (;;)
							{
								bool flag3 = obj7 == 0;
								List<object>.Enumerator enumerator5 = obj + 24L;
								bool flag4 = enumerator5.MoveNext();
								if (!flag3)
								{
									goto IL_3D3;
								}
								Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+28]");
								if ((IntPtr)0 == 0)
								{
									break;
								}
								Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
							}
							IL_40C:
							Console.WriteLine("Method not found @24D67E8");
							goto IL_41B;
							IL_3FD:
							Console.WriteLine("Method not found @24D67E8");
							goto IL_40C;
						}
					}
				}
			}
			IL_41B:
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @21483DC");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
			continue;
			IL_247:
			this.Restart();
			bool flag5 = ~this.speedrun;
			if (!flag5 || ~this.inGameAds)
			{
				goto IL_4C1;
			}
			Console.WriteLine("Unmanaged memory load: [523ACC8]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v152 @ X8_v23+B8]");
			obj9 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523AD60]");
			obj10 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523B1A8]");
			obj11 = (IntPtr)0;
			obj10..ctor(this, obj11);
			if (obj9 != 0)
			{
				break;
			}
			goto IL_41B;
		}
		obj9.ShowInterstitial(obj10, obj11 != null);
		goto IL_4C1;
		IL_3D3:
		List<object>.Enumerator enumerator6 = obj + 24L;
		enumerator6.Dispose();
		float num;
		this.started = (num != null);
		IL_4C1:
		this.loseTimer = num;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000EB54 File Offset: 0x0000CD54
	public void OnPickUp()
	{
		object obj2;
		object obj = obj2 - 112L;
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
		for (;;)
		{
			bool flag = ~this.started;
			if (!flag)
			{
				return;
			}
			this.platformTimer = 1f;
			if (this.startPlatformColider != 0)
			{
				bool enabled;
				this.startPlatformColider.enabled = enabled;
				if (this.obstacleObjects != 0)
				{
					List<object>.Enumerator enumerator = this.obstacleObjects.GetEnumerator();
					object obj3 = obj + 48L;
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+10]");
					IntPtr intPtr = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523B0A8]");
					object obj4 = (IntPtr)0;
					obj = obj;
					for (;;)
					{
						bool flag2 = obj4 == 0;
						List<object>.Enumerator enumerator2 = obj + 48L;
						bool flag3 = enumerator2.MoveNext();
						if (!flag2)
						{
							break;
						}
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+40]");
						if ((IntPtr)0 == 0)
						{
							goto IL_281;
						}
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					}
					List<object>.Enumerator enumerator3 = obj + 48L;
					enumerator3.Dispose();
					if (this.goalObjects == 0)
					{
						goto IL_29F;
					}
					object obj5 = obj + 24L;
					List<object>.Enumerator enumerator4 = this.goalObjects.GetEnumerator();
					Console.WriteLine("Unmanaged memory load: [523B0B0]");
					object obj6 = (IntPtr)0;
					obj = obj;
					for (;;)
					{
						bool flag4 = obj6 == 0;
						List<object>.Enumerator enumerator5 = obj + 24L;
						bool flag5 = enumerator5.MoveNext();
						if (!flag4)
						{
							goto IL_252;
						}
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+28]");
						if ((IntPtr)0 == 0)
						{
							break;
						}
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					}
					IL_290:
					Console.WriteLine("Method not found @24D67E8");
					goto IL_29F;
					IL_281:
					Console.WriteLine("Method not found @24D67E8");
					goto IL_290;
				}
			}
			IL_29F:
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @21483DC");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
		}
		IL_252:
		List<object>.Enumerator enumerator6 = obj + 24L;
		enumerator6.Dispose();
		this.started = (1L != 0L);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x0000EF08 File Offset: 0x0000D108
	public bool InBounds()
	{
		Vector3 position;
		if (this.rightBorderTransform != 0)
		{
			position = this.rightBorderTransform.position;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			goto IL_4D;
		}
		for (;;)
		{
			IL_1C6:
			Console.WriteLine("Method not found @24D67E8");
			if (!(~this.leftBorder))
			{
				goto Block_9;
			}
			if (!(~this.rightBorder))
			{
				if (this.ball2 != 0)
				{
					break;
				}
			}
			else if (!(~this.bottomBorder))
			{
				if (this.ball2 != 0)
				{
					goto Block_6;
				}
			}
			else
			{
				if (~this.topBorder)
				{
					goto IL_1AC;
				}
				if (this.ball2 != 0)
				{
					goto Block_8;
				}
			}
		}
		Vector3 position2 = this.ball2.position;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Vector3 result = position2;
		goto IL_1B9;
		Block_6:
		Vector3 position3 = this.ball2.position;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		result = position3;
		goto IL_1B9;
		Block_8:
		Vector3 position4 = this.ball2.position;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		result = position4;
		goto IL_1B9;
		IL_1AC:
		return position != null;
		Block_9:
		IL_4D:
		if (this.ball2 == 0)
		{
			goto IL_1C6;
		}
		Vector3 position5 = this.ball2.position;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		result = position5;
		IL_1B9:
		return result != null;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000F10C File Offset: 0x0000D30C
	private void Update()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
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
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			bool flag = ~this.lost;
			object obj = !flag;
			object obj3;
			object obj2 = obj3;
			if (obj != null)
			{
				goto IL_F9;
			}
			bool flag2 = ~this.goalsReached;
			obj2 = obj3;
			if (!flag2)
			{
				goto IL_F9;
			}
			bool flag3 = this == 0;
			bool flag4 = this.InBounds();
			if (!flag3)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj4 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v132 @ X0_v17+E4]");
				bool flag5 = (IntPtr)0 == 0;
				if (flag5)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag6 = @object == 0;
				bool flag7 = this.catapultGoal != @object;
				object obj5 = !flag6;
				object obj6 = obj3;
				if (obj5 == null)
				{
					if (this.rb2 == 0)
					{
						goto IL_405;
					}
					Vector2 linearVelocity = this.rb2.linearVelocity;
					Console.WriteLine("Unmanaged memory load: [5592128]");
					bool flag8 = (IntPtr)0 == 0;
					if (flag8)
					{
						Console.WriteLine("Method not found @24D6540");
					}
					Console.WriteLine("Unmanaged memory load: [523AD40]");
					object obj7 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v219 @ X0_v25+E4]");
					bool flag9 = (IntPtr)0 == 0;
					if (flag9)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					object obj8 = obj3 * obj3;
					object obj10;
					object obj9 = obj10 * obj10;
					object obj11 = obj8 + obj9;
					Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					obj6 = obj11;
				}
				this.OnLose();
				obj2 = obj6;
				goto IL_F9;
			}
			if (this.ball2 != 0)
			{
				Vector3 position = this.ball2.position;
				object obj12 = (double)this.screenHeight * 0.5;
				object obj13 = obj12 + 3.0;
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				obj2 = obj13;
				goto IL_F9;
			}
			IL_405:
			Console.WriteLine("Method not found @24D67E8");
			continue;
			IL_F9:
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			TransitionAnimation transitionAnimation = this.transitionAnimation;
			if (this.transitionAnimation == 0)
			{
				goto IL_405;
			}
			bool flag10 = ~transitionAnimation.inTransition;
			if (!flag10)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			float num = this.speedrunTimer + obj2;
			this.speedrunTimer = num;
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			string text = GameManager.ReturnTimeTextMilliseconds(@object);
			if (this.speedrunTimerText != 0)
			{
				break;
			}
			goto IL_405;
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000F584 File Offset: 0x0000D784
	public GameManager()
	{
		Console.WriteLine("Unmanaged memory load: [523B1C0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B1D0]");
		object obj2 = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
		this.bottomBorder = (1L != 0L);
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor();
		this.affectedObstacles = obj;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D67D8");
		obj2..ctor();
		this.sliceableObjects = obj2;
		Console.WriteLine("Method not found @24D64EC");
		base..ctor();
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
	private void <OnEnable>b__77_0()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		object obj3;
		object obj4;
		for (;;)
		{
			if (this.soundManager != 0)
			{
				this.soundManager.PlayClickSound();
				this.Restart();
				if (!(~this.speedrun) || ~this.inGameAds)
				{
					break;
				}
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v92 @ X8_v4+B8]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AD60]");
				obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				Console.WriteLine("Unmanaged memory load: [523B1E0]");
				obj4 = (IntPtr)0;
				obj3..ctor(this, obj4);
				if (obj2 != 0)
				{
					goto Block_3;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_3:
		obj2.ShowInterstitial(obj3, obj4 != null);
	}

	// Token: 0x06000097 RID: 151 RVA: 0x0000F838 File Offset: 0x0000DA38
	private void <OnEnable>b__77_4()
	{
		this.Restart();
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000F84C File Offset: 0x0000DA4C
	private void <OnEnable>b__77_1()
	{
		/*
An exception occurred when decompiling this method (06000098)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::<OnEnable>b__77_1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_6E:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
	private void <OnEnable>b__77_2()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.soundManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				this.soundManager.PlayClickSound();
				this.Restart();
				Console.WriteLine("Unmanaged memory load: [v67 @ X8_v2+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523B190]");
					object obj3 = (IntPtr)0;
					Action postAdAction_;
					bool waitForTime;
					obj2.ShowInterstitial(postAdAction_, waitForTime);
					Console.WriteLine("Unmanaged memory load: [v75 @ X8_v4+B8]");
					object obj4 = (IntPtr)0;
					if (obj4 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523AE38]");
						object obj5 = (IntPtr)0;
						obj4.OpenStartPanel();
						Console.WriteLine("Unmanaged memory load: [v81 @ X8_v6+B8]");
						object obj6 = (IntPtr)0;
						if (obj6 != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000FA74 File Offset: 0x0000DC74
	private void <OnEnable>b__77_3()
	{
		/*
An exception occurred when decompiling this method (0600009A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::<OnEnable>b__77_3()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_4E:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x0600009B RID: 155 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
	private void <OnLose>b__86_0()
	{
		this.Restart();
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000FAEC File Offset: 0x0000DCEC
	private void <Update>b__89_0()
	{
		/*
An exception occurred when decompiling this method (0600009C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::<Update>b__89_0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_2E:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000FB38 File Offset: 0x0000DD38
	private void <Update>b__89_1()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		object obj3;
		object obj4;
		for (;;)
		{
			this.Restart();
			if (this.levelManager != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ACC8]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AD60]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B208]");
				obj3 = (IntPtr)0;
				this.levelManager.SetProgress();
				Console.WriteLine("Unmanaged memory load: [v57 @ X8_v2+B8]");
				obj4 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(this, obj3);
				if (obj4 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj4.ShowInterstitial(obj2, obj3 != null);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000FC84 File Offset: 0x0000DE84
	private void <Update>b__89_2()
	{
		/*
An exception occurred when decompiling this method (0600009E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager::<Update>b__89_2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_2B:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x04000066 RID: 102
	public static GameManager Instance;

	// Token: 0x04000067 RID: 103
	public Transform ball1;

	// Token: 0x04000068 RID: 104
	public Transform ball2;

	// Token: 0x04000069 RID: 105
	public BallScript ball1Script;

	// Token: 0x0400006A RID: 106
	public BallScript ball2Script;

	// Token: 0x0400006B RID: 107
	public ExpressionManager expression1;

	// Token: 0x0400006C RID: 108
	public ExpressionManager expression2;

	// Token: 0x0400006D RID: 109
	public Rigidbody2D rb1;

	// Token: 0x0400006E RID: 110
	public Rigidbody2D rb2;

	// Token: 0x0400006F RID: 111
	public Vector3 startPos1;

	// Token: 0x04000070 RID: 112
	public Vector3 startPos2;

	// Token: 0x04000071 RID: 113
	public float startScale1;

	// Token: 0x04000072 RID: 114
	public float startScale2;

	// Token: 0x04000073 RID: 115
	public PlayerManager playerManager;

	// Token: 0x04000074 RID: 116
	public Transform startMark;

	// Token: 0x04000075 RID: 117
	public GameObject startPlatform;

	// Token: 0x04000076 RID: 118
	public SpriteRenderer startPlatformSprite;

	// Token: 0x04000077 RID: 119
	public Collider2D startPlatformColider;

	// Token: 0x04000078 RID: 120
	public float platformTimer;

	// Token: 0x04000079 RID: 121
	public SpriteRenderer startMarkSprite;

	// Token: 0x0400007A RID: 122
	public bool started;

	// Token: 0x0400007B RID: 123
	public Button restartButton;

	// Token: 0x0400007C RID: 124
	public bool lost;

	// Token: 0x0400007D RID: 125
	public List<GoalObject> goalObjects;

	// Token: 0x0400007E RID: 126
	public List<ObstacleObject> obstacleObjects;

	// Token: 0x0400007F RID: 127
	public List<GameObject> activateOnStart;

	// Token: 0x04000080 RID: 128
	public List<GameObject> deactivateOnStart;

	// Token: 0x04000081 RID: 129
	public GameObject RestartPanel;

	// Token: 0x04000082 RID: 130
	public Button restartButton2;

	// Token: 0x04000083 RID: 131
	public Text endlessTimerText;

	// Token: 0x04000084 RID: 132
	public bool endless;

	// Token: 0x04000085 RID: 133
	public Button backButton;

	// Token: 0x04000086 RID: 134
	public Level currentLevel;

	// Token: 0x04000087 RID: 135
	public BounceGoal bounceGoal;

	// Token: 0x04000088 RID: 136
	public CatapultGoal catapultGoal;

	// Token: 0x04000089 RID: 137
	public float bounceIntensity;

	// Token: 0x0400008A RID: 138
	public float catapultIntensity;

	// Token: 0x0400008B RID: 139
	public TransitionAnimation transitionAnimation;

	// Token: 0x0400008C RID: 140
	public LevelManager levelManager;

	// Token: 0x0400008D RID: 141
	public bool goalsReached;

	// Token: 0x0400008E RID: 142
	public float nextLevelTimer;

	// Token: 0x0400008F RID: 143
	public GameObject solvedText;

	// Token: 0x04000090 RID: 144
	public float currentGravityScale;

	// Token: 0x04000091 RID: 145
	public float nextLevelTime;

	// Token: 0x04000092 RID: 146
	public float nextLevelTimeSpeedrun;

	// Token: 0x04000093 RID: 147
	public float screenWidth;

	// Token: 0x04000094 RID: 148
	public float screenHeight;

	// Token: 0x04000095 RID: 149
	public bool speedrun;

	// Token: 0x04000096 RID: 150
	public float speedrunTimer;

	// Token: 0x04000097 RID: 151
	public TextMeshPro speedrunTimerText;

	// Token: 0x04000098 RID: 152
	public GameObject SpeedrunCompletedPanel;

	// Token: 0x04000099 RID: 153
	public Text speedrunCompletedTimerText;

	// Token: 0x0400009A RID: 154
	public Color hoopNormalColor;

	// Token: 0x0400009B RID: 155
	public Color hoopSolvedColor;

	// Token: 0x0400009C RID: 156
	public Button hintButton;

	// Token: 0x0400009D RID: 157
	public bool leftBorder;

	// Token: 0x0400009E RID: 158
	public bool rightBorder;

	// Token: 0x0400009F RID: 159
	public bool bottomBorder;

	// Token: 0x040000A0 RID: 160
	public bool topBorder;

	// Token: 0x040000A1 RID: 161
	public bool inGameAds;

	// Token: 0x040000A2 RID: 162
	public float reviewTime;

	// Token: 0x040000A3 RID: 163
	public Color spikeRedColor;

	// Token: 0x040000A4 RID: 164
	public Transform leftBorderTransform;

	// Token: 0x040000A5 RID: 165
	public Transform rightBorderTransform;

	// Token: 0x040000A6 RID: 166
	public Transform solvedBadge;

	// Token: 0x040000A7 RID: 167
	public SoundManager soundManager;

	// Token: 0x040000A8 RID: 168
	public bool gameFocused;

	// Token: 0x040000A9 RID: 169
	public List<ObstacleObject> affectedObstacles;

	// Token: 0x040000AA RID: 170
	public List<SliceableObject> sliceableObjects;

	// Token: 0x040000AB RID: 171
	public float loseTimer;

	// Token: 0x02000080 RID: 128
	private sealed class <ShowTutorial>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00042878 File Offset: 0x00040A78
		public <ShowTutorial>d__80(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000040B5 File Offset: 0x000022B5
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000428A4 File Offset: 0x00040AA4
		bool IEnumerator.MoveNext()
		{
			bool flag = this == 0;
			GameManager.<ShowTutorial>d__80 <ShowTutorial>d__ = this;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				GameManager.<ShowTutorial>d__80 <ShowTutorial>d__2;
				<ShowTutorial>d__ = <ShowTutorial>d__2;
			}
			Level currentLevel;
			for (;;)
			{
				GameManager gameManager = this.<>4__this;
				if (this.<>1__state != 0)
				{
					goto Block_5;
				}
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				if (this.<>4__this != 0)
				{
					currentLevel = gameManager.currentLevel;
					if (gameManager.currentLevel != 0 && currentLevel.tutorial != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			bool active;
			currentLevel.tutorial.SetActive(active);
			Console.WriteLine("Method not found @24D67D8");
			WaitForSeconds waitForSeconds;
			float seconds;
			waitForSeconds..ctor(seconds);
			this.<>2__current = waitForSeconds;
			Console.WriteLine("Method not found @24D64EC");
			bool flag2;
			bool result = flag2;
			goto IL_18C;
			Block_5:
			result = (<ShowTutorial>d__ != null);
			IL_18C:
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			return result;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00042A4C File Offset: 0x00040C4C
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00042A60 File Offset: 0x00040C60
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000348)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GameManager/<ShowTutorial>d__80::System.Collections.IEnumerator.Reset()

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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00042AC4 File Offset: 0x00040CC4
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x040003EB RID: 1003
		private int <>1__state;

		// Token: 0x040003EC RID: 1004
		private object <>2__current;

		// Token: 0x040003ED RID: 1005
		public GameManager <>4__this;
	}
}
