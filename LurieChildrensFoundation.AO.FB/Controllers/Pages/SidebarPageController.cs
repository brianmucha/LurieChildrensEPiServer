using System.Web.Mvc;

using LurieChildrensFoundation.AO._Base.Controllers.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;
using LurieChildrensFoundation.AO.FB.Models.Pages;
using LurieChildrensFoundation.AO.FB.Models.ViewModels;

namespace LurieChildrensFoundation.AO.FB.Controllers
{
	/// <summary>
	/// This Page Controller provides the implementation for a <see cref="SidebarPage"/>.
	/// </summary>
	public class SidebarPageController : AOSidebarPageController<SidebarPage>
	{
		public ActionResult Index(SidebarPage currentPage)
		{
			/*
			var controller = new AOBasePageController<SidebarPage>();
			var viewModel = controller.Create<SidebarPage>(currentPage) as SidebarPageViewModel<SidebarPage>;  // Casts as null
			viewModel.ViewModelProperty = "This is a ViewModel property populated by the controller.";
			*/

			var viewModel = SidebarPageViewModel.Create(currentPage);

			// Populate any additional properties in the ViewModel that are not part of the Model.
			viewModel.ViewModelPropertyBase = "This is a ViewModel property populated by the controller.";
			viewModel.ViewModelProperty = "This is a ViewModel property populated by the controller.";

			return View(viewModel);
		}
	}
}