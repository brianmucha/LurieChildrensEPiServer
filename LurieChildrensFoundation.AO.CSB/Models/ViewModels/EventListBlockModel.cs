using System.Collections.Generic;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Filters;

using LurieChildrensFoundation.AO.CSB.Models.Blocks;
using LurieChildrensFoundation.AO.CSB.Models.ViewModels;
using LurieChildrensFoundation.AO._Base.Models.ViewModels;

namespace LurieChildrensFoundation.AO.CSB.Models.ViewModels
{
	/// <summary>
	/// Returns a Block View Model for a <see cref="EventListBlock"/>.
	/// </summary>
	public class EventListBlockViewModel
	{
		public EventListBlockViewModel(EventListBlock currentBlock)
		{
			this.Heading = currentBlock.Heading;
			this.Root = currentBlock.Root;
			this.SortOrder = currentBlock.SortOrder;
			this.PageTypeFilter = currentBlock.PageTypeFilter;
			this.CategoryFilter = currentBlock.CategoryFilter;
			this.Recursive = currentBlock.Recursive;
		}

		public string Heading { get; internal set; }
		public PageReference Root { get; internal set; }
		public FilterSortOrder SortOrder { get; internal set; }
		public PageType PageTypeFilter { get; internal set; }
		public CategoryList CategoryFilter { get; internal set; }
		public bool Recursive { get; internal set; }

		public IEnumerable<PageData> Pages { get; internal set; }

	}
}