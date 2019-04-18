using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Rich Text Block",
		Description = "A freeform content block with formatting options. Provides a WYSIWYG editor for a full-featured rich text editing experience.",
		GUID = "62856765-DA5F-4EDE-B611-F7A574AAB882")]
	[ImageUrl("~/ClientResources/Images/RichTextBlock.png")]
	public class RichTextBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The HTML content for the Rich Text Block",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		public virtual XhtmlString Content { get; set; }
	}
}