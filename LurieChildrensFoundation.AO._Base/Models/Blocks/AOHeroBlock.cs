using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Blocks
{
	/// <summary>
	/// A structured main image block.
	/// </summary>
	public class AOHeroBlock : AOBaseBlock
	{
		[Display(
			Name = "Main Headline",
			Description = "The main headline for the Start Page.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 10)]
		[CultureSpecific]
		public virtual String MainHeadline { get; set; }

		[Display(
			Name = "Sub Headline",
			Description = "The sub headline for the Start Page.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 20)]
		[CultureSpecific]
		public virtual String SubHeadline { get; set; }

		[Display(
			Name = "Short Text Block",
			Description = "A short paragraph.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 30)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		[StringLength(200)]
		public virtual String ShortText { get; set; }

		[Display(
			Name = "Main Image",
			Description = "A full page width main image.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 40)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference MainImage { get; set; }

		[Display(
			Name = "Responsive Image (72px or more)",
			Description = "Optional. An alternate sized image for 72px or more, when supported.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 50)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image72 { get; set; }

		[Display(
			Name = "Responsive Image (320px or more)",
			Description = "Optional. An alternate sized image for 320px or more, when supported.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 51)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image320 { get; set; }

		[Display(
			Name = "Responsive Image (576px or more)",
			Description = "Optional. An alternate sized image for 576px or more, when supported.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 52)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image576 { get; set; }

		[Display(
			Name = "Responsive Image (768px or more)",
			Description = "Optional. An alternate sized image for 768px or more, when supported.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 53)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image768 { get; set; }

		[Display(
			Name = "Responsive Image (992px or more)",
			Description = "Optional. An alternate sized image for 992px or more, when supported.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 54)]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image992 { get; set; }

	}
}