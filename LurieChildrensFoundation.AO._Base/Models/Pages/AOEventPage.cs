using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for event landing pages, and works with the Event List Block Type.
	/// </summary>
	public class AOEventPage : AOBasePage
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

		[Display(
			Name = "Event Date",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 50)]
		[UIHint("DateOnly")]
		[Required]
		public virtual DateTime EventDate { get; set; }

		[Display(
			Name = "Short Summary",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 60)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		[Required]
		public virtual String Summary { get; set; }

		[Display(
			Name = "Main Body",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 70)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		[Required]
		public virtual XhtmlString MainBody { get; set; }
	}
}