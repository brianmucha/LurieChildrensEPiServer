using System.Web.Mvc;

using EPiServer;
using EPiServer.ServiceLocation;
using EPiServer.Web;

using LurieChildrensFoundation.AO._Base.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO._Base.Business
{
	class PageContextActionFilter : IResultFilter
	{
		public void OnResultExecuting(ResultExecutingContext filterContext)
		{
			var viewModel = filterContext.Controller.ViewData.Model;

			var model = viewModel as IAOBasePageViewModel<AOBasePage>;
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



			/*

				var currentContentLink = filterContext.RequestContext.GetContentLink();

				var layoutModel = model.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);

				var layoutController = filterContext.Controller as IModifyLayout;
				if (layoutController != null)
				{
					layoutController.ModifyLayout(layoutModel);
				}

				model.Layout = layoutModel;

				if (model.Section == null)
				{
					model.Section = _contextFactory.GetSection(currentContentLink);
				}
			}
			*/
		}

		public void OnResultExecuted(ResultExecutedContext filterContext)
		{
		}
	}
}