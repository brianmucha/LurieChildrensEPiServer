using EPiServer.Core;

using LurieChildrensFoundation.Home.Models.Pages;
using LurieChildrensFoundation._Base.Models.ViewModels;

namespace LurieChildrensFoundation.Home.Models.ViewModels
{

	/// <summary>
	/// Returns a Page View Model for a <see cref="EventPage"/>.
	/// </summary>
	public class EventPageViewModel
	{
		public static EventPageViewModel<T> Create<T>(T page) where T : EventPage
		{
			return new EventPageViewModel<T>(page);
		}
	}
	
	/// <summary>
	/// Defines a Page View Model for a <see cref="EventPage"/>.
	/// </summary>
	public class EventPageViewModel<T> : IFndBasePageViewModel<T> where T : EventPage
	{
		public EventPageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; private set; }
		// public LayoutModel Layout { get; set; }
		public IContent Section { get; set; }

		public string ViewModelPropertyBase { get; set; }
	}
}