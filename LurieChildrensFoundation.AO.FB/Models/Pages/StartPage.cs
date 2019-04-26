using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for the start page consisting of a hero block and manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Start Page",
		Description = "Used for main pages consisting of a hero block and manually created content such as text, images, and blocks.",
		GUID = "3D975CBB-5AF6-42B6-89B7-255DCF904A08")]
	[ImageUrl("~/ClientResources/Images/LandingPage.png")]
	public class StartPage : AOStartPage
	{
	}
}