using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Media;

namespace LurieChildrensFoundation.AO.FB.Models.Media
{
	[ContentType(
		DisplayName = "Video File",
		Description = "Used for specific video file formats.",
		GUID = "f2285e5a-be15-47b6-8952-e3c61deaefd2")]
	[MediaDescriptor(ExtensionString = "flv,mp4,webm")]
	public class VideoFile : AOVideoFile
	{
	}
}
