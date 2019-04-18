using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.AO.CRF.Models.Blocks
{
	[ContentType(
		DisplayName = "LightboxBlock",
		Description = "",
		GUID = "D2D06346-80FF-4FC1-BC00-B580E8B91A5C")]
	public class LightboxBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The HTML content for the Lightbox",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		public virtual XhtmlString Content { get; set; }
	}
}