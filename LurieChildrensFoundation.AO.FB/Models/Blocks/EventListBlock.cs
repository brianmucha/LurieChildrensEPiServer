using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;
using EPiServer.Web;

using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "EventList Navigation Block",
		Description = "",
		GUID = "BC2FC07A-229F-4C61-BED8-6FD8FB62135D")]
	[ImageUrl("~/ClientResources/Images/EventListBlock.png")]
	public class EventListBlock : AOBaseBlock
	{
		[Display(
			Name = "Heading",
			Description = "The heading for the EventList",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		public virtual string Heading { get; set; }

		[Required]
		[Display(
			Name = "Root Page",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 2)]
		public virtual PageReference Root { get; set; }

		[UIHint("SortOrder")]
		[BackingType(typeof(PropertyNumber))]
		[Display(
			Name = "Sort Order",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 4)]
		public virtual FilterSortOrder SortOrder { get; set; }

		[Display(
			Name = "Page Type Filter",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 5)]
		public virtual PageType PageTypeFilter { get; set; }

		[Display(
			Name = "Category Filter",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 6)]
		public virtual CategoryList CategoryFilter { get; set; }

		[Display(
			Name = "Recursive",
			Description = "",
			GroupName = SystemTabNames.Content,
			Order = 7)]
		public virtual bool Recursive { get; set; }

		#region IInitializableContent

		/// <summary>
		/// Sets the default property values on the content data.
		/// </summary>
		/// <param name="contentType">Type of the content.</param>
		public override void SetDefaultValues(ContentType contentType)
		{
			base.SetDefaultValues(contentType);

			SortOrder = FilterSortOrder.Index;
		}

		#endregion
	}
}