using System.Web.Mvc;

using LurieChildrensFoundation.AO._Base.Controllers.Pages;
using LurieChildrensFoundation.AO._Base.Models.Pages;
using LurieChildrensFoundation.AO.FB.Models.Pages;
using LurieChildrensFoundation.AO.FB.Models.ViewModels;

namespace LurieChildrensFoundation.AO.FB.Controllers
{
	/// <summary>
	/// This Page Controller provides the implementation for a <see cref="StartPage"/>.
	/// </summary>
	public class StartPageController : AOStartPageController<StartPage>
	{
		public ActionResult Index(StartPage currentPage)
		{
			var viewModel = StartPageViewModel.Create(currentPage);

			// Populate any additional properties in the ViewModel that are not part of the Model.
			viewModel.ViewModelProperty = "This is a ViewModel property populated by the controller.";
			viewModel.ViewModelPropertyBase = "This is a ViewModel property populated by the controller.";

			return View(viewModel);
		}
	}
}