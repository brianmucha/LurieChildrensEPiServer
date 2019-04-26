using System;
using System.Web.Mvc;

using LurieChildrensFoundation._Base.Controllers;
using LurieChildrensFoundation.AO._Base.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO._Base.Controllers
{

	/// <summary>
	/// This Page Controller provides the common implementation for all Page Types in this solution.
	/// </summary>
	public class AOBasePageController<T> : FndBasePageController<T> where T : AOBasePage
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