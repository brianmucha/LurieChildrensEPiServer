using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.Home.Models.Blocks
{
	[ContentType(DisplayName = "LightboxBlock", GUID = "76c90ec0-4241-42d5-98ed-a856993af3e9", Description = "")]
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