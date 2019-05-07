using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

using LurieChildrensFoundation.AO._Base.Models.PropertyTypes;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for event landing pages, and works with the Event List Block Type.
	/// </summary>
	public class AOEventPage : AOBasePage
	{

		/* ********** Content Tab ********** */

		[Display(
			Name = "Masthead Content",
			Description = "The content will be shown at the top of the page, using the XHTML-editor you can insert for example text, images and tables.",
			GroupName = AOCustomTabNames.Content,
			Order = 25)]
		[CultureSpecific]
		public virtual ContentArea MastheadArea { get; set; }

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

		/* ********** Event Info Tab ********** */

		[Display(
			Name = "Date",
			Description = "",
			GroupName = AOCustomTabNames.EventInfo,
			Order = 15)]
		[UIHint("DateLong")]
		[Required]
		public virtual DateTime EventDate { get; set; }

		[Display(
			Name = "Time",
			Description = "",
			GroupName = AOCustomTabNames.EventInfo,
			Order = 20)]
		[Required]
		public virtual String EventTime { get; set; }

		[Display(
			Name = "Location",
			Description = "The address of the event location in the format: 123 S Michigan Ave, Chicago, IL 60603",
			GroupName = AOCustomTabNames.EventInfo,
			Order = 25)]
		[UIHint("AddressType")]
		public virtual AOAddressType EventLocation { get; set; }

		[Display(
			Name = "Web Site",
			Description = "",
			GroupName = AOCustomTabNames.EventInfo,
			Order = 30)]
		[Required]
		public virtual Url EventSite { get; set; }

		[Display(
			Name = "Short Summary",
			Description = "A smaller version of the main text, used in Page List blocks",
			GroupName = AOCustomTabNames.EventInfo,
			Order = 35)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		[Required]
		public virtual String Summary { get; set; }
		
		[Display(
			Name = "Thumbnail Image",
			Description = "A smaller version of the main image, used in Page List blocks.",
			GroupName = AOCustomTabNames.EventInfo,
			Order = 40)]
		[UIHint(UIHint.Image)]
		public virtual ContentReference ThumbnailImage { get; set; }
	}
}