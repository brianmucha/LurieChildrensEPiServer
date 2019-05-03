using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.CSB.Models.Blocks
{
	[ContentType(
		DisplayName = "Sidebar Navigation Block",
		Description = "",
		GUID = "12A17606-6D1A-4CA8-AB27-AAF81143CF5F")]
	public class SidebarNavBlock : AOSidebarNavBlock
	{
	}
}