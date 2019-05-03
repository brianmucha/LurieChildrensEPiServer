using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

using LurieChildrensFoundation.AO._Base.Models.PropertyTypes;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for main pages consisting of a hero image masthead and manually created content such as text, images, and blocks.
	/// </summary>
	public class AOStartPage : AOBasePage
	{

		/* ********** Masthead Tab ********** */

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
		[UIHint(UIHint.Image)]
		public virtual ContentReference MainImage { get; set; }

		/* ********** Site-Wide Settings Tab ********** */

		[Display(
			Name = "Donate Link",
			Description = "The URL Link to the donation form.",
			GroupName = AOCustomTabNames.SiteSettings,
			Order = 100)]
		public virtual AOLinkItemType DonateLink { get; set; }

		[Display(
			Name = "Other Top Links",
			Description = "The URL Links for the top of the masthead.",
			GroupName = AOCustomTabNames.SiteSettings,
			Order = 110)]
		public virtual LinkItemCollection TopLinks { get; set; }

		[Display(
			Name = "Site Logo",
			Description = "The main content will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
			GroupName = AOCustomTabNames.SiteSettings,
			Order = 120)]
		public virtual AOSiteLogoType SiteLogo { get; set; }

	}
}