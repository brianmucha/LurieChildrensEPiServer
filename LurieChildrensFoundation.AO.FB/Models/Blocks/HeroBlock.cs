using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Hero Block",
		Description = "A structured main image block. ",
		GUID = "8F0C943E-58CA-4752-A9C8-961007244455")]
	[ImageUrl("~/ClientResources/Images/HeroBlock.png")]
	public class HeroBlock : AOHeroBlock
	{
	}
}