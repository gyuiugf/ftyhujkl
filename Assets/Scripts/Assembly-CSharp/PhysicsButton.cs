using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000031 RID: 49
public class PhysicsButton : ObstacleObject
{
	// Token: 0x06000150 RID: 336 RVA: 0x0001B104 File Offset: 0x00019304
	public override void Restart()
	{
		/*
An exception occurred when decompiling this method (06000150)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void PhysicsButton::Restart()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_1BC:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); 	call:void(Console::WriteLine, ldstr:string("Method not found @21483AC")); 	call:void(Console::WriteLine, ldstr:string("Method not found @25C617C")); 	call:void(Console::WriteLine, ldstr:string("Method not found @21483A0")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0001B3A4 File Offset: 0x000195A4
	private void OnCollisionEnter2D(Collision2D other)
	{
		object obj2;
		object obj = obj2 - 80L;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0001B468 File Offset: 0x00019668
	private void OnTriggerEnter2D(Collider2D other)
	{
		object obj2;
		object obj = obj2 - 80L;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x06000153 RID: 339 RVA: 0x0000401F File Offset: 0x0000221F
	private void Start()
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0001B52C File Offset: 0x0001972C
	private void Update()
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x04000174 RID: 372
	public List<ObstacleObject> obstacleObjects;

	// Token: 0x04000175 RID: 373
	public Animator anim;

	// Token: 0x04000176 RID: 374
	public bool pressedOnStart;

	// Token: 0x04000177 RID: 375
	public bool isPressed;

	// Token: 0x04000178 RID: 376
	public Vector3 normalPosition;

	// Token: 0x04000179 RID: 377
	public Vector3 pressedPosition;

	// Token: 0x0400017A RID: 378
	public float cooldownTimer;
}
