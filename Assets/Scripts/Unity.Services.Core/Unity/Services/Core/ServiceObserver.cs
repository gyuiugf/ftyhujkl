using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core
{
	public class ServiceObserver<T> : IDisposable
	{
		private IUnityServices m_Registry;

		public T Service { get; private set; }

		public event Action<T> Initialized
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

		public ServiceObserver()
		{
		}

		public ServiceObserver(IUnityServices registry)
		{
		}

		private void Init()
		{
		}

		private void AssignService()
		{
		}

		public void Dispose()
		{
		}
	}
}
