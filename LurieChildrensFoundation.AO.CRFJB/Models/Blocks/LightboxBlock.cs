using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.CRFJB.Models.Blocks
{
	[ContentType(
		DisplayName = "LightboxBlock",
		Description = "",
		GUID = "3B4A8B08-F6D3-44BF-A71E-CF119BB1C9B2")]
	public class LightboxBlock : AOLightboxBlock
	{
	}
}