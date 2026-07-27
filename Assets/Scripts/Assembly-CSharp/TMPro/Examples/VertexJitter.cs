using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000073 RID: 115
	public class VertexJitter : MonoBehaviour
	{
		// Token: 0x060002DC RID: 732 RVA: 0x0003CE1C File Offset: 0x0003B01C
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

		// Token: 0x060002DD RID: 733 RVA: 0x0003CE98 File Offset: 0x0003B098
		private void OnEnable()
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523C068]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [523C070]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523C2B8]");
				object method = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v25 @ X0_v10+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v37 @ X0_v12+B8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(this, method);
				Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
				if ((IntPtr)0 != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
			((IntPtr)0).Add(obj2);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0003D01C File Offset: 0x0003B21C
		private void OnDisable()
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523C068]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [523C070]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523C2B8]");
				object method = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v25 @ X0_v10+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v37 @ X0_v12+B8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(this, method);
				Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
				if ((IntPtr)0 != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
			((IntPtr)0).Remove(obj2);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0003D1A0 File Offset: 0x0003B3A0
		private void Start()
		{
			IEnumerator routine = this.AnimateVertexColors();
			base.StartCoroutine(routine);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0003D1D0 File Offset: 0x0003B3D0
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [v27 @ X0_v4+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj3;
			bool flag2 = obj3 == 0;
			bool flag3 = obj == this.m_TextComponent;
			if (flag2)
			{
				this.hasTextChanged = (1L != 0L);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0003D2DC File Offset: 0x0003B4DC
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

		// Token: 0x060002E2 RID: 738 RVA: 0x0003D36C File Offset: 0x0003B56C
		public VertexJitter()
		{
			float angleMultiplier;
			this.AngleMultiplier = angleMultiplier;
			base..ctor();
		}

		// Token: 0x040003AF RID: 943
		public float AngleMultiplier;

		// Token: 0x040003B0 RID: 944
		public float SpeedMultiplier;

		// Token: 0x040003B1 RID: 945
		public float CurveScale = 1f;

		// Token: 0x040003B2 RID: 946
		private TMP_Text m_TextComponent;

		// Token: 0x040003B3 RID: 947
		private bool hasTextChanged;

		// Token: 0x020000AC RID: 172
		private struct VertexAnim
		{
			// Token: 0x040004AE RID: 1198
			public float angleRange;

			// Token: 0x040004AF RID: 1199
			public float angle;

			// Token: 0x040004B0 RID: 1200
			public float speed;
		}

		// Token: 0x020000AD RID: 173
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003E4 RID: 996 RVA: 0x00046638 File Offset: 0x00044838
			public <AnimateVertexColors>d__11(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x000040E7 File Offset: 0x000022E7
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00046664 File Offset: 0x00044864
			bool IEnumerator.MoveNext()
			{
				object obj2;
				object obj = obj2 - 368L;
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				VertexJitter vertexJitter = this.<>4__this;
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				float seconds;
				bool result;
				int num2;
				if (this.<>4__this != 0)
				{
					if (!(~vertexJitter.hasTextChanged))
					{
						if (this.<textInfo>5__2 == 0)
						{
							goto IL_17F;
						}
						TMP_MeshInfo[] array = this.<textInfo>5__2.CopyMeshInfoVertexData();
						this.<cachedMeshInfo>5__5 = array;
						Console.WriteLine("Method not found @24D64EC");
						bool hasTextChanged;
						vertexJitter.hasTextChanged = hasTextChanged;
					}
					TMP_TextInfo tmp_TextInfo = this.<textInfo>5__2;
					if (this.<textInfo>5__2 != 0)
					{
						if (tmp_TextInfo.characterCount != 0)
						{
							goto IL_18E;
						}
						Console.WriteLine("Method not found @24D67D8");
						WaitForSeconds waitForSeconds;
						waitForSeconds..ctor(seconds);
						this.<>2__current = waitForSeconds;
						Console.WriteLine("Method not found @24D64EC");
						bool flag;
						result = flag;
						num2 = (int)1L;
						goto IL_2B9;
					}
				}
				IL_17F:
				Console.WriteLine("Method not found @24D67E8");
				IL_18E:
				int num3 = (int)((long)this.<loopCount>5__3 + 1L);
				this.<loopCount>5__3 = num3;
				Console.WriteLine("Method not found @24D67D8");
				WaitForSeconds waitForSeconds2;
				waitForSeconds2..ctor(seconds);
				this.<>2__current = waitForSeconds2;
				Console.WriteLine("Method not found @24D64EC");
				bool flag2;
				result = flag2;
				num2 = (int)2L;
				IL_2B9:
				this.<>1__state = num2;
				return result;
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060003E7 RID: 999 RVA: 0x00046948 File Offset: 0x00044B48
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x0004695C File Offset: 0x00044B5C
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.VertexJitter/<AnimateVertexColors>d__11::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000469C0 File Offset: 0x00044BC0
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040004B1 RID: 1201
			private int <>1__state;

			// Token: 0x040004B2 RID: 1202
			private object <>2__current;

			// Token: 0x040004B3 RID: 1203
			public VertexJitter <>4__this;

			// Token: 0x040004B4 RID: 1204
			private TMP_TextInfo <textInfo>5__2;

			// Token: 0x040004B5 RID: 1205
			private int <loopCount>5__3;

			// Token: 0x040004B6 RID: 1206
			private VertexJitter.VertexAnim[] <vertexAnim>5__4;

			// Token: 0x040004B7 RID: 1207
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;
		}
	}
}
