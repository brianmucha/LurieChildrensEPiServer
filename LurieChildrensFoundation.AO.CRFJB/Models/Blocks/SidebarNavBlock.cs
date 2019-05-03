using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.CRFJB.Models.Blocks
{
	[ContentType(
		DisplayName = "Sidebar Navigation Block",
		Description = "",
		GUID = "680BEC65-6D1D-4052-AA70-7205B6CEDD96")]
	public class SidebarNavBlock : AOSidebarNavBlock
	{
	}
}