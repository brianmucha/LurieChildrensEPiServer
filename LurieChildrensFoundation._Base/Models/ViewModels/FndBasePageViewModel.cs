using EPiServer.Core;
using LurieChildrensFoundation._Base.Models.Pages;

namespace LurieChildrensFoundation._Base.Models.ViewModels
{
	public class FndBasePageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		public FndBasePageViewModel<T> Create<T>(T page) where T : FndBasePage
		{
			return new FndBasePageViewModel<T>(page);
		}
	}

	public class FndBasePageViewModel<T> : IFndBasePageViewModel<T> where T : FndBasePage
	{
		public FndBasePageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; private set; }
//		public LayoutModel Layout { get; set; }
		public IContent Section { get; set; }
	}
}
