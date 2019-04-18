using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Hero Block",
		Description = "A structured main image block. ",
		GUID = "8F0C943E-58CA-4752-A9C8-961007244455")]
	[ImageUrl("~/ClientResources/Images/HeroBlock.png")]
	public class HeroBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The HTML content for the Hero Block",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		public virtual XhtmlString Content { get; set; }
	}
}