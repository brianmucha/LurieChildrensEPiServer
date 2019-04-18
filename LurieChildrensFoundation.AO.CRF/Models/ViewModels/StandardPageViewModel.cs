using EPiServer.Core;

using LurieChildrensFoundation.AO.CRF.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO.CRF.Models.ViewModels
{

	/// <summary>
	/// Returns a Page View Model for a <see cref="StandardPage"/>.
	/// </summary>
	public class StandardPageViewModel
	{
		public static StandardPageViewModel<T> Create<T>(T page) where T : StandardPage
		{
			return new StandardPageViewModel<T>(page);
		}
	}
	
	/// <summary>
	/// Defines a Page View Model for a <see cref="StandardPage"/>.
	/// </summary>
	public class StandardPageViewModel<T> : IAOBasePageViewModel<T> where T : StandardPage
	{
		public StandardPageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; private set; }
		// public LayoutModel Layout { get; set; }
		public IContent Section { get; set; }
	}
}