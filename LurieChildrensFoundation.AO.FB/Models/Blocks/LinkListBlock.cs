using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Link List Block",
		Description = "A collection of links.",
		GUID = "FDB589B2-DE4D-4489-B196-E2903C341189")]
	[ImageUrl("~/ClientResources/Images/LinkListBlock.png")]
	public class LinkListBlock : AOLinkListBlock
	{
	}
}