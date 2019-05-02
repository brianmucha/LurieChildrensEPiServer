using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Script Block",
		Description = "A freeform code block for raw unencoded html, script or styles.",
		GUID = "E7B84676-A6FD-4AEF-B309-E1F2936B26E9")]
	[ImageUrl("~/ClientResources/Images/ScriptBlock.png")]
	public class ScriptBlock : AOScriptBlock
	{
	}
}