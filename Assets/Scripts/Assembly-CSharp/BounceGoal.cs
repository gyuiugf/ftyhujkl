using System;
using TMPro;

// Token: 0x02000006 RID: 6
public class BounceGoal : GoalObject
{
	// Token: 0x06000031 RID: 49 RVA: 0x00006AF8 File Offset: 0x00004CF8
	public override void Restart()
	{
		/*
An exception occurred when decompiling this method (06000031)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BounceGoal::Restart()

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

	// Token: 0x06000032 RID: 50 RVA: 0x00006B84 File Offset: 0x00004D84
	private void OnEnable()
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
			Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Unmanaged memory load: [v40 @ X8_v5+B8]");
				object obj3 = (IntPtr)0;
				if (obj3 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		float num = this.bounceIntensity;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00006C7C File Offset: 0x00004E7C
	private void OnDisable()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE38]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v24 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v36 @ X0_v7+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				object obj4;
				bool flag3 = obj4 == 0;
				Console.WriteLine("Unmanaged memory load: [v28 @ X8_v3+120]");
				bool flag4 = (IntPtr)0 == this;
				if (!flag3)
				{
					return;
				}
				Console.WriteLine("Unmanaged memory load: [v91 @ X8_v5+B8]");
				object obj5 = (IntPtr)0;
				if (obj5 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00006E20 File Offset: 0x00005020
	public void OnBounce()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (BounceGoal)+21]");
		if ((IntPtr)0 != 0)
		{
			int num = this + 72L;
			int value = (int)((long)num.m_value + 1L);
			num.m_value = value;
			string text = num.ToString();
			Console.WriteLine("Unmanaged memory load: [v10 @ X0_v2 (System.Int32)+8]");
			if ((IntPtr)0 != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				if (!(~this.exact))
				{
				}
			}
			else
			{
				Console.WriteLine("Method not found @24D67E8");
			}
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003F96 File Offset: 0x00002196
	private void Start()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003F98 File Offset: 0x00002198
	private void Update()
	{
	}

	// Token: 0x04000023 RID: 35
	public int bounceCount;

	// Token: 0x04000024 RID: 36
	public int bounceGoal;

	// Token: 0x04000025 RID: 37
	public TextMeshPro bounceText;

	// Token: 0x04000026 RID: 38
	public float bounceIntensity;

	// Token: 0x04000027 RID: 39
	public bool exact;
}
