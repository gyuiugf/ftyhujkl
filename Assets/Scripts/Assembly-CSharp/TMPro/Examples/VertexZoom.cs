using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000076 RID: 118
	public class VertexZoom : MonoBehaviour
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x0003DE6C File Offset: 0x0003C06C
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

		// Token: 0x060002F2 RID: 754 RVA: 0x0003DEE8 File Offset: 0x0003C0E8
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
				Console.WriteLine("Unmanaged memory load: [523C318]");
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

		// Token: 0x060002F3 RID: 755 RVA: 0x0003E06C File Offset: 0x0003C26C
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
				Console.WriteLine("Unmanaged memory load: [523C318]");
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

		// Token: 0x060002F4 RID: 756 RVA: 0x0003E1F0 File Offset: 0x0003C3F0
		private void Start()
		{
			IEnumerator routine = this.AnimateVertexColors();
			base.StartCoroutine(routine);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0003E220 File Offset: 0x0003C420
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

		// Token: 0x060002F6 RID: 758 RVA: 0x0003E32C File Offset: 0x0003C52C
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

		// Token: 0x060002F7 RID: 759 RVA: 0x0003E3BC File Offset: 0x0003C5BC
		public VertexZoom()
		{
			float angleMultiplier;
			this.AngleMultiplier = angleMultiplier;
			base..ctor();
		}

		// Token: 0x040003BF RID: 959
		public float AngleMultiplier;

		// Token: 0x040003C0 RID: 960
		public float SpeedMultiplier;

		// Token: 0x040003C1 RID: 961
		public float CurveScale = 1f;

		// Token: 0x040003C2 RID: 962
		private TMP_Text m_TextComponent;

		// Token: 0x040003C3 RID: 963
		private bool hasTextChanged;

		// Token: 0x020000B0 RID: 176
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060003F7 RID: 1015 RVA: 0x00047338 File Offset: 0x00045538
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				for (;;)
				{
					if (this.modifiedCharScale != 0)
					{
						float num = this.modifiedCharScale.get_Item(a);
						if (this.modifiedCharScale != 0)
						{
							break;
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				float value = this.modifiedCharScale.get_Item(a);
				object obj;
				float num2 = obj + 12L;
				return num2.CompareTo(value);
			}

			// Token: 0x040004C2 RID: 1218
			public List<float> modifiedCharScale;

			// Token: 0x040004C3 RID: 1219
			public Comparison<int> <>9__0;
		}

		// Token: 0x020000B1 RID: 177
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003F8 RID: 1016 RVA: 0x00047444 File Offset: 0x00045644
			public <AnimateVertexColors>d__10(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x000040ED File Offset: 0x000022ED
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00047470 File Offset: 0x00045670
			bool IEnumerator.MoveNext()
			{
				object obj2;
				object obj = obj2 - 320L;
				bool flag = this == 0;
				VertexZoom.<AnimateVertexColors>d__10 <AnimateVertexColors>d__ = this;
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
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					VertexZoom.<AnimateVertexColors>d__10 <AnimateVertexColors>d__2;
					<AnimateVertexColors>d__ = <AnimateVertexColors>d__2;
				}
				VertexZoom vertexZoom = this.<>4__this;
				bool flag2 = this.<>1__state == 0;
				bool result;
				if (flag2)
				{
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					Console.WriteLine("Method not found @24D67D8");
					object obj3;
					obj3..ctor();
					this.<>8__1 = obj3;
					Console.WriteLine("Method not found @24D64EC");
					float seconds;
					bool flag3;
					int num2;
					if (this.<>4__this != 0)
					{
						TMP_Text textComponent = vertexZoom.m_TextComponent;
						if (vertexZoom.m_TextComponent != 0)
						{
							Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
							if (vertexZoom.m_TextComponent != 0)
							{
								TMP_TextInfo textInfo = vertexZoom.m_TextComponent.textInfo;
								this.<textInfo>5__2 = textInfo;
								Console.WriteLine("Method not found @24D64EC");
								if (this != 0)
								{
									TMP_MeshInfo[] array = base.CopyMeshInfoVertexData();
									this.<cachedMeshInfoVertexData>5__3 = array;
									Console.WriteLine("Method not found @24D64EC");
									Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
									Console.WriteLine("Method not found @24D67D8");
									List<float> list;
									list..ctor();
									if (this != 0)
									{
										this.<>1__state = list;
										Console.WriteLine("Method not found @24D64EC");
										Console.WriteLine("Method not found @24D67D8");
										List<int> list2;
										list2..ctor();
										this.<scaleSortingOrder>5__4 = list2;
										Console.WriteLine("Method not found @24D64EC");
										vertexZoom.hasTextChanged = (1L != 0L);
										if (this.<textInfo>5__2 != 0)
										{
											TMP_MeshInfo[] array2 = this.<textInfo>5__2.CopyMeshInfoVertexData();
											this.<cachedMeshInfoVertexData>5__3 = array2;
											Console.WriteLine("Method not found @24D64EC");
											bool hasTextChanged;
											vertexZoom.hasTextChanged = hasTextChanged;
											TMP_TextInfo tmp_TextInfo = this.<textInfo>5__2;
											if (this.<textInfo>5__2 != 0)
											{
												Console.WriteLine("Unmanaged memory load: [v205 @ X8_v3+7D8]");
												IntPtr intPtr = (IntPtr)0;
												if (tmp_TextInfo.characterCount == 0)
												{
													Console.WriteLine("Method not found @24D67D8");
													WaitForSeconds waitForSeconds;
													waitForSeconds..ctor(seconds);
													this.<>2__current = waitForSeconds;
													Console.WriteLine("Method not found @24D64EC");
													bool flag4;
													flag3 = flag4;
													num2 = (int)1L;
													goto IL_5B1;
												}
												VertexZoom.<>c__DisplayClass10_0 <>c__DisplayClass10_ = this.<>8__1;
												if (this.<>8__1 != 0)
												{
													List<float> modifiedCharScale = <>c__DisplayClass10_.modifiedCharScale;
													if (<>c__DisplayClass10_.modifiedCharScale != 0)
													{
														List<int> list3 = this.<scaleSortingOrder>5__4;
														VertexZoom vertexZoom2 = this.<>4__this;
														Console.WriteLine("Unmanaged memory load: [v184 @ X10_v1 (System.Collections.Generic.List`1<System.Single>)+1C]");
														object obj4 = (IntPtr)0 + 1;
														if (this.<scaleSortingOrder>5__4 != 0)
														{
															Console.WriteLine("Unmanaged memory load: [v192 @ X9_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															object obj5 = (IntPtr)0 + 1;
															goto IL_497;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
					IL_497:
					Console.WriteLine("Method not found @24D67D8");
					WaitForSeconds waitForSeconds2;
					waitForSeconds2..ctor(seconds);
					this.<>2__current = waitForSeconds2;
					Console.WriteLine("Method not found @24D64EC");
					bool flag5;
					flag3 = flag5;
					num2 = (int)2L;
					IL_5B1:
					this.<>1__state = num2;
					result = flag3;
				}
				else
				{
					result = (<AnimateVertexColors>d__ != null);
				}
				return result;
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060003FB RID: 1019 RVA: 0x00047A54 File Offset: 0x00045C54
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00047A68 File Offset: 0x00045C68
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.VertexZoom/<AnimateVertexColors>d__10::System.Collections.IEnumerator.Reset()

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

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060003FD RID: 1021 RVA: 0x00047ACC File Offset: 0x00045CCC
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040004C4 RID: 1220
			private int <>1__state;

			// Token: 0x040004C5 RID: 1221
			private object <>2__current;

			// Token: 0x040004C6 RID: 1222
			public VertexZoom <>4__this;

			// Token: 0x040004C7 RID: 1223
			private VertexZoom.<>c__DisplayClass10_0 <>8__1;

			// Token: 0x040004C8 RID: 1224
			private TMP_TextInfo <textInfo>5__2;

			// Token: 0x040004C9 RID: 1225
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			// Token: 0x040004CA RID: 1226
			private List<int> <scaleSortingOrder>5__4;
		}
	}
}
