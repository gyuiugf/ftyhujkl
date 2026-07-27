using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200005C RID: 92
	public class Benchmark01 : MonoBehaviour
	{
		// Token: 0x0600027C RID: 636 RVA: 0x000355F8 File Offset: 0x000337F8
		private IEnumerator Start()
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

		// Token: 0x04000315 RID: 789
		public int BenchmarkType;

		// Token: 0x04000316 RID: 790
		public TMP_FontAsset TMProFont;

		// Token: 0x04000317 RID: 791
		public Font TextMeshFont;

		// Token: 0x04000318 RID: 792
		private TextMeshPro m_textMeshPro;

		// Token: 0x04000319 RID: 793
		private TextContainer m_textContainer;

		// Token: 0x0400031A RID: 794
		private TextMesh m_textMesh;

		// Token: 0x0400031B RID: 795
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		// Token: 0x0400031C RID: 796
		private const string label02 = "The <color=#0050FF>count is: </color>";

		// Token: 0x0400031D RID: 797
		private Material m_material01;

		// Token: 0x0400031E RID: 798
		private Material m_material02;

		// Token: 0x0200009B RID: 155
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003A8 RID: 936 RVA: 0x00044D08 File Offset: 0x00042F08
			public <Start>d__10(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x000040D3 File Offset: 0x000022D3
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003AA RID: 938 RVA: 0x00044D34 File Offset: 0x00042F34
			bool IEnumerator.MoveNext()
			{
				bool flag = this == 0;
				bool result = this != null;
				if (!flag)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					bool flag2;
					result = flag2;
				}
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				return result;
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060003AB RID: 939 RVA: 0x00044E60 File Offset: 0x00043060
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00044E74 File Offset: 0x00043074
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.Benchmark01/<Start>d__10::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060003AD RID: 941 RVA: 0x00044ED8 File Offset: 0x000430D8
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04000451 RID: 1105
			private int <>1__state;

			// Token: 0x04000452 RID: 1106
			private object <>2__current;

			// Token: 0x04000453 RID: 1107
			public Benchmark01 <>4__this;

			// Token: 0x04000454 RID: 1108
			private int <i>5__2;
		}
	}
}
