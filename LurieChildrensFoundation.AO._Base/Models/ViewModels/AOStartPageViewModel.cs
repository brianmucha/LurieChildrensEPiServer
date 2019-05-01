using System;
using EPiServer;
using EPiServer.SpecializedProperties;

using LurieChildrensFoundation.AO._Base.Models.PropertyTypes;
using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO._Base.Models.ViewModels
{
	/// <summary>
	/// Returns a Page View Model for a <see cref="AOStartPage"/>.
	/// </summary>
	public class AOStartPageViewModel
	{
		/// <summary>
		/// Returns a PageViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		public static AOStartPageViewModel<T> Create<T>(T page) where T : AOStartPage
		{
			return new AOStartPageViewModel<T>(page);
		}
	}

	/// <summary>
	/// Defines a Page View Model for a <see cref="AOStartPage"/>.
	/// </summary>
	public class AOStartPageViewModel<T> : IAOBasePageViewModel<T> where T : AOStartPage
	{
		public AOStartPageViewModel(T currentPage)
		{
			CurrentPage = currentPage;
		}

		public T CurrentPage { get; private set; }
		public String ViewModelProperty { get; set; }
		public String ViewModelPropertyBase { get; set; }

		public LinkItemCollection TopLinks { get; set; }
		public AOLinkItemType DonateLink { get; set; }
		public AOSiteLogoType SiteLogo { get; set; }
	}
}
