using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Image Block",
		Description = "A structured image block with optional caption. ",
		GUID = "E2FAA010-4D55-4888-9158-CE889261E302")]
	[ImageUrl("~/ClientResources/Images/ImageBlock.png")]
	public class ImageBlock : AOImageBlock
	{
	}
}