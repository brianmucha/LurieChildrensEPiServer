﻿using System.Collections.Generic;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Filters;

using LurieChildrensFoundation.Home.Models.Blocks;
using LurieChildrensFoundation.Home.Models.ViewModels;
using LurieChildrensFoundation._Base.Models.ViewModels;

namespace LurieChildrensFoundation.Home.Models.ViewModels
{
	/// <summary>
	/// Returns a Block View Model for a <see cref="PageListBlock"/>.
	/// </summary>
	public class PageListBlockViewModel
	{
		public PageListBlockViewModel(PageListBlock currentBlock)
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