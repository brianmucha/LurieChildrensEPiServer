using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.AO._Base.Models.Blocks
{
	/// <summary>
	/// A freeform content block with formatting options. Provides a WYSIWYG editor for a full-featured rich text editing experience.
	/// </summary>
	public class AORichTextBlock : AOBaseBlock
	{
		[Display(
			Name = "Content",
			Description = "The HTML content for the Rich Text Block",
			GroupName = SystemTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		public virtual XhtmlString Content { get; set; }
	}
}