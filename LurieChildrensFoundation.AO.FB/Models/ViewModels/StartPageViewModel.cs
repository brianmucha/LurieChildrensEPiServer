using EPiServer;

using LurieChildrensFoundation.AO._Base.Models.PropertyTypes;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;
using LurieChildrensFoundation.AO.FB.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="StartPage"/>.
	/// </summary>
	public class StartPageViewModel : AOStartPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		new public static StartPageViewModel<T> Create<T>(T page) where T : StartPage
		{
			return new StartPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="StartPage"/>.
	/// </summary>
	public class StartPageViewModel<T> : AOStartPageViewModel<T> where T : StartPage
	{
		public StartPageViewModel(T currentPage) : base(currentPage)
		{
			CurrentPage = currentPage;
		}

		new public T CurrentPage { get; private set; }
	}
}