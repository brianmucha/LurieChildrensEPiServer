using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Rich Text Block",
		Description = "A freeform content block with formatting options. Provides a WYSIWYG editor for a full-featured rich text editing experience.",
		GUID = "62856765-DA5F-4EDE-B611-F7A574AAB882")]
	[ImageUrl("~/ClientResources/Images/RichTextBlock.png")]
	public class RichTextBlock : AORichTextBlock
	{
	}
}