using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200003D RID: 61
public class SizeChanger : ObstacleObject
{
	// Token: 0x0600019B RID: 411 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
	public override void Restart()
	{
		Coroutine coroutine;
		IntPtr ptr;
		coroutine.m_Ptr = ptr;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			object obj = this + 88L;
			if (obj != 0)
			{
				base.StopCoroutine(obj);
				this.courutine1 = coroutine;
				Console.WriteLine("Method not found @24D64EC");
			}
			object obj2 = this + 96L;
			bool flag = obj2 == 0;
			int index = obj2;
			if (!flag)
			{
				base.StopCoroutine(obj2);
				this.courutine2 = coroutine;
				Console.WriteLine("Method not found @24D64EC");
				index = coroutine;
			}
			int num;
			this.nextChangeIndex = num;
			if (this.sizeChanges != 0)
			{
				object obj3 = this.sizeChanges.get_Item(index);
				this.nextChange = obj3;
				Console.WriteLine("Method not found @24D64EC");
				if (this != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [this @ X0 (SizeChanger)+21]");
		object obj4 = (IntPtr)0 ^ 1;
		Console.WriteLine("Unmanaged memory load: [v69 @ X8_v4+10]");
		this.timer = (float)((IntPtr)0);
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0001F6AC File Offset: 0x0001D8AC
	public void ApplyChange(SizeChange change)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (change != 0)
			{
				bool flag = ~change.ball1;
				SizeChange sizeChange = change;
				float startScale;
				float endScale;
				float transitionTime;
				if (!flag)
				{
					if (this.ball1 == 0)
					{
						goto IL_2E7;
					}
					Transform transform = this.ball1.transform;
					if (transform == 0)
					{
						goto IL_2E7;
					}
					Vector3 localScale = transform.localScale;
					IEnumerator routine = this.StartChange(this.ball1, startScale, endScale, transitionTime);
					Coroutine coroutine = base.StartCoroutine(routine);
					this.courutine1 = coroutine;
					Console.WriteLine("Method not found @24D64EC");
					sizeChange = coroutine;
				}
				bool flag2 = ~change.ball2;
				int index = sizeChange;
				if (!flag2)
				{
					if (this.ball2 == 0)
					{
						goto IL_2E7;
					}
					Transform transform2 = this.ball2.transform;
					if (transform2 == 0)
					{
						goto IL_2E7;
					}
					Vector3 localScale2 = transform2.localScale;
					IEnumerator routine2 = this.StartChange(this.ball2, startScale, endScale, transitionTime);
					Coroutine coroutine2 = base.StartCoroutine(routine2);
					this.courutine2 = coroutine2;
					Console.WriteLine("Method not found @24D64EC");
					index = coroutine2;
				}
				if (!(~this.loop))
				{
					bool flag3 = this.sizeChanges == 0;
					if (!flag3)
					{
						Console.WriteLine("Not implemented instruction: Instruction SDIV not yet implemented.");
						Console.WriteLine("Not implemented instruction: Instruction MSUB not yet implemented.");
						int num;
						this.nextChangeIndex = num;
						object obj = this.sizeChanges.get_Item(index);
						this.nextChange = obj;
						Console.WriteLine("Method not found @24D64EC");
						if (this != 0)
						{
							goto Block_11;
						}
					}
				}
				else if (this.sizeChanges != 0)
				{
					break;
				}
			}
			IL_2E7:
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_11:
		Console.WriteLine("Unmanaged memory load: [v31 @ X8_v2+10]");
		this.timer = (float)((IntPtr)0);
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
	public IEnumerator StartChange(Transform ball, float startScale, float endScale, float transitionTime)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		object obj;
		obj..ctor();
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D64EC");
		return obj;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0000404F File Offset: 0x0000224F
	private void Start()
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0001FA88 File Offset: 0x0001DC88
	private void Update()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (SizeChanger)+20]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}
	}

	// Token: 0x040001AD RID: 429
	public Transform ball1;

	// Token: 0x040001AE RID: 430
	public Transform ball2;

	// Token: 0x040001AF RID: 431
	public float timer;

	// Token: 0x040001B0 RID: 432
	public float time;

	// Token: 0x040001B1 RID: 433
	public List<SizeChange> sizeChanges;

	// Token: 0x040001B2 RID: 434
	public SizeChange nextChange;

	// Token: 0x040001B3 RID: 435
	public int nextChangeIndex;

	// Token: 0x040001B4 RID: 436
	public bool loop;

	// Token: 0x040001B5 RID: 437
	public Coroutine courutine1;

	// Token: 0x040001B6 RID: 438
	public Coroutine courutine2;

	// Token: 0x02000088 RID: 136
	private sealed class <StartChange>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600036D RID: 877 RVA: 0x00043640 File Offset: 0x00041840
		public <StartChange>d__12(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000040C3 File Offset: 0x000022C3
		void IDisposable.Dispose()
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0004366C File Offset: 0x0004186C
		bool IEnumerator.MoveNext()
		{
			object obj;
			Coroutine coroutine = obj - 80L;
			IntPtr ptr;
			coroutine.m_Ptr = ptr;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			SizeChanger sizeChanger;
			for (;;)
			{
				sizeChanger = this.<>4__this;
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				if (this.<>4__this != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v46 @ X0_v6+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag2 = coroutine == 0;
			bool flag3 = this.ball == sizeChanger.ball1;
			if (flag2)
			{
				sizeChanger.courutine1 = coroutine;
				Console.WriteLine("Method not found @24D64EC");
			}
			Console.WriteLine("Unmanaged memory load: [v107 @ X0_v14+E4]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag5 = coroutine == 0;
			bool flag6 = this.ball == sizeChanger.ball2;
			object obj3 = !flag5;
			obj3;
			sizeChanger.courutine2 = coroutine;
			Console.WriteLine("Method not found @24D64EC");
			bool result;
			return result;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000438CC File Offset: 0x00041ACC
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000438E0 File Offset: 0x00041AE0
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000371)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SizeChanger/<StartChange>d__12::System.Collections.IEnumerator.Reset()

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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00043944 File Offset: 0x00041B44
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x0400040B RID: 1035
		private int <>1__state;

		// Token: 0x0400040C RID: 1036
		private object <>2__current;

		// Token: 0x0400040D RID: 1037
		public float transitionTime;

		// Token: 0x0400040E RID: 1038
		public Transform ball;

		// Token: 0x0400040F RID: 1039
		public float startScale;

		// Token: 0x04000410 RID: 1040
		public float endScale;

		// Token: 0x04000411 RID: 1041
		public SizeChanger <>4__this;

		// Token: 0x04000412 RID: 1042
		private float <time>5__2;
	}
}
