using System;
using TMPro;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class CircleGoal : GoalObject
{
	// Token: 0x06000043 RID: 67 RVA: 0x00007708 File Offset: 0x00005908
	public override void Restart()
	{
		/*
An exception occurred when decompiling this method (06000043)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CircleGoal::Restart()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_108:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00007828 File Offset: 0x00005A28
	public void OnCircle()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (CircleGoal)+21]");
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

	// Token: 0x06000045 RID: 69 RVA: 0x00003FA8 File Offset: 0x000021A8
	private void Start()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0000790C File Offset: 0x00005B0C
	private void Update()
	{
		if (this.ball1 != 0)
		{
			Vector3 position = this.ball1.position;
			if (this.ball2 != 0)
			{
				Vector3 position2 = this.ball2.position;
				object obj2;
				object obj = obj2 - obj2;
				Console.WriteLine("Method not found @4F26550");
				float num = obj;
				Console.WriteLine("Unmanaged memory load: [DBDEA0]");
				float num2 = (float)((IntPtr)num * (IntPtr)0);
				object obj3 = num2 - this.previousAngle;
				Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FRINTM not yet implemented.");
				object obj5;
				object obj4 = obj5 * 3283353600L;
				object obj6 = obj3 + obj4;
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
				bool flag = this.totalRotation + obj6 != null;
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				this.previousAngle = num2;
				this.exact = flag;
				goto IL_18A;
			}
		}
		Console.WriteLine("Method not found @24D67E8");
		IL_18A:
		Console.WriteLine("Not implemented instruction: Instruction FNEG not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		float num3 = (float)(1135869952L - (long)this.circleIntensity);
		this.totalRotation = num3;
		this.OnCircle();
	}

	// Token: 0x04000033 RID: 51
	public int circleCount;

	// Token: 0x04000034 RID: 52
	public int circleGoal;

	// Token: 0x04000035 RID: 53
	public TextMeshPro circleText;

	// Token: 0x04000036 RID: 54
	public float circleIntensity;

	// Token: 0x04000037 RID: 55
	public Transform ball1;

	// Token: 0x04000038 RID: 56
	public Transform ball2;

	// Token: 0x04000039 RID: 57
	private float previousAngle;

	// Token: 0x0400003A RID: 58
	private float totalRotation;

	// Token: 0x0400003B RID: 59
	public bool exact;
}
