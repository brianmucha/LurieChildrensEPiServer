using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "NewsList Navigation Block",
		Description = "",
		GUID = "3D92A0F2-C915-4FC2-822B-479E2E385617")]
	[ImageUrl("~/ClientResources/Images/NewsListBlock.png")]
	public class NewsListBlock : AONewsListBlock
	{
	}
}