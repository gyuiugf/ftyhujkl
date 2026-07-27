using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000068 RID: 104
	public class TextMeshProFloatingText : MonoBehaviour
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00038864 File Offset: 0x00036A64
		private void Awake()
		{
			Console.WriteLine("Unmanaged memory load: [523C0A8]");
			object str = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BF70]");
			object obj = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Camera main;
			for (;;)
			{
				Transform transform = base.transform;
				this.m_transform = transform;
				Console.WriteLine("Method not found @24D64EC");
				string name = base.name;
				string name2 = name + str;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor(name2);
				this.m_floatingText = obj;
				Console.WriteLine("Method not found @24D64EC");
				main = Camera.main;
				if (main != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Transform transform2 = main.transform;
			this.m_cameraTransform = transform2;
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000389C4 File Offset: 0x00036BC4
		private void Start()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Vector3 vector;
			for (;;)
			{
				if (this.m_floatingText != 0)
				{
					Transform transform = this.m_floatingText.transform;
					this.m_floatingText_Transform = transform;
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					if (this != 0)
					{
						Vector3 position = base.position;
						if (this != 0)
						{
							Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
							base.position = vector;
							if (this.m_floatingText != 0)
							{
								Console.WriteLine("Method not found @292FD6C");
								this.m_textMesh = this.m_floatingText;
								Console.WriteLine("Method not found @24D64EC");
								Console.WriteLine("Unmanaged memory load: [523BF10]");
								object font = (IntPtr)0;
								Console.WriteLine("Method not found @2A6AE00");
								if (this != 0)
								{
									base.font = font;
									if (this != 0)
									{
										Console.WriteLine("Method not found @2894080");
										if (this != 0)
										{
											Font font2 = base.font;
											if (font2 != 0)
											{
												Material material = font2.material;
												if (this != 0)
												{
													base.sharedMaterial = material;
													int minInclusive = UnityEngine.Random.Range(this, material);
													int minInclusive2 = UnityEngine.Random.Range(minInclusive, material);
													int num = UnityEngine.Random.Range(minInclusive2, material);
													if (this != 0)
													{
														Console.WriteLine("Not implemented instruction: Instruction UCVTF not yet implemented.");
														Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
														Console.WriteLine("Not implemented instruction: Instruction UCVTF not yet implemented.");
														Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
														Console.WriteLine("Not implemented instruction: Instruction UCVTF not yet implemented.");
														Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
														base.color = vector;
														if (this != 0)
														{
															base.anchor = vector;
															if (this != 0)
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
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			base.fontSize = vector;
			IEnumerator routine = this.DisplayTextMeshFloatingText();
			base.StartCoroutine(routine);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00038D38 File Offset: 0x00036F38
		public IEnumerator DisplayTextMeshProFloatingText()
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

		// Token: 0x060002A9 RID: 681 RVA: 0x00038DC8 File Offset: 0x00036FC8
		public IEnumerator DisplayTextMeshFloatingText()
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

		// Token: 0x060002AA RID: 682 RVA: 0x00038E58 File Offset: 0x00037058
		public TextMeshProFloatingText()
		{
			Console.WriteLine("Unmanaged memory load: [559212E]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523AE20]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v22 @ X8_v3+B8]");
			object obj2 = (IntPtr)0;
			this.lastPOS = obj2;
			Console.WriteLine("Unmanaged memory load: [v24 @ X8_v4+8]");
			IntPtr intPtr = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [5592203]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523C0C0]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v45 @ X8_v7+B8]");
			object obj4 = (IntPtr)0;
			this.lastRotation = obj4;
			base..ctor();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00038F98 File Offset: 0x00037198
		// Note: this type is marked as 'beforefieldinit'.
		static TextMeshProFloatingText()
		{
			Console.WriteLine("Unmanaged memory load: [523C008]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C0C8]");
			object obj2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C0D0]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B228]");
			object obj4 = (IntPtr)0;
			object obj5;
			if (obj5 == null)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+B8]");
				object obj6 = (IntPtr)0;
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Method not found @24D662C");
				Console.WriteLine("Method not found @24D67D8");
				float seconds;
				obj4..ctor(seconds);
				if (obj3 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v52 @ X0_v12+18]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Method not found @24D64EC");
						Console.WriteLine("Method not found @24D67D8");
						obj4..ctor(seconds);
						Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					}
					Console.WriteLine("Method not found @24D67F0");
				}
				Console.WriteLine("Method not found @24D67E8");
			}
		}

		// Token: 0x04000369 RID: 873
		public Font TheFont;

		// Token: 0x0400036A RID: 874
		private GameObject m_floatingText;

		// Token: 0x0400036B RID: 875
		private TextMeshPro m_textMeshPro;

		// Token: 0x0400036C RID: 876
		private TextMesh m_textMesh;

		// Token: 0x0400036D RID: 877
		private Transform m_transform;

		// Token: 0x0400036E RID: 878
		private Transform m_floatingText_Transform;

		// Token: 0x0400036F RID: 879
		private Transform m_cameraTransform;

		// Token: 0x04000370 RID: 880
		private Vector3 lastPOS;

		// Token: 0x04000371 RID: 881
		private Quaternion lastRotation;

		// Token: 0x04000372 RID: 882
		public int SpawnType;

		// Token: 0x04000373 RID: 883
		public bool IsTextObjectScaleStatic;

		// Token: 0x04000374 RID: 884
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		// Token: 0x04000375 RID: 885
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		// Token: 0x020000A5 RID: 165
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003D2 RID: 978 RVA: 0x00046008 File Offset: 0x00044208
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x000040E1 File Offset: 0x000022E1
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x00046034 File Offset: 0x00044234
			bool IEnumerator.MoveNext()
			{
				object obj;
				Vector3 position = obj - 80L;
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				TextMeshProFloatingText textMeshProFloatingText;
				for (;;)
				{
					textMeshProFloatingText = this.<>4__this;
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					if (this.<>4__this != 0 && textMeshProFloatingText.m_floatingText_Transform != 0)
					{
						break;
					}
					Console.WriteLine("Method not found @24D67E8");
					Console.WriteLine("Method not found @24D67F0");
				}
				textMeshProFloatingText.m_floatingText_Transform.position = position;
				IEnumerator routine = this.<>4__this.DisplayTextMeshFloatingText();
				return this.<>4__this.StartCoroutine(routine) != null;
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x00046180 File Offset: 0x00044380
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x00046194 File Offset: 0x00044394
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003D6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.TextMeshProFloatingText/<DisplayTextMeshFloatingText>d__16::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x000461F8 File Offset: 0x000443F8
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04000483 RID: 1155
			private int <>1__state;

			// Token: 0x04000484 RID: 1156
			private object <>2__current;

			// Token: 0x04000485 RID: 1157
			public TextMeshProFloatingText <>4__this;

			// Token: 0x04000486 RID: 1158
			private float <CountDuration>5__2;

			// Token: 0x04000487 RID: 1159
			private float <starting_Count>5__3;

			// Token: 0x04000488 RID: 1160
			private float <current_Count>5__4;

			// Token: 0x04000489 RID: 1161
			private Vector3 <start_pos>5__5;

			// Token: 0x0400048A RID: 1162
			private Color32 <start_color>5__6;

			// Token: 0x0400048B RID: 1163
			private float <alpha>5__7;

			// Token: 0x0400048C RID: 1164
			private float <fadeDuration>5__8;
		}

		// Token: 0x020000A6 RID: 166
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003D8 RID: 984 RVA: 0x0004620C File Offset: 0x0004440C
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x000040E3 File Offset: 0x000022E3
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00046238 File Offset: 0x00044438
			bool IEnumerator.MoveNext()
			{
				object obj;
				Vector3 position = obj - 80L;
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				TextMeshProFloatingText textMeshProFloatingText;
				for (;;)
				{
					textMeshProFloatingText = this.<>4__this;
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					if (this.<>4__this != 0 && textMeshProFloatingText.m_floatingText_Transform != 0)
					{
						break;
					}
					Console.WriteLine("Method not found @24D67E8");
					Console.WriteLine("Method not found @24D67F0");
				}
				textMeshProFloatingText.m_floatingText_Transform.position = position;
				IEnumerator routine = this.<>4__this.DisplayTextMeshProFloatingText();
				return this.<>4__this.StartCoroutine(routine) != null;
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060003DB RID: 987 RVA: 0x00046384 File Offset: 0x00044584
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00046398 File Offset: 0x00044598
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.TextMeshProFloatingText/<DisplayTextMeshProFloatingText>d__15::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060003DD RID: 989 RVA: 0x000463FC File Offset: 0x000445FC
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0400048D RID: 1165
			private int <>1__state;

			// Token: 0x0400048E RID: 1166
			private object <>2__current;

			// Token: 0x0400048F RID: 1167
			public TextMeshProFloatingText <>4__this;

			// Token: 0x04000490 RID: 1168
			private float <CountDuration>5__2;

			// Token: 0x04000491 RID: 1169
			private float <starting_Count>5__3;

			// Token: 0x04000492 RID: 1170
			private float <current_Count>5__4;

			// Token: 0x04000493 RID: 1171
			private Vector3 <start_pos>5__5;

			// Token: 0x04000494 RID: 1172
			private Color32 <start_color>5__6;

			// Token: 0x04000495 RID: 1173
			private float <alpha>5__7;

			// Token: 0x04000496 RID: 1174
			private float <fadeDuration>5__8;
		}
	}
}
