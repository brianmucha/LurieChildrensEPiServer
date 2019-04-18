using System.ComponentModel.DataAnnotations;
using EPiServer.Core ;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for main pages consisting of a hero block and manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Landing Page", 
		Description = "Used for main pages consisting of a hero block and manually created content such as text, images, and blocks.", 
		GUID = "62CF5EAD-85B2-41C0-898B-4951924C5CD1")]
	[ImageUrl("~/ClientResources/Images/LandingPage.png")]
	public class LandingPage : AOLandingPage
	{

	}
}