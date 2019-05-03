using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace LurieChildrensFoundation._Base.Models.Media
{
	/// <summary>
	/// Used for generic file types such as Word or PDF documents.
	/// </summary>
	public class FndGenericMedia : MediaData
	{
		[Display(
			Name = "Description",
			Description = "Add a description of the content.",
			GroupName = FndCustomTabNames.Content,
			Order = 1)]
		[CultureSpecific]
		[Editable(true)]
		public virtual String Description { get; set; }
	}
}
