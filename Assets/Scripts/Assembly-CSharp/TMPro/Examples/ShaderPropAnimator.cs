using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000063 RID: 99
	public class ShaderPropAnimator : MonoBehaviour
	{
		// Token: 0x0600028F RID: 655 RVA: 0x000378E0 File Offset: 0x00035AE0
		private void Awake()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Method not found @2894080");
				this.m_Renderer = this;
				Console.WriteLine("Method not found @24D64EC");
				if (this != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Material material = base.material;
			this.m_Material = material;
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000379A4 File Offset: 0x00035BA4
		private void Start()
		{
			IEnumerator routine = this.AnimateProperties();
			base.StartCoroutine(routine);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000379D4 File Offset: 0x00035BD4
		private IEnumerator AnimateProperties()
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

		// Token: 0x04000359 RID: 857
		private Renderer m_Renderer;

		// Token: 0x0400035A RID: 858
		private Material m_Material;

		// Token: 0x0400035B RID: 859
		public AnimationCurve GlowCurve;

		// Token: 0x0400035C RID: 860
		public float m_frame;

		// Token: 0x020000A0 RID: 160
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003B4 RID: 948 RVA: 0x0004509C File Offset: 0x0004329C
			public <AnimateProperties>d__6(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x000040D7 File Offset: 0x000022D7
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x000450C8 File Offset: 0x000432C8
			bool IEnumerator.MoveNext()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				ShaderPropAnimator shaderPropAnimator;
				float value;
				for (;;)
				{
					shaderPropAnimator = this.<>4__this;
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					if (this.<>4__this != 0 && shaderPropAnimator.GlowCurve != 0)
					{
						float time;
						value = shaderPropAnimator.GlowCurve.Evaluate(time);
						Console.WriteLine("Unmanaged memory load: [v119 @ X0_v10+E4]");
						bool flag = (IntPtr)0 == 0;
						if (flag)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						if (shaderPropAnimator.m_Material != 0)
						{
							break;
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				int nameID;
				shaderPropAnimator.m_Material.SetFloat(nameID, value);
				float deltaTime = Time.deltaTime;
				float maxInclusive;
				float num2 = UnityEngine.Random.Range(deltaTime, maxInclusive);
				object frame = shaderPropAnimator.m_frame;
				Console.WriteLine("Unmanaged memory load: [DBDE8C]");
				object obj = frame * (IntPtr)0;
				float frame2 = shaderPropAnimator.m_frame + obj;
				shaderPropAnimator.m_frame = frame2;
				Console.WriteLine("Method not found @24D67D8");
				WaitForEndOfFrame waitForEndOfFrame;
				waitForEndOfFrame..ctor();
				this.<>2__current = waitForEndOfFrame;
				Console.WriteLine("Method not found @24D64EC");
				bool result;
				return result;
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00045300 File Offset: 0x00043500
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00045314 File Offset: 0x00043514
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.ShaderPropAnimator/<AnimateProperties>d__6::System.Collections.IEnumerator.Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67D8")); 	call:void(Console::WriteLine, ldstr:string("Unmanaged memory load: [523B230]")); 	call:void(NotSupportedException::.ctor, conv.i:native int[exp:NotSupportedException](ldc.i4:int32[exp:native int](0))); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D66AC")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00045378 File Offset: 0x00043578
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04000467 RID: 1127
			private int <>1__state;

			// Token: 0x04000468 RID: 1128
			private object <>2__current;

			// Token: 0x04000469 RID: 1129
			public ShaderPropAnimator <>4__this;
		}
	}
}
