﻿using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Pages;

namespace LurieChildrensFoundation.AO.CRFJB.Models.Pages
{
	/// <summary>
	/// This Page Type is used for basic pages consisting of manually created content such as text, images, and blocks.
	/// </summary>
	[ContentType(
		DisplayName = "Event Page", 
		Description = "This Page Type is used for event pages.", 
		GUID = "55820755-C36D-40C2-AC31-6139D072701D")]
	[ImageUrl("~/ClientResources/Images/EventPage.png")]
	public class EventPage : AOEventPage
	{
	}
}