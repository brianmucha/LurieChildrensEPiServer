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
		DisplayName = "EventList Navigation Block",
		Description = "",
		GUID = "ACDF6462-3C6D-40FA-81EC-AA2904C465FA")]
	public class EventListBlock : AOEventListBlock
	{
	}
}