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
		DisplayName = "Generic Media",
		Description = "Used for generic file types such as Word or PDF documents.", 
		GUID = "89761dbb-bf22-4cee-93c7-9d661d75cad8")]
	[MediaDescriptor(ExtensionString = "pdf,doc,docx")]
	public class GenericMedia : AOGenericMedia
	{
	}
}
