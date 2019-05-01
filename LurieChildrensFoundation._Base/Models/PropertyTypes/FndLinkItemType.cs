using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

using LurieChildrensFoundation._Base.Models.Blocks;

namespace LurieChildrensFoundation._Base.Models.PropertyTypes
{
	/// <summary>
	/// This Property Type is used for html links.
	/// </summary>
	public class FndLinkItemType : FndBaseBlock
	{
		[Display(
			Name = "Link name/text",
			Description = "")]
		[CultureSpecific]
		public virtual String Text { get; set; }

		[Display(
			Name = "Link title",
			Description = "")]
		[CultureSpecific]
		public virtual String Title { get; set; }

		[Display(
			Name = "Open in",
			Description = "")]
		[CultureSpecific]
		public virtual String Target { get; set; }

		[Display(
			Name = "Src Attribute",
			Description = "")]
		public virtual Url Src { get; set; }
	}
}