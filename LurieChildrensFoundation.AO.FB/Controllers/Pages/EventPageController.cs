using System.Web.Mvc;

using LurieChildrensFoundation.AO._Base.Controllers;
using LurieChildrensFoundation.AO.FB.Models.Pages;
using LurieChildrensFoundation.AO.FB.Models.ViewModels;

namespace LurieChildrensFoundation.AO.FB.Controllers
{
	/// <summary>
	/// This Page Controller provides the implementation for a <see cref="EventPage"/>.
	/// </summary>
	public class EventPageController : AOBasePageController<EventPage>
	{
		public ActionResult Index(StandardPage currentPage)
		{
			var viewModel = StandardPageViewModel.Create(currentPage);

			// Populate any additional properties in the ViewModel that are not part of the Model.
			// viewModel.TestPropertyTwo = "This is a ViewModel property populated by the controller.";

			return View(viewModel);
		}
	}
}