using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation._Base.Models.Pages;

namespace LurieChildrensFoundation.Home.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Standard Page", 
		Description = "This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.", 
		GUID = "269689d0-484a-486e-aa95-f9f77710242d")]
	public class StandardPage : FndBasePage
	{

	}
}