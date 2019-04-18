using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.CRFJB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Event Page", 
		Description = "This Page Type is used for event pages.", 
		GUID = "55820755-C36D-40C2-AC31-6139D072701D")]
	public class EventPage : FndBasePage
	{
		[Display(
			Name = "Event Date",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 320)]
		[UIHint("DateOnly")]
		public virtual DateTime EventDate { get; set; }

		[Display(
			Name = "Description",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 330)]
		[CultureSpecific]
		[UIHint("TextArea")]
		public virtual string Description { get; set; }

	}
}