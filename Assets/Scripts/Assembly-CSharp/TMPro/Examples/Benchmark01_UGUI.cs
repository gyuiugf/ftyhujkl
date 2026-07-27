using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro.Examples
{
	// Token: 0x0200005D RID: 93
	public class Benchmark01_UGUI : MonoBehaviour
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0003569C File Offset: 0x0003389C
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

		// Token: 0x0400031F RID: 799
		public int BenchmarkType;

		// Token: 0x04000320 RID: 800
		public Canvas canvas;

		// Token: 0x04000321 RID: 801
		public TMP_FontAsset TMProFont;

		// Token: 0x04000322 RID: 802
		public Font TextMeshFont;

		// Token: 0x04000323 RID: 803
		private TextMeshProUGUI m_textMeshPro;

		// Token: 0x04000324 RID: 804
		private Text m_textMesh;

		// Token: 0x04000325 RID: 805
		private const string label01 = "The <#0050FF>count is: </color>";

		// Token: 0x04000326 RID: 806
		private const string label02 = "The <color=#0050FF>count is: </color>";

		// Token: 0x04000327 RID: 807
		private Material m_material01;

		// Token: 0x04000328 RID: 808
		private Material m_material02;

		// Token: 0x0200009C RID: 156
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003AE RID: 942 RVA: 0x00044EEC File Offset: 0x000430EC
			public <Start>d__10(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003AF RID: 943 RVA: 0x000040D5 File Offset: 0x000022D5
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00044F18 File Offset: 0x00043118
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
					bool flag2;
					result = flag2;
				}
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				return result;
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x00045010 File Offset: 0x00043210
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00045024 File Offset: 0x00043224
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.Benchmark01_UGUI/<Start>d__10::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x00045088 File Offset: 0x00043288
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04000455 RID: 1109
			private int <>1__state;

			// Token: 0x04000456 RID: 1110
			private object <>2__current;

			// Token: 0x04000457 RID: 1111
			public Benchmark01_UGUI <>4__this;

			// Token: 0x04000458 RID: 1112
			private int <i>5__2;
		}
	}
}
