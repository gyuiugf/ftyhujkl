using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000066 RID: 102
	public class TeleType : MonoBehaviour
	{
		// Token: 0x0600029B RID: 667 RVA: 0x000380B4 File Offset: 0x000362B4
		private void Awake()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Method not found @2894080");
				this.m_textMeshPro = this;
				Console.WriteLine("Method not found @24D64EC");
				if (this != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					if (this.m_textMeshPro != 0)
					{
						this.m_textMeshPro.textWrappingMode = this.label01;
						if (this != 0)
						{
							break;
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			base.alignment = this.label01;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000381B4 File Offset: 0x000363B4
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

		// Token: 0x0600029D RID: 669 RVA: 0x00038244 File Offset: 0x00036444
		public TeleType()
		{
			Console.WriteLine("Unmanaged memory load: [523C048]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C050]");
			object obj2 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			this.label01 = obj;
			Console.WriteLine("Method not found @24D64EC");
			this.label02 = obj2;
			Console.WriteLine("Method not found @24D64EC");
			base..ctor();
		}

		// Token: 0x04000364 RID: 868
		private string label01;

		// Token: 0x04000365 RID: 869
		private string label02;

		// Token: 0x04000366 RID: 870
		private TMP_Text m_textMeshPro;

		// Token: 0x020000A2 RID: 162
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003C0 RID: 960 RVA: 0x000458BC File Offset: 0x00043ABC
			public <Start>d__4(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x000040DB File Offset: 0x000022DB
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x000458E8 File Offset: 0x00043AE8
			bool IEnumerator.MoveNext()
			{
				bool flag = this == 0;
				TeleType.<Start>d__4 result = this;
				if (!flag)
				{
					Console.WriteLine("Method not found @24D6540");
					TeleType.<Start>d__4 <Start>d__;
					result = <Start>d__;
				}
				TeleType teleType;
				for (;;)
				{
					teleType = this.<>4__this;
					if (this.<>1__state != 0)
					{
						break;
					}
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					if (this.<>4__this != 0 && teleType.m_textMeshPro != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
						if (teleType.m_textMeshPro != 0)
						{
							TMP_TextInfo textInfo = teleType.m_textMeshPro.textInfo;
							if (textInfo != 0)
							{
								this.<totalVisibleCharacters>5__2 = textInfo.characterCount;
								int num2;
								this.<counter>5__3 = num2;
								if (teleType.m_textMeshPro != 0)
								{
									goto Block_7;
								}
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				return result != null;
				Block_7:
				int maxVisibleCharacters;
				teleType.m_textMeshPro.maxVisibleCharacters = maxVisibleCharacters;
				Console.WriteLine("Method not found @24D67D8");
				WaitForSeconds waitForSeconds;
				float seconds;
				waitForSeconds..ctor(seconds);
				this.<>2__current = waitForSeconds;
				Console.WriteLine("Method not found @24D64EC");
				this.<>1__state = (int)1L;
				bool result2;
				return result2;
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x00045B00 File Offset: 0x00043D00
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x00045B14 File Offset: 0x00043D14
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.TeleType/<Start>d__4::System.Collections.IEnumerator.Reset()

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

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060003C5 RID: 965 RVA: 0x00045B78 File Offset: 0x00043D78
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04000470 RID: 1136
			private int <>1__state;

			// Token: 0x04000471 RID: 1137
			private object <>2__current;

			// Token: 0x04000472 RID: 1138
			public TeleType <>4__this;

			// Token: 0x04000473 RID: 1139
			private int <totalVisibleCharacters>5__2;

			// Token: 0x04000474 RID: 1140
			private int <counter>5__3;
		}
	}
}
