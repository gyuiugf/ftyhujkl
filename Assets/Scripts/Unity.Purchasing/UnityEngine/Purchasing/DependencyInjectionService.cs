using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Purchasing
{
	internal class DependencyInjectionService : IDependencyInjectionService
	{
		private readonly HashSet<object> m_ServiceInstances;

		private readonly HashSet<Type> m_ServiceConcreteTypes;

		public void AddInstance(object instance)
		{
		}

		public void AddService<T>() where T : class
		{
		}

		private void ValidateTypeIsNotAnInterface(Type type)
		{
		}

		private void ValidateTypeIsNotADuplicate(Type type)
		{
		}

		public T GetInstance<T>() where T : class
		{
			return null;
		}

		private object GetInstance(Type type)
		{
			return null;
		}

		private object FindServiceInstance(Type type)
		{
			return null;
		}

		private Type FindConcreteServiceType(Type type)
		{
			return null;
		}

		private object CreateServiceInstance(Type concreteType)
		{
			return null;
		}

		private ConstructorInfo FindConstructorForType(Type concreteType)
		{
			return null;
		}

		private ConstructorInfo HandleMultipleConstructors(ConstructorInfo[] constructors, Type concreteType)
		{
			return null;
		}

		private List<ConstructorInfo> FindInjectableConstructors(ConstructorInfo[] constructors)
		{
			return null;
		}

		private object[] GetParameterInstancesForConstructor(ConstructorInfo constructor)
		{
			return null;
		}
	}
}
