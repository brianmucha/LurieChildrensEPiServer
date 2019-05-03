using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Blocks
{
	/// <summary>
	/// A freeform code block for raw unencoded html, script or styles.
	/// </summary>
	public class AOScriptBlock : AOBaseBlock
	{
		[Display(
			Name = "Code",
			Description = "The code for the Script Block",
			GroupName = AOCustomTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		public virtual String Code { get; set; }
	}
}