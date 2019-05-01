using System;
using EPiServer;
using EPiServer.SpecializedProperties;

using LurieChildrensFoundation.AO._Base.Models.PropertyTypes;
using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO._Base.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="AOEventPage"/>.
	/// </summary>
	public class AOEventPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		public static AOEventPageViewModel<T> Create<T>(T page) where T : AOEventPage
		{
			return new AOEventPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="AOEventPage"/>.
	/// </summary>
	public class AOEventPageViewModel<T> : IAOBasePageViewModel<T> where T : AOEventPage
	{
		public AOEventPageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; set; }
		public String ViewModelProperty { get; set; }
		public String ViewModelPropertyBase { get; set; }

		public LinkItemCollection TopLinks { get; set; }
		public AOLinkItemType DonateLink { get; set; }
		public AOSiteLogoType SiteLogo { get; set; }
	}
}