using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal interface IComponentRegistry
	{
		void RegisterServiceComponent<TComponent>([NotNull] TComponent component);

		TComponent GetServiceComponent<TComponent>();

		bool TryGetServiceComponent<TComponent>(out TComponent component);

		void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
	}
}
