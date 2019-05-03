using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Blocks
{
	/// <summary>
	/// A collection of links for the Sidebar.
	/// </summary>
	public class AOLinkListBlock : AOBaseBlock
	{
		[Display(
			Name = "Content",
			Description = "The link collection for the Link List Block",
			GroupName = AOCustomTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		[UIHint("LinkItemCollection")]
		public virtual LinkItemCollection LinkCollection { get; set; }
	}
}