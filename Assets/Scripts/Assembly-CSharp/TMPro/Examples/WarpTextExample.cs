using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000077 RID: 119
	public class WarpTextExample : MonoBehaviour
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0003E3E4 File Offset: 0x0003C5E4
		private void Awake()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			GameObject gameObject;
			for (;;)
			{
				gameObject = base.gameObject;
				if (gameObject != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Method not found @292FDFC");
			this.m_TextComponent = gameObject;
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0003E494 File Offset: 0x0003C694
		private void Start()
		{
			IEnumerator routine = this.WarpText();
			base.StartCoroutine(routine);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0003E4C4 File Offset: 0x0003C6C4
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			if (curve != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			AnimationCurve animationCurve;
			Keyframe[] keys;
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				animationCurve..ctor();
				if (curve != 0)
				{
					keys = curve.keys;
					if (animationCurve != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			animationCurve.keys = keys;
			return animationCurve;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0003E5A0 File Offset: 0x0003C7A0
		private IEnumerator WarpText()
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

		// Token: 0x060002FC RID: 764 RVA: 0x0003E630 File Offset: 0x0003C830
		public WarpTextExample()
		{
			object obj2;
			object obj = obj2 - 192L;
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523C030]");
			object obj3 = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Method not found @24D662C");
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				Keyframe keyframe = obj + 128L;
				float time;
				float value;
				keyframe = new Keyframe(time, value);
				if (obj3 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v25 @ X0_v6+18]");
					if ((IntPtr)0 != 0)
					{
						Keyframe keyframe2 = obj + 96L;
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+8]");
						IntPtr intPtr = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+98]");
						IntPtr intPtr2 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+90]");
						IntPtr intPtr3 = (IntPtr)0;
						ref Keyframe ptr = keyframe2;
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+8]");
						ptr = new Keyframe((float)((IntPtr)0), value);
					}
					Console.WriteLine("Method not found @24D67F0");
				}
				Console.WriteLine("Method not found @24D67E8");
			}
		}

		// Token: 0x040003C4 RID: 964
		private TMP_Text m_TextComponent;

		// Token: 0x040003C5 RID: 965
		public AnimationCurve VertexCurve;

		// Token: 0x040003C6 RID: 966
		public float AngleMultiplier;

		// Token: 0x040003C7 RID: 967
		public float SpeedMultiplier;

		// Token: 0x040003C8 RID: 968
		public float CurveScale;

		// Token: 0x020000B2 RID: 178
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003FE RID: 1022 RVA: 0x00047AE0 File Offset: 0x00045CE0
			public <WarpText>d__8(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x000040EF File Offset: 0x000022EF
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x00047B0C File Offset: 0x00045D0C
			bool IEnumerator.MoveNext()
			{
				object obj2;
				object obj = obj2 - 400L;
				bool flag = this == 0;
				WarpTextExample.<WarpText>d__8 result = this;
				if (!flag)
				{
					Console.WriteLine("Method not found @24D6540");
					WarpTextExample.<WarpText>d__8 <WarpText>d__;
					result = <WarpText>d__;
				}
				for (;;)
				{
					WarpTextExample warpTextExample = this.<>4__this;
					bool flag2 = this.<>1__state == 0;
					if (!flag2)
					{
						goto IL_41B;
					}
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					if (this.<>4__this != 0 && warpTextExample.VertexCurve != 0)
					{
						WrapMode wrapMode;
						warpTextExample.VertexCurve.preWrapMode = wrapMode;
						if (warpTextExample.VertexCurve != 0)
						{
							warpTextExample.VertexCurve.postWrapMode = wrapMode;
							if (warpTextExample.m_TextComponent != 0)
							{
								warpTextExample.m_TextComponent.havePropertiesChanged = (wrapMode != WrapMode.Default);
								float curveScale = (float)((double)warpTextExample.CurveScale * 10.0);
								warpTextExample.CurveScale = curveScale;
								this.<old_CurveScale>5__2 = curveScale;
								AnimationCurve animationCurve = warpTextExample.m_TextComponent.CopyAnimationCurve(warpTextExample.VertexCurve);
								this.<old_curve>5__3 = animationCurve;
								Console.WriteLine("Method not found @24D64EC");
								float num2 = warpTextExample.CurveScale;
								WarpTextExample warpTextExample3;
								WarpTextExample warpTextExample2 = warpTextExample3;
								bool flag4;
								do
								{
									TMP_Text textComponent = warpTextExample.m_TextComponent;
									if (warpTextExample.m_TextComponent == 0)
									{
										goto IL_428;
									}
									bool flag3 = ~textComponent.m_havePropertiesChanged;
									object obj3 = !flag3;
									float num3 = num2;
									if (obj3 == null)
									{
										Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
										num3 = this.<old_CurveScale>5__2;
									}
									this.<old_CurveScale>5__2 = warpTextExample.CurveScale;
									AnimationCurve animationCurve2 = warpTextExample2.CopyAnimationCurve(warpTextExample.VertexCurve);
									this.<old_curve>5__3 = animationCurve2;
									Console.WriteLine("Method not found @24D64EC");
									if (warpTextExample.m_TextComponent == 0)
									{
										goto IL_428;
									}
									Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
									if (warpTextExample.m_TextComponent == 0)
									{
										goto IL_428;
									}
									TMP_TextInfo textInfo = warpTextExample.m_TextComponent.textInfo;
									if (textInfo == 0)
									{
										goto IL_428;
									}
									flag4 = (textInfo.characterCount == 0);
									num2 = num3;
									warpTextExample2 = textInfo;
								}
								while (flag4);
								if (warpTextExample.m_TextComponent != 0)
								{
									Bounds bounds = warpTextExample.m_TextComponent.bounds;
									if (warpTextExample.m_TextComponent != 0)
									{
										Bounds bounds2 = warpTextExample.m_TextComponent.bounds;
										if (warpTextExample.m_TextComponent != 0)
										{
											break;
										}
									}
								}
							}
						}
					}
					IL_428:
					Console.WriteLine("Method not found @24D67E8");
					Console.WriteLine("Method not found @24D67F0");
				}
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				Console.WriteLine("Method not found @24D67D8");
				WaitForSeconds waitForSeconds;
				float seconds;
				waitForSeconds..ctor(seconds);
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+10]");
				object obj4 = (IntPtr)0;
				Console.WriteLine("Method not found @24D64EC");
				bool result2;
				return result2;
				IL_41B:
				return result != null;
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x00047FDC File Offset: 0x000461DC
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x00047FF0 File Offset: 0x000461F0
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (06000402)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.WarpTextExample/<WarpText>d__8::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00048054 File Offset: 0x00046254
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040004CB RID: 1227
			private int <>1__state;

			// Token: 0x040004CC RID: 1228
			private object <>2__current;

			// Token: 0x040004CD RID: 1229
			public WarpTextExample <>4__this;

			// Token: 0x040004CE RID: 1230
			private float <old_CurveScale>5__2;

			// Token: 0x040004CF RID: 1231
			private AnimationCurve <old_curve>5__3;
		}
	}
}
