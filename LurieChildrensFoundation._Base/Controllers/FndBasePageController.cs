using EPiServer.Web.Mvc;

using LurieChildrensFoundation._Base.Models.Pages;

namespace LurieChildrensFoundation._Base.Controllers
{
	/// <summary>
	/// This Page Controller provides the common implementation for all Page Types in this solution.
	/// </summary>
	public abstract class FndBasePageController<T> : PageController<T> where T : FndBasePage
	{

	}
}