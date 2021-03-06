﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation._Base.Models;

namespace LurieChildrensFoundation.Home.Models.Blocks
{
	[ContentType(
		DisplayName = "Lightbox Block",
		Description = "", 
		GUID = "76c90ec0-4241-42d5-98ed-a856993af3e9")]
	public class LightboxBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The HTML content for the Lightbox",
			GroupName = FndCustomTabNames.Content,
			Order = 1)]
		public virtual XhtmlString Content { get; set; }
	}
}