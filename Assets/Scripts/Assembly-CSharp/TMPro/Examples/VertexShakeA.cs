using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000074 RID: 116
	public class VertexShakeA : MonoBehaviour
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x0003D394 File Offset: 0x0003B594
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

		// Token: 0x060002E4 RID: 740 RVA: 0x0003D410 File Offset: 0x0003B610
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
				Console.WriteLine("Unmanaged memory load: [523C2D8]");
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

		// Token: 0x060002E5 RID: 741 RVA: 0x0003D594 File Offset: 0x0003B794
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
				Console.WriteLine("Unmanaged memory load: [523C2D8]");
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

		// Token: 0x060002E6 RID: 742 RVA: 0x0003D718 File Offset: 0x0003B918
		private void Start()
		{
			IEnumerator routine = this.AnimateVertexColors();
			base.StartCoroutine(routine);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0003D748 File Offset: 0x0003B948
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [v23 @ X0_v4+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj3;
			bool flag3 = obj3 == 0;
			bool flag4 = this.m_TextComponent;
			if (flag3)
			{
				this.hasTextChanged = (1L != 0L);
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0003D84C File Offset: 0x0003BA4C
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

		// Token: 0x040003B4 RID: 948
		public float AngleMultiplier;

		// Token: 0x040003B5 RID: 949
		public float SpeedMultiplier;

		// Token: 0x040003B6 RID: 950
		public float ScaleMultiplier;

		// Token: 0x040003B7 RID: 951
		public float RotationMultiplier;

		// Token: 0x040003B8 RID: 952
		private TMP_Text m_TextComponent;

		// Token: 0x040003B9 RID: 953
		private bool hasTextChanged;

		// Token: 0x020000AE RID: 174
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003EA RID: 1002 RVA: 0x000469D4 File Offset: 0x00044BD4
			public <AnimateVertexColors>d__11(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x000040E9 File Offset: 0x000022E9
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00046A00 File Offset: 0x00044C00
			bool IEnumerator.MoveNext()
			{
				object obj2;
				object obj = obj2 - 336L;
				bool flag = this == 0;
				VertexShakeA.<AnimateVertexColors>d__11 <AnimateVertexColors>d__ = this;
				if (!flag)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					VertexShakeA.<AnimateVertexColors>d__11 <AnimateVertexColors>d__2;
					<AnimateVertexColors>d__ = <AnimateVertexColors>d__2;
				}
				VertexShakeA vertexShakeA = this.<>4__this;
				bool flag2 = this.<>1__state == 0;
				bool result;
				if (flag2)
				{
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					float seconds;
					bool flag3;
					int num2;
					if (this.<>4__this != 0 && vertexShakeA.m_TextComponent != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
						if (vertexShakeA.m_TextComponent != 0)
						{
							TMP_TextInfo textInfo = vertexShakeA.m_TextComponent.textInfo;
							this.<textInfo>5__2 = textInfo;
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Method not found @24D662C");
							Vector3[][] array;
							this.<copyOfVertices>5__3 = array;
							Console.WriteLine("Method not found @24D64EC");
							vertexShakeA.hasTextChanged = (1L != 0L);
							object obj3 = this + 48L;
							if (obj3 != 0)
							{
								TMP_TextInfo tmp_TextInfo = this.<textInfo>5__2;
								if (this.<textInfo>5__2 != 0 && tmp_TextInfo.meshInfo != 0)
								{
									bool hasTextChanged;
									vertexShakeA.hasTextChanged = hasTextChanged;
									if (tmp_TextInfo.characterCount != 0)
									{
										TMP_MeshInfo[] meshInfo = tmp_TextInfo.meshInfo;
										goto IL_272;
									}
									Console.WriteLine("Method not found @24D67D8");
									WaitForSeconds waitForSeconds;
									waitForSeconds..ctor(seconds);
									this.<>2__current = waitForSeconds;
									Console.WriteLine("Method not found @24D64EC");
									bool flag4;
									flag3 = flag4;
									num2 = (int)1L;
									goto IL_3B4;
								}
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
					IL_272:
					Console.WriteLine("Method not found @24D67D8");
					WaitForSeconds waitForSeconds2;
					waitForSeconds2..ctor(seconds);
					this.<>2__current = waitForSeconds2;
					Console.WriteLine("Method not found @24D64EC");
					bool flag5;
					flag3 = flag5;
					num2 = (int)2L;
					IL_3B4:
					this.<>1__state = num2;
					result = flag3;
				}
				else
				{
					result = (<AnimateVertexColors>d__ != null);
				}
				return result;
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060003ED RID: 1005 RVA: 0x00046DF0 File Offset: 0x00044FF0
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x00046E04 File Offset: 0x00045004
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.VertexShakeA/<AnimateVertexColors>d__11::System.Collections.IEnumerator.Reset()

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

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060003EF RID: 1007 RVA: 0x00046E68 File Offset: 0x00045068
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040004B8 RID: 1208
			private int <>1__state;

			// Token: 0x040004B9 RID: 1209
			private object <>2__current;

			// Token: 0x040004BA RID: 1210
			public VertexShakeA <>4__this;

			// Token: 0x040004BB RID: 1211
			private TMP_TextInfo <textInfo>5__2;

			// Token: 0x040004BC RID: 1212
			private Vector3[][] <copyOfVertices>5__3;
		}
	}
}
