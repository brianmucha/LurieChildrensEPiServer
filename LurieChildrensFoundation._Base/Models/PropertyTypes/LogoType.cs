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
	public class LogoType : FndBaseBlock
	{
		[CultureSpecific]
		public virtual String Title { get; set; }

		[DefaultDragAndDropTarget]
		[UIHint(UIHint.Image)]
		public virtual Url Url { get; set; }
	}
}