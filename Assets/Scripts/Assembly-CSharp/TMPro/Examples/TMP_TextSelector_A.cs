using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro.Examples
{
	// Token: 0x0200006F RID: 111
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x060002C3 RID: 707 RVA: 0x0003B49C File Offset: 0x0003969C
		private void Awake()
		{
			/*
An exception occurred when decompiling this method (060002C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TMPro.Examples.TMP_TextSelector_A::Awake()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_F1:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0003B5A4 File Offset: 0x000397A4
		private void LateUpdate()
		{
			object obj;
			Camera camera = obj - 160L;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				camera = camera;
				bool isHoveringObject;
				this.m_isHoveringObject = isHoveringObject;
				uint nonSerializedVersion;
				camera.m_NonSerializedVersion = nonSerializedVersion;
				if (this.m_TextMeshPro != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
				Console.WriteLine("Method not found @24D67F0");
			}
			Console.WriteLine("Unmanaged memory load: [523BE70]");
			object obj2 = (IntPtr)0;
			RectTransform rectTransform = this.m_TextMeshPro.rectTransform;
			Vector3 mousePosition = Input.mousePosition;
			Camera main = Camera.main;
			Console.WriteLine("Unmanaged memory load: [v131 @ X8_v2+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag2 = camera == 0;
			bool flag3 = TMP_TextUtilities.IsIntersectingRectTransform(rectTransform, main, camera);
			if (flag2)
			{
				this.m_isHoveringObject = (1L != 0L);
			}
			else if (~this.m_isHoveringObject)
			{
				return;
			}
			Vector3 mousePosition2 = Input.mousePosition;
			Camera main2 = Camera.main;
			Console.WriteLine("Unmanaged memory load: [v204 @ X8_v3+E4]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			int num = TMP_TextUtilities.FindIntersectingCharacter(this.m_TextMeshPro, main2, camera, camera != null);
			Vector3 mousePosition3 = Input.mousePosition;
			Console.WriteLine("Unmanaged memory load: [v241 @ X0_v31+E4]");
			bool flag5 = (IntPtr)0 == 0;
			if (flag5)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			int num2 = TMP_TextUtilities.FindIntersectingLink(this.m_TextMeshPro, this.m_Camera, camera);
			Vector3 mousePosition4 = Input.mousePosition;
			Camera main3 = Camera.main;
			Console.WriteLine("Unmanaged memory load: [v182 @ X8_v4+E4]");
			bool flag6 = (IntPtr)0 == 0;
			if (flag6)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			int num3 = TMP_TextUtilities.FindIntersectingWord(this.m_TextMeshPro, main3, camera);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0003B920 File Offset: 0x00039B20
		public void OnPointerEnter(PointerEventData eventData)
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523B018]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523C258]");
			object message = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v24 @ X0_v6+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Debug.Log(message);
			this.m_isHoveringObject = (1L != 0L);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0003BA10 File Offset: 0x00039C10
		public void OnPointerExit(PointerEventData eventData)
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523B018]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523C260]");
			object message = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v24 @ X0_v6+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Debug.Log(message);
			bool isHoveringObject;
			this.m_isHoveringObject = isHoveringObject;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0003BAFC File Offset: 0x00039CFC
		public TMP_TextSelector_A()
		{
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			int lastWordIndex = (int)(~(int)0L);
			this.m_lastWordIndex = lastWordIndex;
			int selectedLink;
			this.m_selectedLink = selectedLink;
			base..ctor();
		}

		// Token: 0x04000391 RID: 913
		private TextMeshPro m_TextMeshPro;

		// Token: 0x04000392 RID: 914
		private Camera m_Camera;

		// Token: 0x04000393 RID: 915
		private bool m_isHoveringObject;

		// Token: 0x04000394 RID: 916
		private int m_selectedLink;

		// Token: 0x04000395 RID: 917
		private int m_lastCharIndex;

		// Token: 0x04000396 RID: 918
		private int m_lastWordIndex;
	}
}
