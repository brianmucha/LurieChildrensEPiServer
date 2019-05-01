using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for main pages consisting of a hero image masthead and manually created content such as text, images, and blocks.
	/// </summary>
	public class AOLandingPage : AOBasePage
	{
		[Display(
			Name = "Main Headline",
			Description = "The main headline for the Landing Page.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 10)]
		[CultureSpecific]
		public virtual String MainHeadline { get; set; }

		[Display(
			Name = "Sub Headline",
			Description = "The sub headline for the Landing Page.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 11)]
		[CultureSpecific]
		public virtual String SubHeadline { get; set; }

		[Display(
				Name = "Short Text Block",
				Description = "A short paragraph.",
				GroupName = AOCustomTabNames.Masthead,
				Order = 12)]
		[CultureSpecific]
		[UIHint("TextArea")]
		[StringLength(200)]
		public virtual String ShortText { get; set; }

		[Display(
			Name = "Main Image",
			Description = "A full page width main image.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 13)]
		[UIHint("Image")]
		public virtual ContentReference MainImage { get; set; }
	}
}