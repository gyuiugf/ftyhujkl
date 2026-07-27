using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000072 RID: 114
	public class VertexColorCycler : MonoBehaviour
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0003CCCC File Offset: 0x0003AECC
		private void Awake()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Method not found @2894080");
			this.m_TextComponent = this;
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0003CD48 File Offset: 0x0003AF48
		private void Start()
		{
			IEnumerator routine = this.AnimateVertexColors();
			base.StartCoroutine(routine);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0003CD78 File Offset: 0x0003AF78
		private IEnumerator AnimateVertexColors()
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

		// Token: 0x040003AE RID: 942
		private TMP_Text m_TextComponent;

		// Token: 0x020000AB RID: 171
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003DE RID: 990 RVA: 0x00046410 File Offset: 0x00044610
			public <AnimateVertexColors>d__3(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003DF RID: 991 RVA: 0x000040E5 File Offset: 0x000022E5
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x0004643C File Offset: 0x0004463C
			bool IEnumerator.MoveNext()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				for (;;)
				{
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					TMP_TextInfo tmp_TextInfo = this.<textInfo>5__2;
					if (this.<textInfo>5__2 == 0)
					{
						goto IL_103;
					}
					if (tmp_TextInfo.characterCount == 0)
					{
						break;
					}
					if (tmp_TextInfo.characterInfo == 0)
					{
						goto IL_103;
					}
					IL_112:
					Console.WriteLine("Method not found @24D67F0");
					continue;
					IL_103:
					Console.WriteLine("Method not found @24D67E8");
					goto IL_112;
				}
				Console.WriteLine("Method not found @24D67D8");
				WaitForSeconds waitForSeconds;
				float seconds;
				waitForSeconds..ctor(seconds);
				this.<>2__current = waitForSeconds;
				Console.WriteLine("Method not found @24D64EC");
				this.<>1__state = (int)1L;
				bool result;
				return result;
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x000465AC File Offset: 0x000447AC
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x000465C0 File Offset: 0x000447C0
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.VertexColorCycler/<AnimateVertexColors>d__3::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00046624 File Offset: 0x00044824
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040004A9 RID: 1193
			private int <>1__state;

			// Token: 0x040004AA RID: 1194
			private object <>2__current;

			// Token: 0x040004AB RID: 1195
			public VertexColorCycler <>4__this;

			// Token: 0x040004AC RID: 1196
			private TMP_TextInfo <textInfo>5__2;

			// Token: 0x040004AD RID: 1197
			private int <currentCharacter>5__3;
		}
	}
}
