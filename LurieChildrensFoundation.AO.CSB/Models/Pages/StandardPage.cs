using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.CSB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Standard Page", 
		Description = "This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.", 
		GUID = "6A637AD9-ACFC-40B3-9D33-FDFAB12CA412")]
	public class StandardPage : AOBasePage
	{
		[Display(
			GroupName = SystemTabNames.Content,
			Order = 310)]
		[CultureSpecific]
		public virtual ContentArea MainContentArea { get; set; }
	}
}