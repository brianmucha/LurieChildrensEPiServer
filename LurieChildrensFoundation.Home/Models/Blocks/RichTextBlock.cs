using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.Home.Models.Blocks
{
	[ContentType(
		DisplayName = "Rich Text Block Block",
		Description = "", 
		GUID = "164DEC5D-EC93-4552-A4C3-D8316FEEBE01")]
	public class RichTextBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The rich text or HTML content.",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		public virtual XhtmlString Content { get; set; }
	}
}