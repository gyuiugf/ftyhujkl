using System;

namespace Firebase.Platform
{
	internal class FirebaseAppPlatform : IFirebaseAppPlatform
	{
		private WeakReference app { get; set; }

		public object AppObject => null;

		internal FirebaseApp App => null;

		public string Name => null;

		public Uri DatabaseUrl => null;

		internal FirebaseAppPlatform(FirebaseApp wrappedApp)
		{
		}
	}
}
