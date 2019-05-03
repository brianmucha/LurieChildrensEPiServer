using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.CRF.Models.Blocks
{
	[ContentType(
		DisplayName = "Sidebar Navigation Block",
		Description = "",
		GUID = "F9B4D38E-67F6-4836-8134-0868B0E4AFE7")]
	public class SidebarNavBlock : AOSidebarNavBlock
	{
	}
}