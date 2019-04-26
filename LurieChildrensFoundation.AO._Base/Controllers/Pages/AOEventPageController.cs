using System.Web.Mvc;

using LurieChildrensFoundation.AO._Base.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO._Base.Controllers.Pages
{
	/// <summary>
	/// This Page Controller provides the implementation for a <see cref="AOEventPage"/>.
	/// </summary>
	public class AOEventPageController<T> : AOBasePageController<T> where T : AOEventPage
	{
		/*
		public AOBasePageViewModel<T> Create<T>(T currentPage) where T : AOBasePage
		{
			var viewModel = AOBasePageViewModel.Create(currentPage);
			viewModel.ViewModelPropertyBase = "This is a ViewModel property populated by the controller.";

			return viewModel;
		}
		*/
	}
}
