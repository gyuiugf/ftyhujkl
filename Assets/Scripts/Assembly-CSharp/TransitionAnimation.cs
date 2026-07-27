using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200004B RID: 75
public class TransitionAnimation : MonoBehaviour
{
	// Token: 0x060001ED RID: 493 RVA: 0x0002365C File Offset: 0x0002185C
	public void DoTransition(Action action, float speedFactor)
	{
		this.TransitionAction = action;
		Console.WriteLine("Method not found @24D64EC");
		IEnumerator routine = this.PlayTransition(speedFactor);
		base.StartCoroutine(routine);
	}

	// Token: 0x060001EE RID: 494 RVA: 0x000236AC File Offset: 0x000218AC
	public IEnumerator PlayTransition(float speedFactor)
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

	// Token: 0x060001EF RID: 495 RVA: 0x00023744 File Offset: 0x00021944
	private void Start()
	{
		/*
An exception occurred when decompiling this method (060001EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TransitionAnimation::Start()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_14C:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000406F File Offset: 0x0000226F
	private void Update()
	{
	}

	// Token: 0x04000206 RID: 518
	public GameObject transitionObject;

	// Token: 0x04000207 RID: 519
	public Transform leftDoor;

	// Token: 0x04000208 RID: 520
	public Transform rightDoor;

	// Token: 0x04000209 RID: 521
	public float closedPosLeft;

	// Token: 0x0400020A RID: 522
	public float openedPosLeft;

	// Token: 0x0400020B RID: 523
	public float closedPosRight;

	// Token: 0x0400020C RID: 524
	public float openedPosRight;

	// Token: 0x0400020D RID: 525
	public Action TransitionAction;

	// Token: 0x0400020E RID: 526
	public float transitionTime;

	// Token: 0x0400020F RID: 527
	public bool inTransition;

	// Token: 0x0200008B RID: 139
	private sealed class <PlayTransition>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600037F RID: 895 RVA: 0x00043FE4 File Offset: 0x000421E4
		public <PlayTransition>d__11(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000040C9 File Offset: 0x000022C9
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00044010 File Offset: 0x00042210
		bool IEnumerator.MoveNext()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			TransitionAnimation transitionAnimation;
			for (;;)
			{
				transitionAnimation = this.<>4__this;
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				if (this.<>4__this != 0 && ~(transitionAnimation.transitionObject != null) == null)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			bool active;
			transitionAnimation.transitionObject.SetActive(active);
			bool inTransition;
			transitionAnimation.inTransition = inTransition;
			return transitionAnimation.transitionObject != null;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00044120 File Offset: 0x00042320
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00044134 File Offset: 0x00042334
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000383)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TransitionAnimation/<PlayTransition>d__11::System.Collections.IEnumerator.Reset()

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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00044198 File Offset: 0x00042398
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x0400041B RID: 1051
		private int <>1__state;

		// Token: 0x0400041C RID: 1052
		private object <>2__current;

		// Token: 0x0400041D RID: 1053
		public TransitionAnimation <>4__this;

		// Token: 0x0400041E RID: 1054
		public float speedFactor;

		// Token: 0x0400041F RID: 1055
		private Vector3 <pos>5__2;

		// Token: 0x04000420 RID: 1056
		private float <timer>5__3;
	}
}
