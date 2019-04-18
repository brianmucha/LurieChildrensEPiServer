using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.AO.CSB.Models.Blocks
{
	[ContentType(
		DisplayName = "LightboxBlock",
		Description = "",
		GUID = "C74A989B-E323-4C8D-AE88-5EE2309403A8")]
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