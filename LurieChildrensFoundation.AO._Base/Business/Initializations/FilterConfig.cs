using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace LurieChildrensFoundation.AO._Base.Business.Initializations
{
	[ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
	public class FilterConfig : IInitializableModule
	{
		public void Initialize(InitializationEngine context)
		{
			GlobalFilters.Filters.Add(ServiceLocator.Current.GetInstance<PageContextActionFilter>());
		}

		public void Uninitialize(InitializationEngine context)
		{
		}

		public void Preload(string[] parameters)
		{
		}
	}
}