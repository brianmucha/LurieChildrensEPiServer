using System.Web.Mvc;

using LurieChildrensFoundation.AO._Base.Controllers.Pages;
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
			var viewModel = SidebarPageViewModel.Create(currentPage);

			// Populate any additional properties in the ViewModel that are not part of the Model.
			viewModel.ViewModelProperty = "This is a ViewModel property populated by the controller.";

			return View(viewModel);
		}
	}
}