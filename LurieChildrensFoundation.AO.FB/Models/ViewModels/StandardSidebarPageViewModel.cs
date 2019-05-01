using EPiServer;

using LurieChildrensFoundation.AO._Base.Models.PropertyTypes;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;
using LurieChildrensFoundation.AO.FB.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="StandardSidebarPage"/>.
	/// </summary>
	public class StandardSidebarPageViewModel : AOStandardPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		new public static StandardSidebarPageViewModel<T> Create<T>(T page) where T : StandardSidebarPage
		{
			return new StandardSidebarPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="StandardPage"/>.
	/// </summary>
	public class StandardSidebarPageViewModel<T> : AOStandardPageViewModel<T> where T : StandardSidebarPage
	{
		public StandardSidebarPageViewModel(T currentPage) : base(currentPage)
		{
			CurrentPage = currentPage;
		}

		new public T CurrentPage { get; private set; }
	}
}