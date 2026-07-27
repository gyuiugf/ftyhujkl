using System;
using TMPro;
using UnityEngine;

// Token: 0x02000049 RID: 73
public class TimeGoal : GoalObject
{
	// Token: 0x060001E5 RID: 485 RVA: 0x00022EA8 File Offset: 0x000210A8
	public override void Restart()
	{
		/*
An exception occurred when decompiling this method (060001E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TimeGoal::Restart()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_83:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x060001E6 RID: 486 RVA: 0x00022F44 File Offset: 0x00021144
	public override void OnFail()
	{
		base.OnFail();
		if (!(~this.endless))
		{
			this.loseTimer = 1f;
		}
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000406B File Offset: 0x0000226B
	private void Start()
	{
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00022F8C File Offset: 0x0002118C
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [this @ X0 (TimeGoal)+21]");
			if ((IntPtr)0 == 0)
			{
				return;
			}
			Console.WriteLine("Unmanaged memory load: [this @ X0 (TimeGoal)+20]");
			bool flag = (IntPtr)0 == 0;
			if (!flag)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			object obj;
			float num = this.gameTimer + obj;
			this.gameTimer = num;
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			long time_;
			string text = GameManager.ReturnTimeTextMilliseconds(time_);
			if (this.timerText != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
		bool flag2 = ~this.endless;
		if (flag2)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}
	}

	// Token: 0x040001FB RID: 507
	public TextMeshPro timerText;

	// Token: 0x040001FC RID: 508
	public float gameTimer;

	// Token: 0x040001FD RID: 509
	public float goalTime;

	// Token: 0x040001FE RID: 510
	public bool endless;

	// Token: 0x040001FF RID: 511
	public float loseTimer;
}
