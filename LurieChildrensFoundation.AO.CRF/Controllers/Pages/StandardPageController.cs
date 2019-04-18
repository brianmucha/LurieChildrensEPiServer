using System.Web.Mvc;

using LurieChildrensFoundation.AO._Base.Controllers;
using LurieChildrensFoundation.AO.CRF.Models.Pages;
using LurieChildrensFoundation.AO.CRF.Models.ViewModels;

namespace LurieChildrensFoundation.AO.CRF.Controllers
{
	/// <summary>
	/// This Page Controller provides the implementation for a <see cref="StandardPage"/>.
	/// </summary>
	public class StandardPageController : AOBasePageController<StandardPage>
	{
		public ActionResult Index(StandardPage currentPage)
        {
			var model = StandardPageViewModel.Create(currentPage);
			return View(model);
        }
    }
}