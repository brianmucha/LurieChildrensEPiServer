using System.Web.Mvc;

using EPiServer;
using EPiServer.ServiceLocation;
using EPiServer.Web;

using LurieChildrensFoundation.AO._Base.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO._Base.Business
{
	/// <summary>
	/// Intercepts actions with view models of type <c>IAOBasePageViewModel</c> and populates the Site-Wide Settings properties.
	/// </summary>
	/// <remarks>
	/// This filter frees page controllers from having to care about common properties and other framework components.
	/// This allows the controllers to focus on the specifics for the page types and actions that they handle.
	/// </remarks>
	class PageContextActionFilter : IResultFilter
	{
		public void OnResultExecuting(ResultExecutingContext filterContext)
		{
			var viewModel = filterContext.Controller.ViewData.Model;

			IAOBasePageViewModel<AOBasePage> model = viewModel as IAOBasePageViewModel<AOBasePage>;
			if (model != null)
			{
				model.ViewModelPropertyBase = "This value is set in the PageContextActionFilter.";

				var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
				var startPageContentLink = SiteDefinition.Current.StartPage;
				var startPage = contentLoader.Get<AOStartPage>(startPageContentLink);

				model.TopLinks = startPage.TopLinks;
				model.DonateLink = startPage.DonateLink;
				model.SiteLogo = startPage.SiteLogo;
			}

		}

		public void OnResultExecuted(ResultExecutedContext filterContext)
		{
		}
	}
}