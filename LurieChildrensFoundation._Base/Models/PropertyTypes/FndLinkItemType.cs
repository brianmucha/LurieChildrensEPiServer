using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

using LurieChildrensFoundation._Base.Models.Blocks;

namespace LurieChildrensFoundation._Base.Models.PropertyTypes
{
	/// <summary>
	/// This Property Type is used for html links.
	/// </summary>
	public class FndLinkItemType : FndBaseBlock
	{
		[Display(
			Name = "Link name/text",
			Description = "")]
		[CultureSpecific]
		public virtual String Text { get; set; }

		[Display(
			Name = "Link title",
			Description = "")]
		[CultureSpecific]
		public virtual String Title { get; set; }

		[Display(
			Name = "Open in",
			Description = "")]
		[SelectOne(SelectionFactoryType = typeof(TargetSelectionFactory))]
		[CultureSpecific]
		public virtual String Target { get; set; }

		[Display(
			Name = "Src Attribute",
			Description = "")]
		public virtual Url Src { get; set; }
	}

	public class TargetSelectionFactory : ISelectionFactory
	{
		IEnumerable<ISelectItem> ISelectionFactory.GetSelections(ExtendedMetadata metadata)
		{
			return new ISelectItem[] {
				new SelectItem() { Text="Open the link in a new window", Value="_blank" },
				new SelectItem() { Text="Open the link in the whole window", Value="_self" }
			};
		}
	}

}