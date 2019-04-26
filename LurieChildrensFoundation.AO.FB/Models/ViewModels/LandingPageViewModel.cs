using EPiServer.Core;

using LurieChildrensFoundation.AO.FB.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO.FB.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="LandingPage"/>.
	/// </summary>
	public class LandingPageViewModel : AOLandingPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		new public static LandingPageViewModel<T> Create<T>(T page) where T : LandingPage
		{
			return new LandingPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="LandingPage"/>.
	/// </summary>
	public class LandingPageViewModel<T> : AOLandingPageViewModel<T> where T : LandingPage
	{
		public LandingPageViewModel(T currentPage) : base(currentPage)
		{
			CurrentPage = currentPage;
		}

		new public T CurrentPage { get; private set; }
		public string ViewModelProperty { get; set; }
	}
}