using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.AO.CRFJB.Models.Blocks
{
	[ContentType(
		DisplayName = "LightboxBlock",
		Description = "",
		GUID = "3B4A8B08-F6D3-44BF-A71E-CF119BB1C9B2")]
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