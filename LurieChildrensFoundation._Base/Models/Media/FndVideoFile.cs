using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace LurieChildrensFoundation._Base.Models.Media
{
	/// <summary>
	/// Used for specific video file formats
	/// </summary>
	public class FndVideoFile : VideoData
	{
		[Display(
			Name = "Description",
			Description = "A description of the content.",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		[CultureSpecific]
		[Editable(true)]
		public virtual String Description { get; set; }

		[Display(
			Name = "Preview Image",
			Description = "A still image preview of the content.",
			GroupName = SystemTabNames.Content,
			Order = 2)]
		[UIHint("Image")]
		public virtual ContentReference PreviewImage { get; set; }
	}
}
