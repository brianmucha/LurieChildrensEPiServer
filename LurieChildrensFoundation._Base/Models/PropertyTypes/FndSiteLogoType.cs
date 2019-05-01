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
	/// This Property Type is used on the Start Page to define the site logo.
	/// </summary>
	public class FndSiteLogoType : FndBaseBlock
	{
		[Display(
			Name = "Alt Attribute",
			Description = "Specifies an alternate text for an image, if the image cannot be displayed.")]
		[CultureSpecific]
		public virtual String Alt { get; set; }

		[Display(
			Name = "Src Attribute",
			Description = "Specifies the URL of an image.")]
		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual Url Src { get; set; }
	}
}