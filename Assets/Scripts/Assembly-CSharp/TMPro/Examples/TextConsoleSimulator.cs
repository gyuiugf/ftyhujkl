using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000067 RID: 103
	public class TextConsoleSimulator : MonoBehaviour
	{
		// Token: 0x0600029E RID: 670 RVA: 0x0003830C File Offset: 0x0003650C
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

		// Token: 0x0600029F RID: 671 RVA: 0x000383BC File Offset: 0x000365BC
		private void Start()
		{
			IEnumerator routine = this.RevealCharacters(this.m_TextComponent);
			base.StartCoroutine(routine);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000383F4 File Offset: 0x000365F4
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
				Console.WriteLine("Unmanaged memory load: [523C080]");
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

		// Token: 0x060002A1 RID: 673 RVA: 0x00038578 File Offset: 0x00036778
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
				Console.WriteLine("Unmanaged memory load: [523C080]");
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

		// Token: 0x060002A2 RID: 674 RVA: 0x000386FC File Offset: 0x000368FC
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
			this.hasTextChanged = (1L != 0L);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00038718 File Offset: 0x00036918
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Method not found @24D67D8");
			object obj;
			obj..ctor();
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D64EC");
			return obj;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000387BC File Offset: 0x000369BC
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			if (textComponent != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Method not found @24D67D8");
			object obj;
			obj..ctor();
			Console.WriteLine("Method not found @24D64EC");
			return obj;
		}

		// Token: 0x04000367 RID: 871
		private TMP_Text m_TextComponent;

		// Token: 0x04000368 RID: 872
		private bool hasTextChanged;

		// Token: 0x020000A3 RID: 163
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003C6 RID: 966 RVA: 0x00045B8C File Offset: 0x00043D8C
			public <RevealCharacters>d__7(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x000040DD File Offset: 0x000022DD
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00045BB8 File Offset: 0x00043DB8
			bool IEnumerator.MoveNext()
			{
				/*
An exception occurred when decompiling this method (060003C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean TMPro.Examples.TextConsoleSimulator/<RevealCharacters>d__7::MoveNext()

 ---> System.Exception: Inconsistent stack size at IL_A8
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x00045D60 File Offset: 0x00043F60
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00045D74 File Offset: 0x00043F74
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.TextConsoleSimulator/<RevealCharacters>d__7::System.Collections.IEnumerator.Reset()

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

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060003CB RID: 971 RVA: 0x00045DD8 File Offset: 0x00043FD8
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04000475 RID: 1141
			private int <>1__state;

			// Token: 0x04000476 RID: 1142
			private object <>2__current;

			// Token: 0x04000477 RID: 1143
			public TMP_Text textComponent;

			// Token: 0x04000478 RID: 1144
			public TextConsoleSimulator <>4__this;

			// Token: 0x04000479 RID: 1145
			private TMP_TextInfo <textInfo>5__2;

			// Token: 0x0400047A RID: 1146
			private int <totalVisibleCharacters>5__3;

			// Token: 0x0400047B RID: 1147
			private int <visibleCount>5__4;
		}

		// Token: 0x020000A4 RID: 164
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003CC RID: 972 RVA: 0x00045DEC File Offset: 0x00043FEC
			public <RevealWords>d__8(int <>1__state)
			{
				int num;
				this.<>1__state = num;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x000040DF File Offset: 0x000022DF
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00045E18 File Offset: 0x00044018
			bool IEnumerator.MoveNext()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				for (;;)
				{
					int num = (int)(~(int)0L);
					this.<>1__state = num;
					Console.WriteLine("Not implemented instruction: Instruction SDIV not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction MSUB not yet implemented.");
					object obj;
					if (obj == 0)
					{
						int num2;
						this.<visibleCount>5__5 = num2;
					}
					if (this.textComponent != 0)
					{
						break;
					}
					Console.WriteLine("Method not found @24D67E8");
					Console.WriteLine("Method not found @24D67F0");
				}
				int maxVisibleCharacters;
				this.textComponent.maxVisibleCharacters = maxVisibleCharacters;
				Console.WriteLine("Method not found @24D67D8");
				WaitForSeconds waitForSeconds;
				float seconds;
				waitForSeconds..ctor(seconds);
				this.<>2__current = waitForSeconds;
				Console.WriteLine("Method not found @24D64EC");
				this.<>1__state = (int)1L;
				bool result;
				return result;
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060003CF RID: 975 RVA: 0x00045F7C File Offset: 0x0004417C
			object IEnumerator<object>.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00045F90 File Offset: 0x00044190
			void IEnumerator.Reset()
			{
				/*
An exception occurred when decompiling this method (060003D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.TextConsoleSimulator/<RevealWords>d__8::System.Collections.IEnumerator.Reset()

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

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x00045FF4 File Offset: 0x000441F4
			object IEnumerator.Current
			{
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0400047C RID: 1148
			private int <>1__state;

			// Token: 0x0400047D RID: 1149
			private object <>2__current;

			// Token: 0x0400047E RID: 1150
			public TMP_Text textComponent;

			// Token: 0x0400047F RID: 1151
			private int <totalWordCount>5__2;

			// Token: 0x04000480 RID: 1152
			private int <totalVisibleCharacters>5__3;

			// Token: 0x04000481 RID: 1153
			private int <counter>5__4;

			// Token: 0x04000482 RID: 1154
			private int <visibleCount>5__5;
		}
	}
}
