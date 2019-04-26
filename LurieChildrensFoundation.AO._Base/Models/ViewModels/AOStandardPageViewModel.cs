using EPiServer.Core;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO._Base.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="AOStandardPage"/>.
	/// </summary>
	public class AOStandardPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		public static AOStandardPageViewModel<T> Create<T>(T page) where T : AOStandardPage
		{
			return new AOStandardPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="AOStandardPage"/>.
	/// </summary>
	public class AOStandardPageViewModel<T> : IAOBasePageViewModel<T> where T : AOStandardPage
	{
		public AOStandardPageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; set; }
//		public LayoutModel Layout { get; set; }
		public IContent Section { get; set; }

		public string ViewModelPropertyBase { get; set; }
	}
}
