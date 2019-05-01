using EPiServer.Core;

using LurieChildrensFoundation.Home.Models.Pages;
using LurieChildrensFoundation._Base.Models.ViewModels;

namespace LurieChildrensFoundation.Home.Models.ViewModels
{

	/// <summary>
	/// Returns a Page View Model for a <see cref="StandardPage"/>.
	/// </summary>
	/// <remarks>
	/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
	/// </remarks>
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
	public class StandardPageViewModel<T> : IFndBasePageViewModel<T> where T : StandardPage
	{
		public StandardPageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; private set; }
		// public LayoutModel Layout { get; set; }
		public IContent Section { get; set; }

		public string ViewModelPropertyBase { get; set; }
	}
}