using System;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class PopAnimation : MonoBehaviour
{
	// Token: 0x06000171 RID: 369 RVA: 0x00004035 File Offset: 0x00002235
	private void Awake()
	{
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
	public void PlayPopAnimation()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		bool flag2;
		for (;;)
		{
			bool flag = ~this.popped;
			if (!flag)
			{
				return;
			}
			Console.WriteLine("Unmanaged memory load: [523AE28]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v26 @ X8_v4+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				obj2.PlayPopSound();
				if (this.popObject != 0)
				{
					this.popObject.SetActive(flag2);
					if (this.normalObject != 0)
					{
						this.normalObject.SetActive(flag2);
						if (this.popAnimator != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		this.popAnimator.enabled = flag2;
		this.popped = (1L != 0L);
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0001DA60 File Offset: 0x0001BC60
	public void DeactivatePopAnimation()
	{
		/*
An exception occurred when decompiling this method (06000173)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void PopAnimation::DeactivatePopAnimation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_71:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00004037 File Offset: 0x00002237
	private void Start()
	{
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00004039 File Offset: 0x00002239
	private void Update()
	{
	}

	// Token: 0x04000190 RID: 400
	public GameObject popObject;

	// Token: 0x04000191 RID: 401
	public GameObject normalObject;

	// Token: 0x04000192 RID: 402
	public Animator popAnimator;

	// Token: 0x04000193 RID: 403
	private bool popped;
}
