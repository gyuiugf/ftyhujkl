using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class SliceableObject : MonoBehaviour
{
	// Token: 0x060001A1 RID: 417 RVA: 0x0001FAEC File Offset: 0x0001DCEC
	private void Awake()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @2894080");
		this.col = this;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0001FB68 File Offset: 0x0001DD68
	public void Reset()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		while (this.previousSigns == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
		this.previousSigns.Clear();
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0001FBF8 File Offset: 0x0001DDF8
	public List<Vector2> GetPoints()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			List<Vector2> list = this.pts;
			if (this.pts != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v23 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
				object obj = (IntPtr)0 + 1;
				Transform transform = base.transform;
				if (transform != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523B690]");
					object obj2 = (IntPtr)0;
					Vector3 position = transform.position;
					Console.WriteLine("Unmanaged memory load: [v23 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
					object obj3 = (IntPtr)0 + 1;
					Console.WriteLine("Unmanaged memory load: [v23 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
					if ((IntPtr)0 != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [v39 @ X9_v2+20]");
		object obj4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v89 @ X8_v3+C0]");
		object obj5 = (IntPtr)0;
		List<Vector2> list2 = this.pts;
		Console.WriteLine("Unmanaged memory load: [v64 @ X8_v4+70]");
		list2.AddWithResize((IntPtr)0);
		return this.pts;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0001FD9C File Offset: 0x0001DF9C
	public bool SideChanged(Vector2 A, Vector2 B, Laser laser)
	{
		/*
An exception occurred when decompiling this method (060001A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean SliceableObject::SideChanged(UnityEngine.Vector2,UnityEngine.Vector2,Laser)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_397:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); 	call:void(Console::WriteLine, ldstr:string("Method not found @21484CC")); 	call:void(Console::WriteLine, ldstr:string("Method not found @25C617C")); 	call:void(Console::WriteLine, ldstr:string("Method not found @21483A0")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x000201F0 File Offset: 0x0001E3F0
	private float SideOfLine(Vector2 A, Vector2 B, Vector2 P)
	{
		float result;
		return result;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0002020C File Offset: 0x0001E40C
	public SliceableObject()
	{
		Console.WriteLine("Unmanaged memory load: [523B6E0]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B6F0]");
		object obj2 = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor();
		this.previousSigns = obj;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D67D8");
		obj2..ctor(obj);
		this.pts = obj2;
		Console.WriteLine("Method not found @24D64EC");
		base..ctor();
	}

	// Token: 0x040001B7 RID: 439
	public Dictionary<Laser, int> previousSigns;

	// Token: 0x040001B8 RID: 440
	public Vector2 previousPosition;

	// Token: 0x040001B9 RID: 441
	private Collider2D col;

	// Token: 0x040001BA RID: 442
	public bool blocker;

	// Token: 0x040001BB RID: 443
	private readonly List<Vector2> pts;
}
