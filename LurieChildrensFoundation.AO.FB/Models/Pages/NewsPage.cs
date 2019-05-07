using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "News Page", 
		Description = "Used for news pages. Works in conjunction with the News List Block.", 
		GUID = "DB27B5BA-7B4D-4BE9-A2A6-12EE2D3EDD50")]
	[ImageUrl("~/ClientResources/Images/NewsPage.png")]
	public class NewsPage : AONewsPage
	{
	}
}