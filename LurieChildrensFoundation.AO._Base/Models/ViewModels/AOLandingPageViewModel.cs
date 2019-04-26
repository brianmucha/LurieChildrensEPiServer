using EPiServer.Core;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO._Base.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="AOLandingPage"/>.
	/// </summary>
	public class AOLandingPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		public static AOLandingPageViewModel<T> Create<T>(T page) where T : AOLandingPage
		{
			return new AOLandingPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="AOLandingPage"/>.
	/// </summary>
	public class AOLandingPageViewModel<T> : IAOBasePageViewModel<T> where T : AOLandingPage
	{
		public AOLandingPageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; set; }
//		public LayoutModel Layout { get; set; }
		public IContent Section { get; set; }

		public string ViewModelPropertyBase { get; set; }
	}
}
