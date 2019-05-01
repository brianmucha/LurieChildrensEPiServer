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
	/// This Property Type is used on the Start Page to define the site logo.
	/// </summary>
	[ContentType(
		DisplayName = "Site Logo Type",
		Description = "This Property Type is used on the Start Page to define the site logo.",
		GUID = "7c6615b8-ed0e-4b39-94a2-b557cd8467c3")]
	public class AOSiteLogoType : FndSiteLogoType
	{
	}
}