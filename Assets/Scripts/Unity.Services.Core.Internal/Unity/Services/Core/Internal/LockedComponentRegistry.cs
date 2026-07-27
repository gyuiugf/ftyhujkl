using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class LockedComponentRegistry : IComponentRegistry
	{
		private const string k_ErrorMessage = "Component registration has been locked. Make sure to register service components before all packages have finished initializing.";

		[NotNull]
		internal IComponentRegistry Registry { get; }

		public LockedComponentRegistry([NotNull] IComponentRegistry registryToLock)
		{
		}

		public void RegisterServiceComponent<TComponent>(TComponent component)
		{
		}

		public TComponent GetServiceComponent<TComponent>()
		{
			return default(TComponent);
		}

		public bool TryGetServiceComponent<TComponent>(out TComponent component)
		{
			component = default(TComponent);
			return false;
		}

		public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
		{
		}
	}
}
