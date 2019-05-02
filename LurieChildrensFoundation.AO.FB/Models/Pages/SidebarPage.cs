using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Sidebar Page", 
		Description = "Used for basic pages consisting of manually created content such as text, images, and blocks.", 
		GUID = "62B46A19-9872-4BFA-BA53-57E4C1EF2D7B")]
	[ImageUrl("~/ClientResources/Images/SidebarPage.png")]
	public class SidebarPage : AOSidebarPage
	{
	}
}