using System.Web.Mvc;
using EPiServer.Web.Routing;

using LurieChildrensFoundation._Base.Models.Pages;
using LurieChildrensFoundation._Base.Models.ViewModels;

namespace LurieChildrensFoundation._Base.Business
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

			IFndBasePageViewModel<FndBasePage> model = viewModel as IFndBasePageViewModel<FndBasePage>;
			if (model != null)
			{
				model.ViewModelPropertyBase = "This value is set in the PageContextActionFilter.";
			}

			/*

			// Snippet from the Alloy project.

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

			*/

		}

		public void OnResultExecuted(ResultExecutedContext filterContext)
		{
		}
	}
}