using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

using LurieChildrensFoundation._Base.Models.PropertyTypes;

namespace LurieChildrensFoundation.AO._Base.Models.PropertyTypes
{
	/// <summary>
	/// This Property Type is used to define a postal address.
	/// </summary>
	[ContentType(
		DisplayName = "Address Type",
		Description = "This Property Type is used to define a postal address.",
		GUID = "5235B226-B2A5-4B26-AF78-F97417C77BC3")]
	public class AOAddressType : FndAddressType
	{
	}
}