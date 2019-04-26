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
		DisplayName = "Image File",
		Description = "Used for images of different file formats.", 
		GUID = "875b3b51-e0a7-412c-8f56-44f59c184440")]
	[MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
	public class ImageFile : AOImageFile
	{
	}
}
