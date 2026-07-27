using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000065 RID: 101
	public class SkewTextExample : MonoBehaviour
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00037CB4 File Offset: 0x00035EB4
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

		// Token: 0x06000297 RID: 663 RVA: 0x00037D64 File Offset: 0x00035F64
		private void Start()
		{
			IEnumerator routine = this.WarpText();
			base.StartCoroutine(routine);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00037D94 File Offset: 0x00035F94
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

		// Token: 0x06000299 RID: 665 RVA: 0x00037E70 File Offset: 0x00036070
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

		// Token: 0x0600029A RID: 666 RVA: 0x00037F00 File Offset: 0x00036100
		public SkewTextExample()
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

		// Token: 0x04000360 RID: 864
		private TMP_Text m_TextComponent;

		// Token: 0x04000361 RID: 865
		public AnimationCurve VertexCurve;

		// Token: 0x04000362 RID: 866
		public float CurveScale;

		// Token: 0x04000363 RID: 867
		public float ShearAmount;

		// Token: 0x020000A1 RID: 161
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003BA RID: 954 RVA: 0x0004538C File Offset: 0x0004358C
			public <WarpText>d__7(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x000040D9 File Offset: 0x000022D9
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003BC RID: 956 RVA: 0x000453B8 File Offset: 0x000435B8
			bool IEnumerator.MoveNext()
			{
				object obj2;
				object obj = obj2 - 368L;
				SkewTextExample skewTextExample = this.<>4__this;
				bool flag = this.<>1__state == 0;
				bool result;
				if (flag)
				{
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					if (this.<>4__this != 0 && skewTextExample.VertexCurve != 0)
					{
						WrapMode wrapMode;
						skewTextExample.VertexCurve.preWrapMode = wrapMode;
						if (skewTextExample.VertexCurve != 0)
						{
							skewTextExample.VertexCurve.postWrapMode = wrapMode;
							if (skewTextExample.m_TextComponent != 0)
							{
								skewTextExample.m_TextComponent.havePropertiesChanged = (wrapMode != WrapMode.Default);
								float curveScale = (float)((double)skewTextExample.CurveScale * 10.0);
								skewTextExample.CurveScale = curveScale;
								this.<old_CurveScale>5__2 = curveScale;
								this.<old_ShearValue>5__3 = skewTextExample.ShearAmount;
								AnimationCurve animationCurve = skewTextExample.m_TextComponent.CopyAnimationCurve(skewTextExample.VertexCurve);
								this.<old_curve>5__4 = animationCurve;
								Console.WriteLine("Method not found @24D64EC");
								float num2 = skewTextExample.CurveScale;
								SkewTextExample skewTextExample3;
								SkewTextExample skewTextExample2 = skewTextExample3;
								bool flag3;
								do
								{
									TMP_Text textComponent = skewTextExample.m_TextComponent;
									if (skewTextExample.m_TextComponent == 0)
									{
										goto IL_446;
									}
									bool flag2 = ~textComponent.m_havePropertiesChanged;
									float num3 = num2;
									if (flag2)
									{
										Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
										num3 = skewTextExample.CurveScale;
									}
									this.<old_CurveScale>5__2 = skewTextExample.CurveScale;
									AnimationCurve animationCurve2 = skewTextExample2.CopyAnimationCurve(skewTextExample.VertexCurve);
									this.<old_curve>5__4 = animationCurve2;
									Console.WriteLine("Method not found @24D64EC");
									this.<old_ShearValue>5__3 = skewTextExample.ShearAmount;
									if (skewTextExample.m_TextComponent == 0)
									{
										goto IL_446;
									}
									Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
									if (skewTextExample.m_TextComponent == 0)
									{
										goto IL_446;
									}
									TMP_TextInfo textInfo = skewTextExample.m_TextComponent.textInfo;
									if (textInfo == 0)
									{
										goto IL_446;
									}
									flag3 = (textInfo.characterCount == 0);
									num2 = num3;
									skewTextExample2 = textInfo;
								}
								while (flag3);
								if (skewTextExample.m_TextComponent != 0)
								{
									Bounds bounds = skewTextExample.m_TextComponent.bounds;
									if (skewTextExample.m_TextComponent != 0)
									{
										Bounds bounds2 = skewTextExample.m_TextComponent.bounds;
										if (skewTextExample.m_TextComponent != 0)
										{
											Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
											Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+8]");
											object obj3 = (IntPtr)0;
											Console.WriteLine("Method not found @24D64EC");
											goto IL_450;
										}
									}
								}
							}
						}
					}
					IL_446:
					Console.WriteLine("Method not found @24D67E8");
					IL_450:
					bool flag4;
					result = flag4;
				}
				else
				{
					result = (this != null);
				}
				return result;
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060003BD RID: 957 RVA: 0x00045830 File Offset: 0x00043A30
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00045844 File Offset: 0x00043A44
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.SkewTextExample/<WarpText>d__7::System.Collections.IEnumerator.Reset()

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

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060003BF RID: 959 RVA: 0x000458A8 File Offset: 0x00043AA8
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0400046A RID: 1130
			private int <>1__state;

			// Token: 0x0400046B RID: 1131
			private object <>2__current;

			// Token: 0x0400046C RID: 1132
			public SkewTextExample <>4__this;

			// Token: 0x0400046D RID: 1133
			private float <old_CurveScale>5__2;

			// Token: 0x0400046E RID: 1134
			private float <old_ShearValue>5__3;

			// Token: 0x0400046F RID: 1135
			private AnimationCurve <old_curve>5__4;
		}
	}
}
