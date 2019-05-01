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
	/// This Property Type is used for html links.
	/// </summary>
	[ContentType(
		DisplayName = "Link Item Type",
		Description = "This Property Type is used used for html links.",
		GUID = "2EC3C2FF-667C-47A3-BD64-DF2ADB4F7CDC",
		AvailableInEditMode = false)]
	public class AOLinkItemType : FndLinkItemType
	{
	}
}