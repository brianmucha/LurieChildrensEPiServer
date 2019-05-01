using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.CRFJB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Standard Page", 
		Description = "This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.", 
		GUID = "0C180AA1-5565-46D2-9B23-6E6FEB68AA4D")]
	public class StandardPage : AOStandardPage
	{
	}
}