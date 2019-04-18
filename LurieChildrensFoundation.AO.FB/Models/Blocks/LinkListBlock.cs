using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Link List Block",
		Description = "",
		GUID = "FDB589B2-DE4D-4489-B196-E2903C341189")]
	[ImageUrl("~/ClientResources/Images/LinkListBlock.png")]
	public class LinkListBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The link collection for the Link List Block",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		[UIHint("LinkItemCollection")]
		public virtual LinkItemCollection LinkCollection { get; set; }
	}
}