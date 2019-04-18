using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO._Base.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	public class AOEventPage : AOBasePage
	{
		[Display(
			Name = "Event Date",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 5)]
		[UIHint("DateOnly")]
		[Required]
		public virtual DateTime EventDate { get; set; }

		[Display(
			Name = "Short Summary",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		[UIHint("TextArea")]
		[Required]
		public virtual string Summary { get; set; }

	}
}