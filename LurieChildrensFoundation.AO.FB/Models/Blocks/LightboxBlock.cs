using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Lightbox Block",
		Description = "",
		GUID = "6DE0EE6D-A3AD-444A-9AB6-125543F86BA3")]
	[ImageUrl("~/ClientResources/Images/LightboxBlock.png")]
	public class LightboxBlock : AOLightboxBlock
	{
	}
}