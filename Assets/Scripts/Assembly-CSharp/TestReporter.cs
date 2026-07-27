using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000054 RID: 84
public class TestReporter : MonoBehaviour
{
	// Token: 0x06000252 RID: 594 RVA: 0x00032F8C File Offset: 0x0003118C
	private void Start()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B130]");
		object obj = (IntPtr)0;
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
		}
		Color color;
		for (;;)
		{
			bool runInBackground = obj != null;
			Console.WriteLine("Unmanaged memory load: [523BD20]");
			object handle = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v31 @ X0_v28 (System.Boolean)+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			Application.runInBackground = runInBackground;
			Console.WriteLine("Unmanaged memory load: [523AFF8]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v50 @ X8_v2+E0]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v53 @ X0_v29+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(handle);
			Console.WriteLine("Unmanaged memory load: [v68 @ X8_v3+E4]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [523B018]");
			object obj5 = (IntPtr)0;
			UnityEngine.Object @object = UnityEngine.Object.FindObjectOfType(typeFromHandle);
			if (@object != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
				Reporter reporter;
				this.reporter = reporter;
				Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			}
			else
			{
				this.reporter = color;
			}
			Console.WriteLine("Unmanaged memory load: [523BD40]");
			object message = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BAC0]");
			object obj6 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v153 @ X0_v37+E4]");
			bool flag5 = (IntPtr)0 == 0;
			if (flag5)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Debug.Log(message);
			Console.WriteLine("Method not found @24D67D8");
			obj6..ctor();
			this.style = obj6;
			Console.WriteLine("Method not found @24D64EC");
			if (this != 0)
			{
				base.alignment = obj6;
				if (this != 0)
				{
					GUIStyleState normal = base.normal;
					if (normal != 0)
					{
						normal.textColor = color;
						if (this != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523BD58]");
		object message2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BD48]");
		object message3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BD50]");
		object message4 = (IntPtr)0;
		base.wordWrap = (color != null);
		object obj7 = 10L;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v253 @ X0_v46+E4]");
			bool flag6 = (IntPtr)0 == 0;
			if (flag6)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Debug.Log(message2);
			Debug.LogWarning(message3);
			Debug.LogError(message4);
			object obj8 = obj7 - 1L;
			obj7 = obj8;
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0003347C File Offset: 0x0003167C
	private void OnDestroy()
	{
		/*
An exception occurred when decompiling this method (06000253)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void TestReporter::OnDestroy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_2B:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000254 RID: 596 RVA: 0x000334C4 File Offset: 0x000316C4
	private void threadLogTest()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00033564 File Offset: 0x00031764
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [523B018]");
		object obj = (IntPtr)0;
		float deltaTime = Time.deltaTime;
		object obj2;
		float num = this.elapsed + obj2;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		this.elapsed = num;
		Console.WriteLine("Unmanaged memory load: [523BD80]");
		object message = (IntPtr)0;
		float num2;
		this.elapsed = num2;
		Console.WriteLine("Unmanaged memory load: [v52 @ X0_v13+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Debug.Log(message);
	}

	// Token: 0x06000256 RID: 598 RVA: 0x000336D0 File Offset: 0x000318D0
	private void OnGUI()
	{
		GUIStyle guistyle;
		IntPtr ptr;
		guistyle.m_Ptr = ptr;
		GUIStyleState normal;
		guistyle.m_Normal = normal;
		GUIStyleState hover;
		guistyle.m_Hover = hover;
		GUIStyleState active;
		guistyle.m_Active = active;
		GUIStyleState focused;
		guistyle.m_Focused = focused;
		GUIStyleState onNormal;
		guistyle.m_OnNormal = onNormal;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ADE0]");
		object obj = (IntPtr)0;
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
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v28 @ X0_v28+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag3 = guistyle == 0;
			bool flag4 = this.reporter;
			if (!flag3)
			{
				break;
			}
			Reporter reporter = this.reporter;
			if (this.reporter != 0)
			{
				if (!(~reporter.show))
				{
					break;
				}
				Console.WriteLine("Unmanaged memory load: [523BB28]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v172 @ X0_v32+E4]");
				bool flag5 = (IntPtr)0 == 0;
				if (flag5)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [523BDB0]");
				object position = (IntPtr)0;
				GUI.Label(position, this.style, guistyle);
				Console.WriteLine("Unmanaged memory load: [523BDC8]");
				object position2 = (IntPtr)0;
				GUI.Label(position2, this.style, guistyle);
				Console.WriteLine("Unmanaged memory load: [523BDC0]");
				object obj3 = (IntPtr)0;
				bool flag6 = obj3 == 0;
				bool flag7 = GUI.Button(obj3, guistyle);
				if (flag6)
				{
					Console.WriteLine("Unmanaged memory load: [523B8D0]");
					object obj4 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v232 @ X0_v37+E4]");
					bool flag8 = (IntPtr)0 == 0;
					if (flag8)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Unmanaged memory load: [523BD98]");
					object sceneName = (IntPtr)0;
					SceneManager.LoadScene(sceneName);
				}
				Console.WriteLine("Unmanaged memory load: [v248 @ X0_v40+E4]");
				bool flag9 = (IntPtr)0 == 0;
				if (flag9)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [523BDD8]");
				object obj5 = (IntPtr)0;
				bool flag10 = obj5 == 0;
				bool flag11 = GUI.Button(obj5, guistyle);
				if (flag10)
				{
					Console.WriteLine("Unmanaged memory load: [523B8D0]");
					object obj6 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v284 @ X0_v43+E4]");
					bool flag12 = (IntPtr)0 == 0;
					if (flag12)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Unmanaged memory load: [523BDB8]");
					object sceneName2 = (IntPtr)0;
					SceneManager.LoadScene(sceneName2);
				}
				Console.WriteLine("Unmanaged memory load: [v300 @ X0_v46+E4]");
				bool flag13 = (IntPtr)0 == 0;
				if (flag13)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [523BDA8]");
				object obj7 = (IntPtr)0;
				bool flag14 = obj7 == 0;
				bool flag15 = GUI.Button(obj7, guistyle);
				if (flag14)
				{
					Console.WriteLine("Unmanaged memory load: [523B8D0]");
					object obj8 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v325 @ X0_v49+E4]");
					bool flag16 = (IntPtr)0 == 0;
					if (flag16)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Unmanaged memory load: [523BDD0]");
					object sceneName3 = (IntPtr)0;
					SceneManager.LoadScene(sceneName3);
				}
				if (this.reporter != 0)
				{
					goto Block_13;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_13:
		float num = this.reporter + 168L;
		Console.WriteLine("Unmanaged memory load: [523BB68]");
		object format = (IntPtr)0;
		string str = num.ToString(format);
		Console.WriteLine("Unmanaged memory load: [523BDA0]");
		object str2 = (IntPtr)0;
		string position3 = str2 + str;
		Console.WriteLine("Unmanaged memory load: [v148 @ X8_v32+E4]");
		bool flag17 = (IntPtr)0 == 0;
		if (flag17)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		GUI.Label(position3, this.style, guistyle);
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00033D28 File Offset: 0x00031F28
	public TestReporter()
	{
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		this.logEverySecond = (1L != 0L);
		int num;
		this.logTestCount = num;
		base..ctor();
	}

	// Token: 0x040002EF RID: 751
	public int logTestCount;

	// Token: 0x040002F0 RID: 752
	public int threadLogTestCount;

	// Token: 0x040002F1 RID: 753
	public bool logEverySecond;

	// Token: 0x040002F2 RID: 754
	private int currentLogTestCount;

	// Token: 0x040002F3 RID: 755
	private Reporter reporter;

	// Token: 0x040002F4 RID: 756
	private GUIStyle style;

	// Token: 0x040002F5 RID: 757
	private Rect rect1;

	// Token: 0x040002F6 RID: 758
	private Rect rect2;

	// Token: 0x040002F7 RID: 759
	private Rect rect3;

	// Token: 0x040002F8 RID: 760
	private Rect rect4;

	// Token: 0x040002F9 RID: 761
	private Rect rect5;

	// Token: 0x040002FA RID: 762
	private Rect rect6;

	// Token: 0x040002FB RID: 763
	private Thread thread;

	// Token: 0x040002FC RID: 764
	private float elapsed;
}
