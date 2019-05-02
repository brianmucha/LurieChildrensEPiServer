using System.Web.Mvc;

using LurieChildrensFoundation.AO._Base.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO._Base.Controllers.Pages
{
	/// <summary>
	/// This Page Controller provides the implementation for a <see cref="AOSidebarPage"/>.
	/// </summary>
	public class AOSidebarPageController<T> : AOBasePageController<T> where T : AOSidebarPage
	{
	}
}
