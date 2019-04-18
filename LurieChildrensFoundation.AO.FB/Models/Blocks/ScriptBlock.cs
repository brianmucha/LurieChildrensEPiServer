using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Script Block",
		Description = "A freeform code block for raw unencoded html, script or styles.",
		GUID = "E7B84676-A6FD-4AEF-B309-E1F2936B26E9")]
	[ImageUrl("~/ClientResources/Images/ScriptBlock.png")]
	public class ScriptBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Code",
			Description = "The code for the Script Block",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		[UIHint(UIHint.Textarea)]
		public virtual string Code { get; set; }
	}
}