using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Blocks
{
	/// <summary>
	/// A structured image block with optional caption.
	/// </summary>
	public class AOImageBlock : AOBaseBlock
	{
		[Display(
			Name = "Image",
			Description = "The gif, jpg or png image.",
			GroupName = SystemTabNames.Content,
			Order = 10)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image { get; set; }

		[Display(
			Name = "Alt Attribute",
			Description = "Specifies an alternate text for an image, if the image cannot be displayed.",
			GroupName = SystemTabNames.Content,
			Order = 20)]
		[CultureSpecific]
		public virtual String Alt { get; set; }

		[Display(
			Name = "Caption",
			Description = "The optional caption for the image.",
			GroupName = SystemTabNames.Content,
			Order = 30)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		public virtual String Caption { get; set; }

	}
}