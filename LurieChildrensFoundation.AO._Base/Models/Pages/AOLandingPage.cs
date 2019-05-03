using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for main pages consisting of a hero image masthead and manually created content such as text, images, and blocks.
	/// </summary>
	public class AOLandingPage : AOBasePage
	{
		/* ********** Content Tab ********** */

		[Display(
			Name = "Use Sidebar",
			Description = "Reveals the left sidebar.",
			GroupName = AOCustomTabNames.Content,
			Order = 40)]
		public virtual Boolean UseSidebar { get; set; }

		[Display(
			Name = "Sidebar Content",
			Description = "The sidebar content will be shown in the sidebar content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
			GroupName = AOCustomTabNames.Content,
			Order = 45)]
		[CultureSpecific]
		public virtual ContentArea SidebarContentArea { get; set; }

		/* ********** Masthead Tab ********** */

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
		[UIHint(UIHint.Textarea)]
		[StringLength(200)]
		public virtual String ShortText { get; set; }

		[Display(
			Name = "Main Image",
			Description = "A full page-width main image.",
			GroupName = AOCustomTabNames.Masthead,
			Order = 13)]
		[UIHint(UIHint.Image)]
		public virtual ContentReference MainImage { get; set; }

	}
}