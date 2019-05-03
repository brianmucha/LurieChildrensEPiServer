using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation.AO._Base.Models.Blocks
{
	/// <summary>
	/// A structured main image block.
	/// </summary>
	public class AOHeroBlock : AOBaseBlock
	{
		[Display(
			Name = "Content",
			Description = "The HTML content for the Hero Block",
			GroupName = AOCustomTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		public virtual XhtmlString Content { get; set; }
	}
}