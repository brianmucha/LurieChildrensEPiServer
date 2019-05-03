using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;
using EPiServer.Web;

namespace LurieChildrensFoundation.AO._Base.Models.Blocks
{
	/// <summary>
	/// A collection of links for the Sidebar.
	/// </summary>
	public class AOSidebarBlock : AOBaseBlock
	{
		[Display(
			Name = "Heading",
			Description = "The heading for the Sidebar",
			GroupName = AOCustomTabNames.Content,
			Order = 10)]
		[CultureSpecific]
		public virtual String Heading { get; set; }

		[Display(
			Name = "Root Page",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 20)]
		[Required]
		public virtual PageReference Root { get; set; }

		[Display(
			Name = "Sort Order",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 30)]
		[BackingType(typeof(PropertyNumber))]
		[UIHint("SortOrder")]
		public virtual FilterSortOrder SortOrder { get; set; }

		[Display(
			Name = "Page Type Filter",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 40)]
		public virtual PageType PageTypeFilter { get; set; }

		[Display(
			Name = "Category Filter",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 50)]
		public virtual CategoryList CategoryFilter { get; set; }

		[Display(
			Name = "Recursive",
			Description = "",
			GroupName = AOCustomTabNames.Content,
			Order = 60)]
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