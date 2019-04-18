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
		DisplayName = "EventList Navigation Block",
		Description = "",
		GUID = "796C894B-D0D0-4880-8CD3-060651A6E60A")]
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