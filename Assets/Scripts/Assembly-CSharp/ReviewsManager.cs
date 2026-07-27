using System;
using System.Collections;
using System.Collections.Generic;
using Google.Play.Common;
using Google.Play.Review;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class ReviewsManager : MonoBehaviour
{
	// Token: 0x0600017A RID: 378 RVA: 0x0001DD40 File Offset: 0x0001BF40
	public void RequestReview()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B5C0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor();
		this._reviewManager = obj;
		Console.WriteLine("Method not found @24D64EC");
		IEnumerator routine = this.LaunchReview();
		base.StartCoroutine(routine);
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
	private IEnumerator LaunchReview()
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

	// Token: 0x0600017C RID: 380 RVA: 0x0001DE88 File Offset: 0x0001C088
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B5D0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000403D File Offset: 0x0000223D
	private void Start()
	{
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000403F File Offset: 0x0000223F
	private void Update()
	{
	}

	// Token: 0x04000194 RID: 404
	public static ReviewsManager Instance;

	// Token: 0x04000195 RID: 405
	private ReviewManager _reviewManager;

	// Token: 0x02000087 RID: 135
	private sealed class <LaunchReview>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000367 RID: 871 RVA: 0x000434E4 File Offset: 0x000416E4
		public <LaunchReview>d__3(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000040C1 File Offset: 0x000022C1
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00043510 File Offset: 0x00041710
		bool IEnumerator.MoveNext()
		{
			bool flag = this == 0;
			bool result = this != null;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				bool flag2;
				result = flag2;
			}
			int num = (int)(~(int)0L);
			this.<>1__state = num;
			return result;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000435B4 File Offset: 0x000417B4
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000435C8 File Offset: 0x000417C8
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (0600036B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ReviewsManager/<LaunchReview>d__3::System.Collections.IEnumerator.Reset()

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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0004362C File Offset: 0x0004182C
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000407 RID: 1031
		private int <>1__state;

		// Token: 0x04000408 RID: 1032
		private object <>2__current;

		// Token: 0x04000409 RID: 1033
		public ReviewsManager <>4__this;

		// Token: 0x0400040A RID: 1034
		private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> <requestFlowOperation>5__2;
	}
}
