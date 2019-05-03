using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for event landing pages, and works with the Event List Block Type.
	/// </summary>
	public class AOEventPage : AOBasePage
	{
		[Display(
			Name = "Event Date",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 5)]
		[UIHint("DateOnly")]
		[Required]
		public virtual DateTime EventDate { get; set; }

		[Display(
			Name = "Short Summary",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		[Required]
		public virtual String Summary { get; set; }

		[Display(
			Name = "Main Body",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		[UIHint(UIHint.Textarea)]
		[Required]
		public virtual XhtmlString MainBody { get; set; }
	}
}