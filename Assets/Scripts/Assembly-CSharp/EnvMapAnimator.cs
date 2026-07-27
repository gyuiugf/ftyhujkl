using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Token: 0x02000048 RID: 72
public class EnvMapAnimator : MonoBehaviour
{
	// Token: 0x060001E2 RID: 482 RVA: 0x00022D48 File Offset: 0x00020F48
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
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
		this.m_material = this;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00022E04 File Offset: 0x00021004
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

	// Token: 0x040001F8 RID: 504
	public Vector3 RotationSpeeds;

	// Token: 0x040001F9 RID: 505
	private TMP_Text m_textMeshPro;

	// Token: 0x040001FA RID: 506
	private Material m_material;

	// Token: 0x0200008A RID: 138
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000379 RID: 889 RVA: 0x00043B24 File Offset: 0x00041D24
		public <Start>d__4(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000040C7 File Offset: 0x000022C7
		void IDisposable.Dispose()
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00043B50 File Offset: 0x00041D50
		bool IEnumerator.MoveNext()
		{
			object obj2;
			object obj = obj2 - 256L;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			EnvMapAnimator envMapAnimator;
			for (;;)
			{
				envMapAnimator = this.<>4__this;
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				Console.WriteLine("Unmanaged memory load: [559212E]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [523AE20]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v55 @ X8_v1+B8]");
				object obj4 = (IntPtr)0;
				float time = Time.time;
				if (this.<>4__this != 0)
				{
					float time2 = Time.time;
					obj = time2;
					Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Object)+2]");
					IntPtr intPtr = (IntPtr)0;
					float time3 = Time.time;
					Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
					ref Vector3 euler = obj + 128L;
					Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
					object rotationSpeeds = envMapAnimator.RotationSpeeds;
					Console.WriteLine("Unmanaged memory load: [v32 @ X20_v2 (EnvMapAnimator)+28]");
					object obj5 = rotationSpeeds * (IntPtr)0;
					Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
					object obj6 = obj5;
					Console.WriteLine("Unmanaged memory load: [DBE06C]");
					object obj7 = obj6 * (IntPtr)0;
					Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
					Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
					Console.WriteLine("Unmanaged memory load: [559212D]");
					bool flag2 = (IntPtr)0 == 0;
					if (flag2)
					{
						Console.WriteLine("Method not found @24D6540");
					}
					ref Matrix4x4 m = this + 40L;
					ref Vector3 pos = obj + 144L;
					ref Quaternion q = obj + 128L;
					ref Vector3 s = obj + 112L;
					Console.WriteLine("Unmanaged memory load: [v215 @ X8_v5+B8]");
					object obj8 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v57 @ X8_v2+8]");
					IntPtr intPtr2 = (IntPtr)0;
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [DBE06C]");
					IntPtr intPtr3 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v102 @ X8_v6+14]");
					IntPtr intPtr4 = (IntPtr)0;
					Matrix4x4.Internal_SetTRS(ref m, ref pos, ref q, ref s);
					if (envMapAnimator.m_material != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
			Matrix4x4 value = obj + 48L;
			Console.WriteLine("Unmanaged memory load: [523B7F0]");
			object name = (IntPtr)0;
			Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
			envMapAnimator.m_material.SetMatrix(name, value);
			this.<>2__current = obj;
			Console.WriteLine("Method not found @24D64EC");
			bool result;
			return result;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00043F58 File Offset: 0x00042158
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00043F6C File Offset: 0x0004216C
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (0600037D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void EnvMapAnimator/<Start>d__4::System.Collections.IEnumerator.Reset()

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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00043FD0 File Offset: 0x000421D0
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000417 RID: 1047
		private int <>1__state;

		// Token: 0x04000418 RID: 1048
		private object <>2__current;

		// Token: 0x04000419 RID: 1049
		public EnvMapAnimator <>4__this;

		// Token: 0x0400041A RID: 1050
		private Matrix4x4 <matrix>5__2;
	}
}
