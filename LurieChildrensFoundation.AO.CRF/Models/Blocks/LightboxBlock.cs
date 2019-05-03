using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.CRF.Models.Blocks
{
	[ContentType(
		DisplayName = "LightboxBlock",
		Description = "",
		GUID = "D2D06346-80FF-4FC1-BC00-B580E8B91A5C")]
	public class LightboxBlock : AOLightboxBlock
	{
	}
}