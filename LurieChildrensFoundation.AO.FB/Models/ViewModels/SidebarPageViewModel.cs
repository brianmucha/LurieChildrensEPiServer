using LurieChildrensFoundation.AO._Base.Models.ViewModels;
using LurieChildrensFoundation.AO.FB.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="SidebarPage"/>.
	/// </summary>
	public class SidebarPageViewModel : AOSidebarPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		new public static SidebarPageViewModel<T> Create<T>(T page) where T : SidebarPage
		{
			return new SidebarPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="SidebarPage"/>.
	/// </summary>
	public class SidebarPageViewModel<T> : AOSidebarPageViewModel<T> where T : SidebarPage
	{
		public SidebarPageViewModel(T currentPage) : base(currentPage)
		{
			CurrentPage = currentPage;
		}

		new public T CurrentPage { get; private set; }
	}
}