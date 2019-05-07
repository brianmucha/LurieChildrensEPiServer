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
			GroupName = AOCustomTabNames.Content,
			Order = 10)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image { get; set; }

		[Display(
			Name = "Alt Attribute",
			Description = "Specifies an alternate text for an image, if the image cannot be displayed.",
			GroupName = AOCustomTabNames.Content,
			Order = 30)]
		[CultureSpecific]
		public virtual String Alt { get; set; }

		[Display(
			Name = "Autoscale",
			Description = "Automatically scale the image at mobile sizes. This makes the image larger at narrow widths and trims sides in order to preserve a reasonable image height.",
			GroupName = AOCustomTabNames.Content,
			Order = 40)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		public virtual Boolean Autoscale { get; set; }

		[Display(
			Name = "Caption",
			Description = "An optional caption for the image.",
			GroupName = AOCustomTabNames.Content,
			Order = 50)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		public virtual String Caption { get; set; }

		[Display(
			Name = "Overtext",
			Description = "An optional text block displayed with the image as the background.",
			GroupName = AOCustomTabNames.Content,
			Order = 60)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		public virtual String Overtext { get; set; }

		[Display(
			Name = "Responsive Image (72px or more)",
			Description = "Optional. An alternate sized image for 72px or more, when supported.",
			GroupName = AOCustomTabNames.ResponsiveImages,
			Order = 20)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image72 { get; set; }

		[Display(
			Name = "Responsive Image (320px or more)",
			Description = "Optional. An alternate sized image for 320px or more, when supported.",
			GroupName = AOCustomTabNames.ResponsiveImages,
			Order = 21)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image320 { get; set; }

		[Display(
			Name = "Responsive Image (576px or more)",
			Description = "Optional. An alternate sized image for 576px or more, when supported.",
			GroupName = AOCustomTabNames.ResponsiveImages,
			Order = 22)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image576 { get; set; }

		[Display(
			Name = "Responsive Image (768px or more)",
			Description = "Optional. An alternate sized image for 768px or more, when supported.",
			GroupName = AOCustomTabNames.ResponsiveImages,
			Order = 23)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image768 { get; set; }

		[Display(
			Name = "Responsive Image (992px or more)",
			Description = "Optional. An alternate sized image for 992px or more, when supported.",
			GroupName = AOCustomTabNames.ResponsiveImages,
			Order = 24)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image992 { get; set; }


	}
}