using System;
using Google.Play.Core.Internal;
using UnityEngine;

namespace Google.Play.Review.Internal
{
	internal class ReviewPlayServicesTaskManager : IDisposable
	{
		private readonly AndroidJavaObject _javaReviewManager;

		internal ReviewPlayServicesTaskManager()
		{
		}

		public PlayServicesTask<AndroidJavaObject> RequestReviewFlow()
		{
			return null;
		}

		public PlayServicesTask<AndroidJavaObject> LaunchReviewFlow(AndroidJavaObject reviewInfo)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
