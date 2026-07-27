using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class EnemyScript : MonoBehaviour
{
	// Token: 0x06000048 RID: 72 RVA: 0x00007AD0 File Offset: 0x00005CD0
	public void StartAttack(Attack attack)
	{
		Vector3 position;
		if (this.ballScript != 0)
		{
			this.ballScript.Restart();
			Camera main = Camera.main;
			if (main != 0)
			{
				float orthographicSize = main.orthographicSize;
				if (attack != 0)
				{
					this.attackSide = attack.side;
					Transform transform = base.transform;
					if (transform != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
						transform.position = position;
						if (this.warningTransform != 0)
						{
							Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
							this.warningTransform.position = position;
							Console.WriteLine("Unmanaged memory load: [559212B]");
							bool flag = (IntPtr)0 == 0;
							if (flag)
							{
								Console.WriteLine("Method not found @24D6540");
							}
							Console.WriteLine("Unmanaged memory load: [523AE20]");
							object obj = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [v168 @ X8_v5+B8]");
							object obj2 = (IntPtr)0;
							Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
							Console.WriteLine("Unmanaged memory load: [v34 @ X8_v6+20]");
							object obj3 = (IntPtr)0 * (IntPtr)attack.speed;
							Console.WriteLine("Unmanaged memory load: [v34 @ X8_v6+18]");
							this.moveVector = (IntPtr)0;
							goto IL_1EF;
						}
					}
				}
			}
		}
		IL_1E5:
		Console.WriteLine("Method not found @24D67E8");
		IL_1EF:
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		this.startTimer = attack.startTime;
		if (this.warningTransform == 0)
		{
			goto IL_1E5;
		}
		GameObject gameObject = this.warningTransform.gameObject;
		if (gameObject == 0)
		{
			goto IL_1E5;
		}
		gameObject.SetActive(position != null);
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
		float num = (float)((double)attack.startTime + 1.0);
		this.attackTimer = num;
		GameObject gameObject2 = base.gameObject;
		if (gameObject2 != 0)
		{
			gameObject2.SetActive(position != null);
			return;
		}
		goto IL_1E5;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00007DB8 File Offset: 0x00005FB8
	public void Restart()
	{
		/*
An exception occurred when decompiling this method (06000049)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void EnemyScript::Restart()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_CB:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00007E9C File Offset: 0x0000609C
	public void ResetAnimations()
	{
		/*
An exception occurred when decompiling this method (0600004A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void EnemyScript::ResetAnimations()

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

	// Token: 0x0600004B RID: 75 RVA: 0x00007EE4 File Offset: 0x000060E4
	public bool IsInBorders()
	{
		Transform transform = base.transform;
		bool position;
		if (transform != 0)
		{
			position = (transform.position != null);
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
		}
		else
		{
			Console.WriteLine("Method not found @24D67E8");
		}
		return position;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003FAA File Offset: 0x000021AA
	private void Start()
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00007F60 File Offset: 0x00006160
	private void FixedUpdate()
	{
		/*
An exception occurred when decompiling this method (0600004D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void EnemyScript::FixedUpdate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_16B:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x0600004E RID: 78 RVA: 0x000080E4 File Offset: 0x000062E4
	private void Update()
	{
		if (!(~this.active))
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}
	}

	// Token: 0x0400003C RID: 60
	public Rigidbody2D rb;

	// Token: 0x0400003D RID: 61
	public Transform warningTransform;

	// Token: 0x0400003E RID: 62
	public bool active;

	// Token: 0x0400003F RID: 63
	public bool attackPhase;

	// Token: 0x04000040 RID: 64
	public float attackTimer;

	// Token: 0x04000041 RID: 65
	public Vector3 moveVector;

	// Token: 0x04000042 RID: 66
	public Side attackSide;

	// Token: 0x04000043 RID: 67
	public float startTimer;

	// Token: 0x04000044 RID: 68
	public BallScript ballScript;
}
