using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.FB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Standard Page", 
		Description = "Used for basic pages consisting of manually created content such as text, images, and blocks.", 
		GUID = "990857D9-8E39-49C3-8ADC-5DB019BC4FFF")]
	[ImageUrl("~/ClientResources/Images/StandardPage.png")]
	public class StandardPage : AOStandardPage
	{

	}
}