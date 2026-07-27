using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200001B RID: 27
public class Hoop : MonoBehaviour
{
	// Token: 0x060000BD RID: 189 RVA: 0x00011094 File Offset: 0x0000F294
	public void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		bool flag;
		this.wasInside = flag;
		this.scored = flag;
		this.outOfBounds = flag;
		if (this.visuals == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00011164 File Offset: 0x0000F364
	private void OnTriggerStay2D(Collider2D other)
	{
		object obj2;
		object obj = obj2 - 144L;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (other != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AE38]");
				object obj3 = (IntPtr)0;
				Transform transform = other.transform;
				Console.WriteLine("Unmanaged memory load: [v74 @ X8_v2+B8]");
				object obj4 = (IntPtr)0;
				if (obj4 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523ADE0]");
					object obj5 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v118 @ X0_v11+E4]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					bool flag2 = obj == 0;
					UnityEngine.Object x = transform;
					Console.WriteLine("Unmanaged memory load: [v57 @ X8_v4+28]");
					bool flag3 = x == (IntPtr)0;
					if (!flag2)
					{
						return;
					}
					Transform transform2 = other.transform;
					if (transform2 != 0)
					{
						Vector3 position = transform2.position;
						Console.WriteLine("Method not found @2894080");
						if (this != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Bounds bounds = base.bounds;
		Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
		Bounds bounds2 = obj + 32L;
		ref Vector3 point = obj + 68L;
		bool flag4 = obj == 0;
		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+18]");
		IntPtr intPtr = (IntPtr)0;
		bool flag5 = bounds2.Internal_Contains(ref point);
		if (flag4)
		{
			this.wasInside = (1L != 0L);
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00011434 File Offset: 0x0000F634
	private unsafe void OnTriggerExit2D(Collider2D other)
	{
		UnityEngine.Object @object;
		IntPtr intPtr;
		@object.m_CachedPtr = intPtr;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [55920DF]");
		bool flag2 = (IntPtr)0 != 0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			flag2 = (1L != 0L);
		}
		bool flag3 = other == 0;
		bool flag5;
		bool flag4 = flag5;
		UnityEngine.Object object3;
		UnityEngine.Object object2 = object3;
		bool flag7;
		bool flag6 = flag7;
		object obj2;
		object obj = obj2;
		object obj4;
		object obj3 = obj4;
		UnityEngine.Object object4 = other;
		IntPtr intPtr2 = intPtr;
		object obj5 = 1;
		bool flag8 = flag2;
		Collider2D collider2D = other;
		UnityEngine.Object object5 = 50065408L;
		bool flag14;
		bool flag15;
		UnityEngine.Object object6;
		bool flag16;
		object obj11;
		object obj12;
		UnityEngine.Object object7;
		IntPtr intPtr4;
		object obj13;
		bool flag17;
		Collider2D collider2D2;
		UnityEngine.Object object8;
		if (!flag3)
		{
			Console.WriteLine("Unmanaged memory load: [523AE38]");
			IntPtr intPtr3 = (IntPtr)0;
			Transform transform = other.transform;
			void* value = intPtr3.m_value;
			Console.WriteLine("Unmanaged memory load: [v91 @ X8_v1 (System.Void*)+B8]");
			object obj6 = (IntPtr)0;
			bool flag9 = obj6 == 0;
			flag4 = flag5;
			object2 = object3;
			flag6 = flag7;
			obj = obj2;
			obj3 = obj6;
			object4 = @object;
			intPtr2 = intPtr3;
			obj5 = 1;
			flag8 = flag2;
			collider2D = other;
			object5 = 50065408L;
			if (!flag9)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj7 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v109 @ X0_v14+E4]");
				bool flag10 = ~((IntPtr)0 != 0) != 0;
				if (flag10)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag11 = @object == 0;
				UnityEngine.Object x = transform;
				Console.WriteLine("Unmanaged memory load: [v54 @ X8_v3+28]");
				bool flag12 = x == (IntPtr)0;
				object obj8 = !flag11;
				if (obj8 != null || ~this.wasInside)
				{
					return;
				}
				if (~this.entrance)
				{
					goto IL_61D;
				}
				List<SpriteRenderer> list = this.visuals;
				this.scored = (1L != 0L);
				bool flag13 = this.visuals == 0;
				flag4 = flag5;
				object2 = @object;
				Console.WriteLine("Unmanaged memory load: [v109 @ X0_v14+E4]");
				flag6 = ((IntPtr)0 != 0);
				obj = obj7;
				obj3 = obj6;
				Console.WriteLine("Unmanaged memory load: [v54 @ X8_v3+28]");
				object4 = (IntPtr)0;
				intPtr2 = intPtr3;
				obj5 = obj8;
				flag8 = (1L != 0L);
				collider2D = transform;
				Console.WriteLine("Unmanaged memory load: [v54 @ X8_v3+28]");
				object5 = (IntPtr)0;
				if (!flag13)
				{
					object obj9 = flag14;
					Console.WriteLine("Unmanaged memory load: [v65 @ X0_v17 (System.Collections.Generic.List`1<UnityEngine.SpriteRenderer>)+18]");
					object obj10 = obj9 - (IntPtr)0;
					flag15 = flag14;
					object6 = @object;
					Console.WriteLine("Unmanaged memory load: [v109 @ X0_v14+E4]");
					flag16 = ((IntPtr)0 != 0);
					obj11 = obj7;
					obj12 = obj6;
					Console.WriteLine("Unmanaged memory load: [v54 @ X8_v3+28]");
					object7 = (IntPtr)0;
					intPtr4 = intPtr3;
					obj13 = obj10;
					Console.WriteLine("Unmanaged memory load: [v65 @ X0_v17 (System.Collections.Generic.List`1<UnityEngine.SpriteRenderer>)+18]");
					flag17 = ((IntPtr)0 != 0);
					collider2D2 = transform;
					Console.WriteLine("Unmanaged memory load: [523B270]");
					object8 = (IntPtr)0;
					goto IL_345;
				}
			}
		}
		IL_2DE:
		Console.WriteLine("Method not found @24D67E8");
		flag15 = flag4;
		object6 = object2;
		flag16 = flag6;
		obj11 = obj;
		obj12 = obj3;
		object7 = object4;
		intPtr4 = intPtr2;
		obj13 = obj5;
		flag17 = flag8;
		collider2D2 = collider2D;
		object8 = object5;
		IL_345:
		HoopGoal hoopGoal = this.hoopGoal;
		bool flag18 = this.hoopGoal == 0;
		flag4 = flag15;
		object2 = object6;
		flag6 = flag16;
		obj = obj11;
		obj3 = obj12;
		object4 = object7;
		intPtr2 = intPtr4;
		obj5 = obj13;
		flag8 = flag17;
		collider2D = collider2D2;
		object5 = object8;
		if (flag18)
		{
			goto IL_2DE;
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
		if (!(~this.basketball))
		{
			Console.WriteLine("Unmanaged memory load: [523AE28]");
			object obj14 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v126 @ X8_v9+B8]");
			object obj15 = (IntPtr)0;
			bool flag19 = obj15 == 0;
			flag4 = flag15;
			object2 = object6;
			flag6 = flag16;
			Console.WriteLine("Unmanaged memory load: [v114 @ X8_v6+1D8]");
			obj = (IntPtr)0;
			obj3 = obj15;
			Console.WriteLine("Unmanaged memory load: [v114 @ X8_v6+1E0]");
			object4 = (IntPtr)0;
			intPtr2 = intPtr4;
			obj5 = obj13;
			flag8 = this.basketball;
			collider2D = collider2D2;
			object5 = object8;
			if (flag19)
			{
				goto IL_2DE;
			}
			obj15.PlayNetSound();
		}
		else
		{
			Console.WriteLine("Unmanaged memory load: [523AE28]");
			object obj16 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v133 @ X8_v13+B8]");
			object obj17 = (IntPtr)0;
			if (!(~this.scoreSound2))
			{
				bool flag20 = obj17 == 0;
				flag4 = flag15;
				object2 = object6;
				flag6 = this.scoreSound2;
				Console.WriteLine("Unmanaged memory load: [v114 @ X8_v6+1D8]");
				obj = (IntPtr)0;
				obj3 = obj17;
				Console.WriteLine("Unmanaged memory load: [v114 @ X8_v6+1E0]");
				object4 = (IntPtr)0;
				intPtr2 = intPtr4;
				obj5 = obj13;
				flag8 = this.basketball;
				collider2D = collider2D2;
				object5 = object8;
				if (flag20)
				{
					goto IL_2DE;
				}
				obj17.PlayHoopScoreSound2();
			}
			else
			{
				bool flag21 = obj17 == 0;
				flag4 = flag15;
				object2 = object6;
				flag6 = this.scoreSound2;
				Console.WriteLine("Unmanaged memory load: [v114 @ X8_v6+1D8]");
				obj = (IntPtr)0;
				obj3 = obj17;
				Console.WriteLine("Unmanaged memory load: [v114 @ X8_v6+1E0]");
				object4 = (IntPtr)0;
				intPtr2 = intPtr4;
				obj5 = obj13;
				flag8 = this.basketball;
				collider2D = collider2D2;
				object5 = object8;
				if (flag21)
				{
					goto IL_2DE;
				}
				obj17.PlayHoopScoreSound();
			}
		}
		IL_61D:
		this.wasInside = flag14;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003FD3 File Offset: 0x000021D3
	private void Start()
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00011B7C File Offset: 0x0000FD7C
	private void Update()
	{
		/*
An exception occurred when decompiling this method (060000C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Hoop::Update()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_95:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x040000D2 RID: 210
	public bool entrance;

	// Token: 0x040000D3 RID: 211
	private bool wasInside;

	// Token: 0x040000D4 RID: 212
	public HoopGoal hoopGoal;

	// Token: 0x040000D5 RID: 213
	public bool scored;

	// Token: 0x040000D6 RID: 214
	public float border;

	// Token: 0x040000D7 RID: 215
	public Direction direction;

	// Token: 0x040000D8 RID: 216
	public bool outOfBounds;

	// Token: 0x040000D9 RID: 217
	public List<SpriteRenderer> visuals;

	// Token: 0x040000DA RID: 218
	public bool basketball;

	// Token: 0x040000DB RID: 219
	public bool scoreSound2;
}
