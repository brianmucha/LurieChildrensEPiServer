using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "EventList Navigation Block",
		Description = "",
		GUID = "BC2FC07A-229F-4C61-BED8-6FD8FB62135D")]
	[ImageUrl("~/ClientResources/Images/EventListBlock.png")]
	public class EventListBlock : AOEventListBlock
	{
	}
}