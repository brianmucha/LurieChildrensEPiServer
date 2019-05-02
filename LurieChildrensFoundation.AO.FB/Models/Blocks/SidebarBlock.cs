using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Sidebar Navigation Block",
		Description = "A collection of links for the Sidebar.",
		GUID = "2AE75311-22AB-42C9-882C-A68793D8A014")]
	[ImageUrl("~/ClientResources/Images/SidebarBlock.png")]
	public class SidebarBlock : AOSidebarBlock
	{
	}
}