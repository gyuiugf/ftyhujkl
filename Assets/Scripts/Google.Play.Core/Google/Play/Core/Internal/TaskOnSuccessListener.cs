using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Google.Play.Core.Internal
{
	public class TaskOnSuccessListener<TAndroidJava> : AndroidJavaProxy
	{
		public event Action<TAndroidJava> OnTaskSucceeded
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

		public TaskOnSuccessListener()
			: base((string)null)
		{
		}

		public void onSuccess(TAndroidJava result)
		{
		}
	}
}
