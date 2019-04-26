using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.Home.Models.Blocks
{
	[ContentType(
		DisplayName = "Hero Image Block",
		Description = "", 
		GUID = "AB9B895B-7EF5-4FBE-A82E-11B35325ADAF")]
	public class HeroImageBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The HTML content for the Hero Image",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		public virtual XhtmlString Content { get; set; }
	}
}