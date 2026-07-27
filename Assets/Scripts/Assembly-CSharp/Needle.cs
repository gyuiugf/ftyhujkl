using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002C RID: 44
public class Needle : ObstacleObject
{
	// Token: 0x06000139 RID: 313 RVA: 0x0001A014 File Offset: 0x00018214
	public override void Restart()
	{
		/*
An exception occurred when decompiling this method (06000139)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Needle::Restart()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_178:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0001A1A4 File Offset: 0x000183A4
	public override void OnSolved()
	{
		this.end = (1L != 0L);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0001A1C8 File Offset: 0x000183C8
	private void Start()
	{
		/*
An exception occurred when decompiling this method (0600013B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Needle::Start()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_8E:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0001A26C File Offset: 0x0001846C
	private void Update()
	{
		Vector3 vector;
		float z;
		vector.z = z;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Transform transform;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Needle)+20]");
			bool flag = (IntPtr)0 == 0;
			if (flag && ~this.end)
			{
				return;
			}
			bool flag2 = ~this.poking;
			if (!flag2)
			{
				goto IL_25F;
			}
			if (this.target != 0)
			{
				Vector3 position = this.target.position;
				if (this.tracker != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
					Vector3 position2 = this.tracker.position;
					float deltaTime = Time.deltaTime;
					ref float currentVelocity = this + 60L;
					float num2;
					float num3;
					float maxSpeed;
					float deltaTime2;
					float num = Mathf.SmoothDamp(deltaTime, num2, ref currentVelocity, num3, maxSpeed, deltaTime2);
					if (this.tracker != 0)
					{
						Vector3 position3 = this.tracker.position;
						if (this.tracker != 0)
						{
							Vector3 position4 = this.tracker.position;
							this.tracker.position = vector;
							transform = base.transform;
							if (this.tracker != 0)
							{
								Vector3 position5 = this.tracker.position;
								Transform transform2 = base.transform;
								if (transform2 != 0)
								{
									Vector3 position6 = transform2.position;
									Transform transform3 = base.transform;
									if (transform3 != 0)
									{
										Vector3 position7 = transform3.position;
										if (transform != 0)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		transform.position = vector;
		IL_25F:
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0001A524 File Offset: 0x00018724
	public IEnumerator Poke()
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

	// Token: 0x0600013E RID: 318 RVA: 0x0001A5B4 File Offset: 0x000187B4
	public Needle()
	{
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		this.smoothTime = (float)39322L;
		Console.WriteLine("Unmanaged memory load: [DC1E40]");
		this.minHeight = (float)((IntPtr)0);
		this.height = 4f;
		base..ctor();
	}

	// Token: 0x04000153 RID: 339
	public Transform target;

	// Token: 0x04000154 RID: 340
	public float attackInterval;

	// Token: 0x04000155 RID: 341
	public float attackTimer;

	// Token: 0x04000156 RID: 342
	public float smoothTime;

	// Token: 0x04000157 RID: 343
	private float velocityX;

	// Token: 0x04000158 RID: 344
	public Transform needleTop;

	// Token: 0x04000159 RID: 345
	public Transform tracker;

	// Token: 0x0400015A RID: 346
	private float needleOffset;

	// Token: 0x0400015B RID: 347
	private bool poking;

	// Token: 0x0400015C RID: 348
	public float pokeSpeed;

	// Token: 0x0400015D RID: 349
	private Coroutine pokeRoutine;

	// Token: 0x0400015E RID: 350
	public bool playOnStart;

	// Token: 0x0400015F RID: 351
	public float startTimer;

	// Token: 0x04000160 RID: 352
	public float startTime;

	// Token: 0x04000161 RID: 353
	public float minHeight;

	// Token: 0x04000162 RID: 354
	public float stayTime;

	// Token: 0x04000163 RID: 355
	public bool staticHit;

	// Token: 0x04000164 RID: 356
	public float height;

	// Token: 0x04000165 RID: 357
	public bool end;

	// Token: 0x02000083 RID: 131
	private sealed class <Poke>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00042EA8 File Offset: 0x000410A8
		public <Poke>d__23(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000040B9 File Offset: 0x000022B9
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00042ED4 File Offset: 0x000410D4
		bool IEnumerator.MoveNext()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Transform transform;
			for (;;)
			{
				Component component = this.<>4__this;
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				if (this.<>4__this != 0)
				{
					transform = this.<>4__this.transform;
					if (transform != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			bool position = transform.position != null;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [v31 @ X20_v2 (UnityEngine.Component)+30]");
			IntPtr intPtr = (IntPtr)0;
			return position;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0004300C File Offset: 0x0004120C
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00043020 File Offset: 0x00041220
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000356)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Needle/<Poke>d__23::System.Collections.IEnumerator.Reset()

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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00043084 File Offset: 0x00041284
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x040003F7 RID: 1015
		private int <>1__state;

		// Token: 0x040003F8 RID: 1016
		private object <>2__current;

		// Token: 0x040003F9 RID: 1017
		public Needle <>4__this;
	}
}
