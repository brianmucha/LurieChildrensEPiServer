using System.ComponentModel.DataAnnotations;
using EPiServer.Core;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	public class AOSidebarPage : AOBasePage
	{

		/* ********** Content Tab ********** */

		[Display(
			Name = "Sidebar Content",
			Description = "The sidebar content will be shown in the sidebar content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
			GroupName = AOCustomTabNames.Content,
			Order = 45)]
		public virtual ContentArea SidebarContentArea { get; set; }

	}
}