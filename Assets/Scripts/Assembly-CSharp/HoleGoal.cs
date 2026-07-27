using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000019 RID: 25
public class HoleGoal : GoalObject
{
	// Token: 0x060000B7 RID: 183 RVA: 0x00003FD1 File Offset: 0x000021D1
	private void Start()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00010C8C File Offset: 0x0000EE8C
	public override void Restart()
	{
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
		this.timer = this.goalTime;
		Transform transform = base.transform;
		if (transform != 0)
		{
			Vector3 localScale = transform.localScale;
			float num = (float)((double)this.goalTime * 0.5);
			this.radius = num;
			Console.WriteLine("Unmanaged memory load: [559212F]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D6540");
				goto IL_124;
			}
			goto IL_124;
		}
		IL_11A:
		Console.WriteLine("Method not found @24D67E8");
		IL_124:
		if (this.rbBall == 0)
		{
			goto IL_11A;
		}
		Vector2 vector;
		this.rbBall.linearVelocity = vector;
		if (this.shadow != 0)
		{
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			this.shadow.color = vector;
			return;
		}
		goto IL_11A;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00010DDC File Offset: 0x0000EFDC
	public override void OnGoal()
	{
		base.OnGoal();
		float transitionTime;
		float shadowTime;
		IEnumerator routine = this.TakeTheBall(transitionTime, shadowTime);
		base.StartCoroutine(routine);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00010E1C File Offset: 0x0000F01C
	public IEnumerator TakeTheBall(float transitionTime, float shadowTime)
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

	// Token: 0x060000BB RID: 187 RVA: 0x00010EC0 File Offset: 0x0000F0C0
	private void Update()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (HoleGoal)+21]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Unmanaged memory load: [this @ X0 (HoleGoal)+20]");
			if ((IntPtr)0 == 0)
			{
				if (this.ball != 0)
				{
					Vector3 position = this.ball.position;
					Transform transform = base.transform;
					if (transform != 0)
					{
						Vector3 position2 = transform.position;
						Console.WriteLine("Unmanaged memory load: [5592130]");
						bool flag = (IntPtr)0 == 0;
						if (flag)
						{
							Console.WriteLine("Method not found @24D6540");
							goto IL_15D;
						}
						goto IL_15D;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
				IL_15D:
				Console.WriteLine("Unmanaged memory load: [523AD40]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v45 @ X0_v10+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			}
		}
	}

	// Token: 0x040000C5 RID: 197
	public Transform ball;

	// Token: 0x040000C6 RID: 198
	public Rigidbody2D rbBall;

	// Token: 0x040000C7 RID: 199
	public SpriteRenderer spriteRenderer;

	// Token: 0x040000C8 RID: 200
	public float timer;

	// Token: 0x040000C9 RID: 201
	public float goalTime;

	// Token: 0x040000CA RID: 202
	public float radius;

	// Token: 0x040000CB RID: 203
	public SpriteRenderer shadow;

	// Token: 0x02000081 RID: 129
	private sealed class <TakeTheBall>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600034A RID: 842 RVA: 0x00042AD8 File Offset: 0x00040CD8
		public <TakeTheBall>d__10(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000040B7 File Offset: 0x000022B7
		void IDisposable.Dispose()
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00042B04 File Offset: 0x00040D04
		bool IEnumerator.MoveNext()
		{
			HoleGoal holeGoal = this.<>4__this;
			int num = (int)(~(int)0L);
			this.<>1__state = num;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			if (this.<>4__this != 0 && ~(holeGoal.shadow != null) == null)
			{
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				Color color;
				holeGoal.shadow.color = color;
			}
			else
			{
				Console.WriteLine("Method not found @24D67E8");
			}
			return holeGoal.shadow != null;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00042BE8 File Offset: 0x00040DE8
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00042BFC File Offset: 0x00040DFC
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (0600034E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void HoleGoal/<TakeTheBall>d__10::System.Collections.IEnumerator.Reset()

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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00042C60 File Offset: 0x00040E60
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x040003EE RID: 1006
		private int <>1__state;

		// Token: 0x040003EF RID: 1007
		private object <>2__current;

		// Token: 0x040003F0 RID: 1008
		public HoleGoal <>4__this;

		// Token: 0x040003F1 RID: 1009
		public float transitionTime;

		// Token: 0x040003F2 RID: 1010
		public float shadowTime;

		// Token: 0x040003F3 RID: 1011
		private Vector3 <startPos>5__2;

		// Token: 0x040003F4 RID: 1012
		private float <time>5__3;
	}
}
