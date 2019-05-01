using System.Web.Mvc;
using EPiServer.Web.Routing;

using LurieChildrensFoundation._Base.Models.Pages;
using LurieChildrensFoundation._Base.Models.ViewModels;

namespace LurieChildrensFoundation._Base.Business
{
	class PageContextActionFilter : IResultFilter
	{
		public void OnResultExecuting(ResultExecutingContext filterContext)
		{
			var viewModel = filterContext.Controller.ViewData.Model;

			var model = viewModel as IFndBasePageViewModel<FndBasePage>;
			if (model != null)
			{
				model.ViewModelPropertyBase = "This value is set in the PageContextActionFilter.";

				// model.SiteLogo = ;
				// model.DonateLink = ;
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