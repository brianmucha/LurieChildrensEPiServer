using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Sidebar Link List Block",
		Description = "A manually built collection of links for the Sidebar.",
		GUID = "D9CC5D5D-F563-4D35-9EDD-4FB8417435DA")]
	[ImageUrl("~/ClientResources/Images/SidebarLinkListBlock.png")]
	public class SidebarLinkListBlock : AOSidebarLinkListBlock
	{
	}
}