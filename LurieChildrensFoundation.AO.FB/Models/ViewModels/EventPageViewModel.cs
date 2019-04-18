using EPiServer.Core;

using LurieChildrensFoundation.AO.FB.Models.Pages;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO.FB.Models.ViewModels
{

	/// <summary>
	/// Returns a Page View Model for a <see cref="EventPage"/>.
	/// </summary>
	public class EventPageViewModel : AOBasePageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		new public static EventPageViewModel<T> Create<T>(T page) where T : EventPage
		{
			return new EventPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="EventPage"/>.
	/// </summary>
	public class EventPageViewModel<T> : AOBasePageViewModel<T> where T : EventPage
	{
		public EventPageViewModel(T currentPage) : base(currentPage)
		{
			CurrentPage = currentPage;
		}

		new public T CurrentPage { get; private set; }
	}
}