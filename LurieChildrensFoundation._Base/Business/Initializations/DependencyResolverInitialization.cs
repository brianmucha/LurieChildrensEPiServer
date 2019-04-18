using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

using LurieChildrensFoundation._Base.Business.Rendering;

namespace LurieChildrensFoundation._Base.Business.Initialization
{
	[InitializableModule]
	public class DependencyResolverInitialization : IConfigurableModule
	{
		public void ConfigureContainer(ServiceConfigurationContext context)
		{
			context.ConfigurationComplete += (o, e) =>
			{
				//Register custom implementations that should be used in favour of the default implementations
				context.Services.AddTransient<IContentRenderer, ErrorHandlingContentRenderer>();
			};
		}

		public void Initialize(InitializationEngine context)
		{
			DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
		}

		public void Uninitialize(InitializationEngine context)
		{
		}

		public void Preload(string[] parameters)
		{
		}
	}

	public class ServiceLocatorDependencyResolver : IDependencyResolver
	{
		readonly IServiceLocator _serviceLocator;

		public ServiceLocatorDependencyResolver(IServiceLocator serviceLocator)
		{
			_serviceLocator = serviceLocator;
		}

		public object GetService(Type serviceType)
		{
			if (serviceType.IsInterface || serviceType.IsAbstract)
			{
				return GetInterfaceService(serviceType);
			}
			return GetConcreteService(serviceType);
		}

		private object GetConcreteService(Type serviceType)
		{
			try
			{
				// Can't use TryGetInstance here because it won’t create concrete types
				return _serviceLocator.GetInstance(serviceType);
			}
			catch (ActivationException)
			{
				return null;
			}
		}

		private object GetInterfaceService(Type serviceType)
		{
			object instance;
			return _serviceLocator.TryGetExistingInstance(serviceType, out instance) ? instance : null;
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return _serviceLocator.GetAllInstances(serviceType).Cast<object>();
		}
	}

}
