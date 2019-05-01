using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

using LurieChildrensFoundation.AO._Base.Models.PropertyTypes;

namespace LurieChildrensFoundation.AO.FB.Models.PropertyTypes
{
	/// <summary>
	/// This Property Type is used on the Start Page to define the site logo.
	/// </summary>
	[ContentType(
		DisplayName = "Site Logo Type",
		Description = "This Property Type is used on the Start Page to define the site logo.",
		GUID = "2DDE2356-D84D-435C-BC87-03283654F694")]
	public class SiteLogoType : AOSiteLogoType
	{
	}
}