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
		DisplayName = "EventList Navigation Block",
		Description = "",
		GUID = "D73F41C0-1842-4BD1-A800-21CFB8A35B67")]
	public class EventListBlock : AOEventListBlock
	{
	}
}