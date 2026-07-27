using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Google.Play.Core.Internal
{
	public class TaskOnFailureListener : AndroidJavaProxy
	{
		public event Action<string, int> OnTaskFailed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public TaskOnFailureListener()
			: base((string)null)
		{
		}

		public void onFailure(AndroidJavaObject exception)
		{
		}
	}
}
