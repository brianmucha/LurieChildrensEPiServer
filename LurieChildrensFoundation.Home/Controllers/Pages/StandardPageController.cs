using System.Web.Mvc;

using LurieChildrensFoundation._Base.Controllers;
using LurieChildrensFoundation.Home.Models.Pages;
using LurieChildrensFoundation.Home.Models.ViewModels;

namespace LurieChildrensFoundation.Home.Controllers
{
	/// <summary>
	/// This Page Controller provides the implementation for a <see cref="StandardPage"/>.
	/// </summary>
	public class StandardPageController : FndBasePageController<StandardPage>
	{
		public ActionResult Index(StandardPage currentPage)
        {
			var model = StandardPageViewModel.Create(currentPage);
			return View(model);
        }
    }
}