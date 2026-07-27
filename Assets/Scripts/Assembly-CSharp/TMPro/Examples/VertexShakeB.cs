using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000075 RID: 117
	public class VertexShakeB : MonoBehaviour
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0003D8FC File Offset: 0x0003BAFC
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

		// Token: 0x060002EB RID: 747 RVA: 0x0003D978 File Offset: 0x0003BB78
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
				Console.WriteLine("Unmanaged memory load: [523C300]");
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

		// Token: 0x060002EC RID: 748 RVA: 0x0003DAFC File Offset: 0x0003BCFC
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
				Console.WriteLine("Unmanaged memory load: [523C300]");
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

		// Token: 0x060002ED RID: 749 RVA: 0x0003DC80 File Offset: 0x0003BE80
		private void Start()
		{
			IEnumerator routine = this.AnimateVertexColors();
			base.StartCoroutine(routine);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0003DCB0 File Offset: 0x0003BEB0
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

		// Token: 0x060002EF RID: 751 RVA: 0x0003DDB4 File Offset: 0x0003BFB4
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

		// Token: 0x060002F0 RID: 752 RVA: 0x0003DE44 File Offset: 0x0003C044
		public VertexShakeB()
		{
			float angleMultiplier;
			this.AngleMultiplier = angleMultiplier;
			base..ctor();
		}

		// Token: 0x040003BA RID: 954
		public float AngleMultiplier;

		// Token: 0x040003BB RID: 955
		public float SpeedMultiplier;

		// Token: 0x040003BC RID: 956
		public float CurveScale = 1f;

		// Token: 0x040003BD RID: 957
		private TMP_Text m_TextComponent;

		// Token: 0x040003BE RID: 958
		private bool hasTextChanged;

		// Token: 0x020000AF RID: 175
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003F0 RID: 1008 RVA: 0x00046E7C File Offset: 0x0004507C
			public <AnimateVertexColors>d__10(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x000040EB File Offset: 0x000022EB
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x00046EA8 File Offset: 0x000450A8
			bool IEnumerator.MoveNext()
			{
				object obj2;
				object obj = obj2 - 384L;
				bool flag = this == 0;
				VertexShakeB.<AnimateVertexColors>d__10 <AnimateVertexColors>d__ = this;
				if (!flag)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					VertexShakeB.<AnimateVertexColors>d__10 <AnimateVertexColors>d__2;
					<AnimateVertexColors>d__ = <AnimateVertexColors>d__2;
				}
				VertexShakeB vertexShakeB = this.<>4__this;
				bool flag2 = this.<>1__state == 0;
				bool result;
				if (flag2)
				{
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					float seconds;
					bool flag3;
					int num2;
					if (this.<>4__this != 0 && vertexShakeB.m_TextComponent != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
						if (vertexShakeB.m_TextComponent != 0)
						{
							TMP_TextInfo textInfo = vertexShakeB.m_TextComponent.textInfo;
							this.<textInfo>5__2 = textInfo;
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Method not found @24D662C");
							Vector3[][] array;
							this.<copyOfVertices>5__3 = array;
							Console.WriteLine("Method not found @24D64EC");
							vertexShakeB.hasTextChanged = (1L != 0L);
							object obj3 = this + 48L;
							if (obj3 != 0)
							{
								TMP_TextInfo tmp_TextInfo = this.<textInfo>5__2;
								if (this.<textInfo>5__2 != 0 && tmp_TextInfo.meshInfo != 0)
								{
									bool hasTextChanged;
									vertexShakeB.hasTextChanged = hasTextChanged;
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

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00047298 File Offset: 0x00045498
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x000472AC File Offset: 0x000454AC
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.VertexShakeB/<AnimateVertexColors>d__10::System.Collections.IEnumerator.Reset()

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

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00047310 File Offset: 0x00045510
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040004BD RID: 1213
			private int <>1__state;

			// Token: 0x040004BE RID: 1214
			private object <>2__current;

			// Token: 0x040004BF RID: 1215
			public VertexShakeB <>4__this;

			// Token: 0x040004C0 RID: 1216
			private TMP_TextInfo <textInfo>5__2;

			// Token: 0x040004C1 RID: 1217
			private Vector3[][] <copyOfVertices>5__3;
		}
	}
}
