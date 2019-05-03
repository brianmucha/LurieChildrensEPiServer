using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	public class AOStandardPage : AOBasePage
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

	}
}