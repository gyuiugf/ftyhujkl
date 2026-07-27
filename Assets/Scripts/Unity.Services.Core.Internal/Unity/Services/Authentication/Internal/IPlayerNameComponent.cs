using System;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Authentication.Internal
{
	[RequireImplementors]
	public interface IPlayerNameComponent : IServiceComponent
	{
		string PlayerName { get; }

		event Action<string> PlayerNameChanged;
	}
}
