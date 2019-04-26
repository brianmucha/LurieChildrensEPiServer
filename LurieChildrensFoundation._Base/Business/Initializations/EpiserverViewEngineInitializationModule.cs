using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace LurieChildrensFoundation._Base.Models.Initializations
{
	[InitializableModule]
	[ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
	public class ViewEngineInitializationModule : IInitializableModule
	{
		public void Initialize(InitializationEngine context)
		{
			System.Web.Mvc.ViewEngines.Engines.Add(new EpiserverViewEngine());
		}

		public void Uninitialize(InitializationEngine context) { }
	}
}