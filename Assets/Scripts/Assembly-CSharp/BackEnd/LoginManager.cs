using System;
using System.Collections.Generic;
using System.Globalization;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;

namespace BackEnd
{
	// Token: 0x0200007B RID: 123
	public class LoginManager : MonoBehaviour
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00040D50 File Offset: 0x0003EF50
		public static LoginManager Instance
		{
			get
			{
				Console.WriteLine("Unmanaged memory load: [523B408]");
				object obj = (IntPtr)0;
				object obj2;
				if (obj2 == null)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [v22 @ X8_v1+B8]");
				return (IntPtr)0;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00040DCC File Offset: 0x0003EFCC
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00040DDC File Offset: 0x0003EFDC
		public int UsernameChangeLimit
		{
			get
			{
				return this;
			}
			set
			{
				int usernameChangeLimit;
				this._usernameChangeLimit = usernameChangeLimit;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00040DF4 File Offset: 0x0003EFF4
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00040E08 File Offset: 0x0003F008
		public UserBackendProfile UserProfileData
		{
			get
			{
				return this._userProfileData;
			}
			set
			{
				this._userProfileData = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00040E2C File Offset: 0x0003F02C
		private void Awake()
		{
			UnityEngine.Object @object;
			IntPtr cachedPtr;
			@object.m_CachedPtr = cachedPtr;
			Console.WriteLine("Unmanaged memory load: [523B408]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [v27 @ X8_v1+B8]");
			object x = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v29 @ X0_v6+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag2 = @object == 0;
			bool flag3 = x != @object;
			if (flag2)
			{
				Console.WriteLine("Unmanaged memory load: [v51 @ X8_v4+B8]");
				object x2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v53 @ X0_v10+E4]");
				bool flag4 = (IntPtr)0 == 0;
				if (flag4)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag5 = @object == 0;
				bool flag6 = x2 != this;
				if (flag5)
				{
					GameObject gameObject = base.gameObject;
					Console.WriteLine("Unmanaged memory load: [v124 @ X8_v6+E4]");
					bool flag7 = (IntPtr)0 == 0;
					if (flag7)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					UnityEngine.Object.Destroy(gameObject);
					return;
				}
			}
			Console.WriteLine("Unmanaged memory load: [v76 @ X8_v8+B8]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			GameObject gameObject2 = base.gameObject;
			Console.WriteLine("Unmanaged memory load: [v97 @ X8_v11+E4]");
			bool flag8 = (IntPtr)0 == 0;
			if (flag8)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000409E File Offset: 0x0000229E
		private void Start()
		{
			/*
An exception occurred when decompiling this method (06000331)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.LoginManager::Start()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Invalid instruction: 2 Invalid \"Jump target not found in method: 0x2601070\"")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000410D8 File Offset: 0x0003F2D8
		private void OnEnable()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj;
			Button button2;
			for (;;)
			{
				Button button = this.closeInputButton;
				if (this.closeInputButton != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523B128]");
					obj = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523C5E8]");
					object method = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					obj..ctor(this, method);
					if (button.m_OnClick != 0)
					{
						button.m_OnClick.AddListener(obj);
						button2 = this.confirmButton;
						if (this.confirmButton != 0)
						{
							Console.WriteLine("Unmanaged memory load: [523C5F0]");
							object method2 = (IntPtr)0;
							Console.WriteLine("Method not found @24D67D8");
							obj..ctor(this, method2);
							if (button2.m_OnClick != 0)
							{
								break;
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			button2.m_OnClick.AddListener(obj);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00041288 File Offset: 0x0003F488
		private void OnDisable()
		{
			/*
An exception occurred when decompiling this method (06000333)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.LoginManager::OnDisable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_BD:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0004135C File Offset: 0x0003F55C
		public void Login(Action onLoginSuccess = null, Action onLoginFailure = null)
		{
			Console.WriteLine("Unmanaged memory load: [523C5D0]");
			object obj = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			object obj3;
			object obj5;
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523C3B8]");
					obj2 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523C5D8]");
					object method = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523B3B0]");
					obj3 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523C5E0]");
					object method2 = (IntPtr)0;
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Unmanaged memory load: [5592131]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D6540");
					}
					Console.WriteLine("Unmanaged memory load: [523B400]");
					object obj4 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v128 @ X8_v4+B8]");
					obj5 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					obj2..ctor(obj, method);
					Console.WriteLine("Method not found @24D67D8");
					obj3..ctor(obj, method2);
					if (obj5 != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			obj5.Login(obj2, obj3);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00041594 File Offset: 0x0003F794
		public void ChangeUsername(Action onSuccess = null, Action<string> onFailure = null)
		{
			Console.WriteLine("Unmanaged memory load: [523C5F8]");
			object obj = (IntPtr)0;
			if (this != 0)
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
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			object obj5;
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					InputField inputField = this.usernameInput;
					if (this.usernameInput != 0)
					{
						string text = inputField.m_Text;
						if (inputField.m_Text != 0)
						{
							if (text._stringLength == 0)
							{
								goto IL_3CC;
							}
							Console.WriteLine("Unmanaged memory load: [523C628]");
							obj2 = (IntPtr)0;
							UpdateUserTitleDisplayNameRequest updateUserTitleDisplayNameRequest = obj2;
							Console.WriteLine("Method not found @24D67D8");
							obj2..ctor();
							Console.WriteLine("Unmanaged memory load: [5592131]");
							bool flag = (IntPtr)0 == 0;
							if (flag)
							{
								Console.WriteLine("Method not found @24D6540");
							}
							Console.WriteLine("Unmanaged memory load: [523B400]");
							object obj3 = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [v192 @ X8_v8+B8]");
							object obj4 = (IntPtr)0;
							if (obj4 != 0 && obj2 != 0)
							{
								Console.WriteLine("Unmanaged memory load: [v54 @ X8_v10+28]");
								IntPtr intPtr = (IntPtr)0;
								Console.WriteLine("Method not found @24D64EC");
								InputField inputField2 = this.usernameInput;
								if (this.usernameInput != 0)
								{
									updateUserTitleDisplayNameRequest.DisplayName = inputField2.m_Text;
									Console.WriteLine("Method not found @24D64EC");
									bool flag2 = this == 0;
									bool flag3 = this.UpdateDisplayNameAllowed();
									if (flag2)
									{
										break;
									}
									UserBackendProfile userProfileData = this._userProfileData;
									if (this._userProfileData != 0 && userProfileData.data != 0)
									{
										Console.WriteLine("Unmanaged memory load: [523C630]");
										object key = (IntPtr)0;
										obj5 = userProfileData.data.get_Item(key);
										if (obj5 != 0)
										{
											goto Block_12;
										}
									}
								}
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C600]");
			object obj6 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523C618]");
			object method = (IntPtr)0;
			obj6..ctor(obj, method);
			Console.WriteLine("Unmanaged memory load: [523B3B0]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Method not found @24D67D8");
			Console.WriteLine("Unmanaged memory load: [523C620]");
			object method2 = (IntPtr)0;
			obj7..ctor(obj, method2);
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v246 @ X0_v44+E4]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj9;
			PlayFabClientAPI.UpdateUserTitleDisplayName(obj2, obj6, obj7, obj9, obj9);
			return;
			IL_3CC:
			Console.WriteLine("Unmanaged memory load: [523C638]");
			object message = (IntPtr)0;
			this.ShowErrorMessage(message);
			return;
			Block_12:
			Console.WriteLine("Unmanaged memory load: [523B7A0]");
			object obj10 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v255 @ X0_v48+E4]");
			bool flag5 = (IntPtr)0 == 0;
			if (flag5)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			DateTime dateTime = obj5 + 16L;
			double value;
			DateTime dateTime2 = dateTime.AddDays(value);
			Console.WriteLine("Unmanaged memory load: [523C608]");
			object obj11 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v273 @ X8_v29+E4]");
			bool flag6 = (IntPtr)0 == 0;
			if (flag6)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			DateTime dateTime3 = obj9 + 8L;
			Console.WriteLine("Unmanaged memory load: [523C648]");
			object format = (IntPtr)0;
			string arg = dateTime3.ToString(format, invariantCulture);
			Console.WriteLine("Unmanaged memory load: [523C640]");
			object format2 = (IntPtr)0;
			string message2 = string.Format(format2, arg);
			this.ShowErrorMessage(message2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00041BF8 File Offset: 0x0003FDF8
		public void SetNickname(string nickname)
		{
			Console.WriteLine("Unmanaged memory load: [5592131]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			UserBackendProfile userProfileData;
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [523B400]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v24 @ X8_v3+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					Console.WriteLine("Method not found @24D64EC");
					userProfileData = this._userProfileData;
					if (this._userProfileData != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			userProfileData.displayName = nickname;
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00041D10 File Offset: 0x0003FF10
		private bool UpdateDisplayNameAllowed()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			bool result;
			object obj6;
			for (;;)
			{
				UserBackendProfile userProfileData = this._userProfileData;
				if (this._userProfileData != 0)
				{
					bool flag = userProfileData.data == 0;
					result = (userProfileData.data != null);
					if (flag)
					{
						break;
					}
					Console.WriteLine("Unmanaged memory load: [523C630]");
					object key = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523C650]");
					object obj = (IntPtr)0;
					bool flag2 = obj == 0;
					bool flag3 = userProfileData.data.ContainsKey(key);
					object obj2 = !flag2;
					result = flag3;
					if (obj2 != null)
					{
						break;
					}
					UserBackendProfile userProfileData2 = this._userProfileData;
					if (this._userProfileData != 0 && userProfileData2.data != 0)
					{
						object obj3 = userProfileData2.data.get_Item(key);
						if (obj3 != 0)
						{
							object obj4;
							bool flag4 = obj4 == 0;
							Console.WriteLine("Unmanaged memory load: [v51 @ X0_v18 (System.Object)+20]");
							bool flag5 = string.IsNullOrEmpty((IntPtr)0);
							object obj5 = !flag4;
							result = flag5;
							if (obj5 == null)
							{
								break;
							}
							UserBackendProfile userProfileData3 = this._userProfileData;
							if (this._userProfileData != 0 && userProfileData3.data != 0)
							{
								obj6 = userProfileData3.data.get_Item(key);
								if (obj6 != 0)
								{
									goto Block_9;
								}
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			return result;
			Block_9:
			Console.WriteLine("Unmanaged memory load: [523B7A0]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v141 @ X0_v23+E4]");
			bool flag6 = (IntPtr)0 == 0;
			if (flag6)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			DateTime dateTime = obj6 + 16L;
			double value;
			DateTime t = dateTime.AddDays(value);
			DateTime utcNow = DateTime.UtcNow;
			return t <= utcNow;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00042050 File Offset: 0x00040250
		public void ShowErrorMessage(string message)
		{
			/*
An exception occurred when decompiling this method (06000338)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.LoginManager::ShowErrorMessage(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_A7:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00042110 File Offset: 0x00040310
		public void OpenUsernamePopup(Action successAction)
		{
			Console.WriteLine("Unmanaged memory load: [523C658]");
			object obj = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Button button2;
			object obj2;
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					if (this.usernamePopup != 0)
					{
						GameObject gameObject = this.usernamePopup.gameObject;
						if (gameObject != 0)
						{
							bool active;
							gameObject.SetActive(active);
							if (this.errorText != 0)
							{
								GameObject gameObject2 = this.errorText.gameObject;
								if (gameObject2 != 0)
								{
									gameObject2.SetActive(active);
									Button button = this.confirmButton;
									if (this.confirmButton != 0 && button.m_OnClick != 0)
									{
										button.m_OnClick.RemoveAllListeners();
										button2 = this.confirmButton;
										if (this.confirmButton != 0)
										{
											Console.WriteLine("Unmanaged memory load: [523B128]");
											obj2 = (IntPtr)0;
											Console.WriteLine("Unmanaged memory load: [523C660]");
											object method = (IntPtr)0;
											Console.WriteLine("Method not found @24D67D8");
											obj2..ctor(obj, method);
											if (button2.m_OnClick != 0)
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
				Console.WriteLine("Method not found @24D67E8");
			}
			button2.m_OnClick.AddListener(obj2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000423A0 File Offset: 0x000405A0
		public LoginManager()
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523C668]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			this._usernameChangeLimit = (int)30L;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			this._userProfileData = obj;
			Console.WriteLine("Method not found @24D64EC");
			base..ctor();
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00042454 File Offset: 0x00040654
		private void <OnEnable>b__18_0()
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523AE28]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					obj2.PlayClickSound();
					if (this.usernamePopup != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			bool active;
			this.usernamePopup.SetActive(active);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0004253C File Offset: 0x0004073C
		private void <OnEnable>b__18_1()
		{
			Action onSuccess;
			Action<string> onFailure;
			this.ChangeUsername(onSuccess, onFailure);
		}

		// Token: 0x040003DC RID: 988
		private static LoginManager _instance;

		// Token: 0x040003DD RID: 989
		public GameObject usernamePopup;

		// Token: 0x040003DE RID: 990
		public InputField usernameInput;

		// Token: 0x040003DF RID: 991
		public Button closeInputButton;

		// Token: 0x040003E0 RID: 992
		public Button confirmButton;

		// Token: 0x040003E1 RID: 993
		public Text errorText;

		// Token: 0x040003E2 RID: 994
		private int _usernameChangeLimit;

		// Token: 0x040003E3 RID: 995
		private UserBackendProfile _userProfileData;

		// Token: 0x020000B8 RID: 184
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x00049D9C File Offset: 0x00047F9C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
				Console.WriteLine("Unmanaged memory load: [523C670]");
				object obj = (IntPtr)0;
				object obj2;
				if (obj2 == null)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				Console.WriteLine("Unmanaged memory load: [v27 @ X8_v1+B8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D64EC");
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00049E54 File Offset: 0x00048054
			internal void <Login>b__20_3(PlayFabError resInfoErr)
			{
				string text;
				int stringLength;
				text._stringLength = stringLength;
				if (resInfoErr != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				while (resInfoErr == 0)
				{
					Console.WriteLine("Method not found @24D67E8");
				}
				string errorMessage = resInfoErr.ErrorMessage;
				Console.WriteLine("Unmanaged memory load: [523B018]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v22 @ X19_v3 (System.String)+38]");
				string str;
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [v22 @ X19_v3 (System.String)+38]");
					str = (IntPtr)0;
				}
				else
				{
					str = text;
				}
				string message = errorMessage + str;
				Console.WriteLine("Unmanaged memory load: [v49 @ X8_v4+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Debug.LogError(message);
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00049FB4 File Offset: 0x000481B4
			internal void <ChangeUsername>b__21_3(PlayFabError resError)
			{
				string text;
				int stringLength;
				text._stringLength = stringLength;
				if (resError != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				while (resError == 0)
				{
					Console.WriteLine("Method not found @24D67E8");
				}
				string errorMessage = resError.ErrorMessage;
				Console.WriteLine("Unmanaged memory load: [523B018]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v22 @ X19_v3 (System.String)+38]");
				string str;
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [v22 @ X19_v3 (System.String)+38]");
					str = (IntPtr)0;
				}
				else
				{
					str = text;
				}
				string message = errorMessage + str;
				Console.WriteLine("Unmanaged memory load: [v49 @ X8_v4+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Debug.LogError(message);
			}

			// Token: 0x040004ED RID: 1261
			public static readonly LoginManager.<>c <>9;

			// Token: 0x040004EE RID: 1262
			public static Action<PlayFabError> <>9__20_3;

			// Token: 0x040004EF RID: 1263
			public static Action<PlayFabError> <>9__21_3;
		}

		// Token: 0x020000B9 RID: 185
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06000423 RID: 1059 RVA: 0x0004A128 File Offset: 0x00048328
			internal void <Login>b__0(LoginResult res)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				PlayerProfileModel playerProfile;
				Action<object> onAccountInfo;
				BackEndManager backEndManager3;
				Action<PlayFabError> onAccountInfoError;
				for (;;)
				{
					Console.WriteLine("Unmanaged memory load: [5592131]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D6540");
					}
					if (res != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523B400]");
						object obj = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v46 @ X8_v2+B8]");
						object obj2 = (IntPtr)0;
						if (obj2 != 0)
						{
							Console.WriteLine("Unmanaged memory load: [res @ X1 (PlayFab.ClientModels.LoginResult)+20]");
							IntPtr intPtr = (IntPtr)0;
							Console.WriteLine("Method not found @24D64EC");
							GetPlayerCombinedInfoResultPayload infoResultPayload = res.InfoResultPayload;
							if (res.InfoResultPayload != 0)
							{
								playerProfile = infoResultPayload.PlayerProfile;
								if (infoResultPayload.PlayerProfile != 0 && this.<>4__this != 0)
								{
									break;
								}
							}
							else
							{
								Console.WriteLine("Unmanaged memory load: [5592131]");
								bool flag2 = (IntPtr)0 == 0;
								if (flag2)
								{
									Console.WriteLine("Method not found @24D6540");
								}
								object obj3 = this + 32L;
								Console.WriteLine("Unmanaged memory load: [v150 @ X8_v6+B8]");
								object obj4 = (IntPtr)0;
								bool flag3 = obj3 == 0;
								object obj5 = !flag3;
								onAccountInfo = obj3;
								if (obj5 == null)
								{
									Console.WriteLine("Unmanaged memory load: [523C678]");
									object obj6 = (IntPtr)0;
									Console.WriteLine("Method not found @24D67D8");
									Console.WriteLine("Unmanaged memory load: [523C688]");
									object method = (IntPtr)0;
									obj6..ctor(this, method);
									this.<>9__2 = obj6;
									Console.WriteLine("Method not found @24D64EC");
									onAccountInfo = obj6;
								}
								Console.WriteLine("Unmanaged memory load: [523C670]");
								object obj7 = (IntPtr)0;
								BackEndManager backEndManager = obj7;
								Console.WriteLine("Unmanaged memory load: [v181 @ X0_v24 (BackEnd.BackEndManager)+E4]");
								bool flag4 = (IntPtr)0 == 0;
								object obj8 = !flag4;
								BackEndManager backEndManager2 = backEndManager;
								if (obj8 == null)
								{
									Console.WriteLine("Method not found @24D66BC");
									backEndManager2 = obj7;
								}
								Console.WriteLine("Unmanaged memory load: [v192 @ X0_v26 (BackEnd.BackEndManager)+B8]");
								object obj9 = (IntPtr)0;
								Console.WriteLine("Unmanaged memory load: [v196 @ X8_v13+8]");
								bool flag5 = (IntPtr)0 == 0;
								object obj10 = !flag5;
								backEndManager3 = backEndManager2;
								Console.WriteLine("Unmanaged memory load: [v196 @ X8_v13+8]");
								onAccountInfoError = (IntPtr)0;
								if (obj10 == null)
								{
									Console.WriteLine("Unmanaged memory load: [v192 @ X0_v26 (BackEnd.BackEndManager)+E4]");
									bool flag6 = (IntPtr)0 == 0;
									object obj11 = !flag6;
									object @object = obj9;
									if (obj11 == null)
									{
										Console.WriteLine("Method not found @24D66BC");
										Console.WriteLine("Unmanaged memory load: [v228 @ X8_v14+B8]");
										@object = (IntPtr)0;
									}
									Console.WriteLine("Unmanaged memory load: [523B3B0]");
									object obj12 = (IntPtr)0;
									Console.WriteLine("Method not found @24D67D8");
									Console.WriteLine("Unmanaged memory load: [523C680]");
									object method2 = (IntPtr)0;
									obj12..ctor(@object, method2);
									Console.WriteLine("Method not found @24D64EC");
									Console.WriteLine("Unmanaged memory load: [v211 @ X8_v19+B8]");
									backEndManager3 = (IntPtr)0;
									onAccountInfoError = obj12;
								}
								if (obj4 != 0)
								{
									goto Block_9;
								}
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				this.<>4__this.SetNickname(playerProfile.DisplayName);
				return;
				Block_9:
				BackEndManager backEndManager4 = backEndManager3;
				Console.WriteLine("Unmanaged memory load: [res @ X1 (PlayFab.ClientModels.LoginResult)+20]");
				backEndManager4.GetUserInfo((IntPtr)0, onAccountInfo, onAccountInfoError);
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x0004A5FC File Offset: 0x000487FC
			internal void <Login>b__2(GetAccountInfoResult resInfo)
			{
				/*
An exception occurred when decompiling this method (06000424)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.LoginManager/<>c__DisplayClass20_0::<Login>b__2(PlayFab.ClientModels.GetAccountInfoResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_B4:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x0004A6C8 File Offset: 0x000488C8
			internal void <Login>b__1(PlayFabError resErr)
			{
				string text;
				int stringLength;
				text._stringLength = stringLength;
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				while (resErr == 0)
				{
					Console.WriteLine("Method not found @24D67E8");
				}
				string errorMessage = resErr.ErrorMessage;
				Console.WriteLine("Unmanaged memory load: [523B018]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v25 @ X20_v3 (System.String)+38]");
				string str;
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [v25 @ X20_v3 (System.String)+38]");
					str = (IntPtr)0;
				}
				else
				{
					str = text;
				}
				string message = errorMessage + str;
				Console.WriteLine("Unmanaged memory load: [v73 @ X8_v4+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Debug.LogError(message);
				Action action = this.onLoginFailure;
				if (this.onLoginFailure != 0)
				{
					Console.WriteLine("Indirect call: 74 IndirectCall [v52 @ X8_v5 (System.Action)+18] (should have been resolved before IL gen)");
				}
			}

			// Token: 0x040004F0 RID: 1264
			public LoginManager <>4__this;

			// Token: 0x040004F1 RID: 1265
			public Action onLoginFailure;

			// Token: 0x040004F2 RID: 1266
			public Action<GetAccountInfoResult> <>9__2;
		}

		// Token: 0x020000BA RID: 186
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06000427 RID: 1063 RVA: 0x0004A874 File Offset: 0x00048A74
			internal void <ChangeUsername>b__0(UpdateUserTitleDisplayNameResult res)
			{
				Console.WriteLine("Unmanaged memory load: [523C690]");
				object obj = (IntPtr)0;
				if (this != 0)
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
				}
				InputField usernameInput;
				for (;;)
				{
					object obj2 = obj;
					Console.WriteLine("Method not found @24D67D8");
					obj..ctor();
					if (obj != 0)
					{
						Console.WriteLine("Method not found @24D64EC");
						Console.WriteLine("Method not found @24D64EC");
						LoginManager loginManager = this.<>4__this;
						if (this.<>4__this != 0)
						{
							UserBackendProfile userProfileData = loginManager._userProfileData;
							if (loginManager._userProfileData != 0)
							{
								bool flag2;
								bool flag = !flag2;
								bool flag3 = string.IsNullOrEmpty(userProfileData.displayName);
								bool active = flag2;
								if (!flag)
								{
									Console.WriteLine("Unmanaged memory load: [523BCB8]");
									object obj3 = (IntPtr)0;
									Console.WriteLine("Method not found @24D67D8");
									obj3..ctor();
									if (obj2 == 0 || obj3 == 0)
									{
										goto IL_4BC;
									}
									Console.WriteLine("Unmanaged memory load: [523C630]");
									object obj4 = (IntPtr)0;
									Dictionary<object, object> dictionary = obj3;
									object key = obj4;
									Console.WriteLine("Unmanaged memory load: [v83 @ X8_v8+20]");
									dictionary.set_Item(key, (IntPtr)0);
									Console.WriteLine("Unmanaged memory load: [5592131]");
									bool flag4 = (IntPtr)0 == 0;
									if (flag4)
									{
										Console.WriteLine("Method not found @24D6540");
									}
									Console.WriteLine("Unmanaged memory load: [523B400]");
									object obj5 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [v233 @ X8_v11+B8]");
									object obj6 = (IntPtr)0;
									if (obj6 == 0)
									{
										goto IL_4BC;
									}
									Console.WriteLine("Unmanaged memory load: [523C698]");
									object obj7 = (IntPtr)0;
									Console.WriteLine("Method not found @24D67D8");
									Console.WriteLine("Unmanaged memory load: [523C6B0]");
									object method = (IntPtr)0;
									obj7..ctor(obj, method);
									Console.WriteLine("Unmanaged memory load: [523C670]");
									object obj8 = (IntPtr)0;
									BackEndManager backEndManager = obj8;
									Console.WriteLine("Unmanaged memory load: [v277 @ X0_v34 (BackEnd.BackEndManager)+E4]");
									bool flag5 = (IntPtr)0 == 0;
									object obj9 = !flag5;
									BackEndManager backEndManager2 = backEndManager;
									if (obj9 == null)
									{
										Console.WriteLine("Method not found @24D66BC");
										backEndManager2 = obj8;
									}
									Console.WriteLine("Unmanaged memory load: [v282 @ X0_v36 (BackEnd.BackEndManager)+B8]");
									object obj10 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [v286 @ X8_v16+10]");
									bool flag6 = (IntPtr)0 == 0;
									object obj11 = !flag6;
									BackEndManager backEndManager3 = backEndManager2;
									Console.WriteLine("Unmanaged memory load: [v286 @ X8_v16+10]");
									Action<PlayFabError> onUpdateUserDataError = (IntPtr)0;
									if (obj11 == null)
									{
										Console.WriteLine("Unmanaged memory load: [v282 @ X0_v36 (BackEnd.BackEndManager)+E4]");
										bool flag7 = (IntPtr)0 == 0;
										object obj12 = !flag7;
										object @object = obj10;
										if (obj12 == null)
										{
											Console.WriteLine("Method not found @24D66BC");
											Console.WriteLine("Unmanaged memory load: [v320 @ X8_v17+B8]");
											@object = (IntPtr)0;
										}
										Console.WriteLine("Unmanaged memory load: [523B3B0]");
										object obj13 = (IntPtr)0;
										Console.WriteLine("Method not found @24D67D8");
										Console.WriteLine("Unmanaged memory load: [523C6A8]");
										object method2 = (IntPtr)0;
										obj13..ctor(@object, method2);
										Console.WriteLine("Method not found @24D64EC");
										Console.WriteLine("Unmanaged memory load: [v302 @ X8_v22+B8]");
										backEndManager3 = (IntPtr)0;
										onUpdateUserDataError = obj13;
									}
									BackEndManager backEndManager4 = backEndManager3;
									Console.WriteLine("Unmanaged memory load: [v86 @ X8_v13+28]");
									backEndManager4.SetUserData((IntPtr)0, obj3, obj7, onUpdateUserDataError);
									Console.WriteLine("Unmanaged memory load: [v86 @ X8_v13+28]");
									active = ((IntPtr)0 != 0);
								}
								LoginManager loginManager2 = this.<>4__this;
								if (this.<>4__this != 0 && loginManager2.usernamePopup != 0)
								{
									loginManager2.usernamePopup.SetActive(active);
									LoginManager loginManager3 = this.<>4__this;
									if (this.<>4__this != 0)
									{
										usernameInput = loginManager3.usernameInput;
										if (loginManager3.usernameInput != 0)
										{
											break;
										}
									}
								}
							}
						}
					}
					IL_4BC:
					Console.WriteLine("Method not found @24D67E8");
				}
				this.<>4__this.SetNickname(usernameInput.m_Text);
				Action action = this.onSuccess;
				if (this.onSuccess != 0)
				{
					Console.WriteLine("Indirect call: 270 IndirectCall [v147 @ X8_v27 (System.Action)+18] (should have been resolved before IL gen)");
				}
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x0004AE94 File Offset: 0x00049094
			internal void <ChangeUsername>b__1(PlayFabError resErr)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				for (;;)
				{
					LoginManager loginManager = this.<>4__this;
					if (this.<>4__this != 0 && loginManager.confirmButton != 0)
					{
						loginManager.confirmButton.enabled = (resErr != null);
						if (resErr != 0 && this.<>4__this != 0)
						{
							break;
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				Console.WriteLine("Unmanaged memory load: [523C6D0]");
				object message = (IntPtr)0;
				this.<>4__this.ShowErrorMessage(message);
			}

			// Token: 0x040004F3 RID: 1267
			public LoginManager <>4__this;

			// Token: 0x040004F4 RID: 1268
			public Action onSuccess;
		}

		// Token: 0x020000BB RID: 187
		private sealed class <>c__DisplayClass21_1
		{
			// Token: 0x0600042A RID: 1066 RVA: 0x0004B008 File Offset: 0x00049208
			internal void <ChangeUsername>b__2(UpdateUserDataResult res2)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				for (;;)
				{
					LoginManager.<>c__DisplayClass21_0 cs$<>8__locals = this.CS$<>8__locals1;
					if (this.CS$<>8__locals1 != 0)
					{
						LoginManager <>4__this = cs$<>8__locals.<>4__this;
						if (cs$<>8__locals.<>4__this != 0)
						{
							UserBackendProfile userProfileData = <>4__this._userProfileData;
							if (<>4__this._userProfileData != 0)
							{
								Console.WriteLine("Unmanaged memory load: [523C6E0]");
								object obj = (IntPtr)0;
								Console.WriteLine("Method not found @24D67D8");
								obj..ctor();
								if (userProfileData.data != 0)
								{
									Console.WriteLine("Unmanaged memory load: [523C630]");
									object key = (IntPtr)0;
									userProfileData.data.set_Item(key, obj);
									LoginManager.<>c__DisplayClass21_0 cs$<>8__locals2 = this.CS$<>8__locals1;
									if (this.CS$<>8__locals1 != 0)
									{
										LoginManager <>4__this2 = cs$<>8__locals2.<>4__this;
										if (cs$<>8__locals2.<>4__this != 0)
										{
											UserBackendProfile userProfileData2 = <>4__this2._userProfileData;
											if (<>4__this2._userProfileData != 0 && userProfileData2.data != 0)
											{
												object obj2 = userProfileData2.data.get_Item(key);
												UpdateUserTitleDisplayNameResult updateUserTitleDisplayNameResult = this.res;
												if (this.res != 0 && obj2 != 0)
												{
													string displayName = updateUserTitleDisplayNameResult.DisplayName;
													Console.WriteLine("Method not found @24D64EC");
													LoginManager.<>c__DisplayClass21_0 cs$<>8__locals3 = this.CS$<>8__locals1;
													if (this.CS$<>8__locals1 != 0)
													{
														LoginManager <>4__this3 = cs$<>8__locals3.<>4__this;
														if (cs$<>8__locals3.<>4__this != 0)
														{
															UserBackendProfile userProfileData3 = <>4__this3._userProfileData;
															if (<>4__this3._userProfileData != 0 && userProfileData3.data != 0)
															{
																Console.WriteLine("Unmanaged memory load: [523B7A0]");
																object obj3 = (IntPtr)0;
																object obj4 = userProfileData3.data.get_Item(key);
																Console.WriteLine("Unmanaged memory load: [v65 @ X8_v14+E4]");
																bool flag = (IntPtr)0 == 0;
																if (flag)
																{
																	Console.WriteLine("Method not found @24D66BC");
																}
																DateTime utcNow = DateTime.UtcNow;
																if (obj4 != 0)
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
			}

			// Token: 0x040004F5 RID: 1269
			public UpdateUserTitleDisplayNameResult res;

			// Token: 0x040004F6 RID: 1270
			public LoginManager.<>c__DisplayClass21_0 CS$<>8__locals1;
		}

		// Token: 0x020000BC RID: 188
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x0600042C RID: 1068 RVA: 0x0004B410 File Offset: 0x00049610
			internal void <OpenUsernamePopup>b__0()
			{
				/*
An exception occurred when decompiling this method (0600042C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.LoginManager/<>c__DisplayClass25_0::<OpenUsernamePopup>b__0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_35:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

			// Token: 0x040004F7 RID: 1271
			public LoginManager <>4__this;

			// Token: 0x040004F8 RID: 1272
			public Action successAction;
		}
	}
}
