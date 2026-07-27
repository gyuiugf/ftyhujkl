using System;
using System.Collections.Generic;
using UnityEngine;

public class MaxCmpService
{
	private static readonly MaxCmpService _instance;

	private static Action<MaxCmpError> _onCompletedAction;

	private static readonly AndroidJavaClass MaxUnityPluginClass;

	internal static MaxCmpService Instance => null;

	public bool HasSupportedCmp => false;

	private MaxCmpService()
	{
	}

	public void ShowCmpForExistingUser(Action<MaxCmpError> onCompletedAction)
	{
	}

	internal static void NotifyCompletedIfNeeded(Dictionary<string, object> errorProps)
	{
	}
}
