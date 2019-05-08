using LurieChildrensFoundation.AO._Base.Models.ViewModels;
using LurieChildrensFoundation.AO.FB.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="NewsPage"/>.
	/// </summary>
	public class NewsPageViewModel : AONewsPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		new public static NewsPageViewModel<T> Create<T>(T page) where T : NewsPage
		{
			return new NewsPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="NewsPage"/>.
	/// </summary>
	public class NewsPageViewModel<T> : AONewsPageViewModel<T> where T : NewsPage
	{
		public NewsPageViewModel(T currentPage) : base(currentPage)
		{
			CurrentPage = currentPage;
		}

		new public T CurrentPage { get; private set; }
	}
}