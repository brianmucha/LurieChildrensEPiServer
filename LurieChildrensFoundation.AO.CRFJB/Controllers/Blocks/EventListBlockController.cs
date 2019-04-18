using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web.Mvc;

using LurieChildrensFoundation._Base.Business;
using LurieChildrensFoundation.AO.CRFJB.Models.Blocks;
using LurieChildrensFoundation.AO.CRFJB.Models.ViewModels;

namespace LurieChildrensFoundation.AO.CRFJB.Controllers.Blocks
{
	/// <summary>
	/// Returns a partial view using the <see cref="EventListBlockViewModel"/>.
	/// </summary>
	public class EventListBlockController : BlockController<EventListBlock>
	{

		private ContentLocator contentLocator;
		private IContentLoader contentLoader;

		public EventListBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
		{
			this.contentLocator = contentLocator;
			this.contentLoader = contentLoader;
		}

		public override ActionResult Index(EventListBlock currentBlock)
		{

			var model = new EventListBlockViewModel(currentBlock);

			// Get the edit hints collection.
			var editingHints = ViewData.GetEditHints<EventListBlockViewModel, EventListBlock>();

			// Add connections between view data properties and content data properties.
			editingHints.AddConnection(viewData => viewData.Heading, contentData => contentData.Heading);
			editingHints.AddConnection(viewData => viewData.Root, contentData => contentData.Root);
			editingHints.AddConnection(viewData => viewData.SortOrder, contentData => contentData.SortOrder);
			editingHints.AddConnection(viewData => viewData.PageTypeFilter, contentData => contentData.PageTypeFilter);
			editingHints.AddConnection(viewData => viewData.CategoryFilter, contentData => contentData.CategoryFilter);
			editingHints.AddConnection(viewData => viewData.Recursive, contentData => contentData.Recursive);

			// Add to the collection of properties which requires full refresh of the block.
			editingHints.AddFullRefreshFor(contentData => contentData.Root);
			editingHints.AddFullRefreshFor(contentData => contentData.SortOrder);
			editingHints.AddFullRefreshFor(contentData => contentData.PageTypeFilter);
			editingHints.AddFullRefreshFor(contentData => contentData.CategoryFilter);
			editingHints.AddFullRefreshFor(contentData => contentData.Recursive);

			// Populate any additional properties in the ViewModel that are not part of the Model.
			var pages = FindPages(currentBlock);
			pages = Sort(pages, currentBlock.SortOrder);
			model.Pages = pages;

			return PartialView(model);
		}

		private IEnumerable<PageData> FindPages(EventListBlock currentBlock)
		{

			IEnumerable<PageData> pages;

			var listRoot = currentBlock.Root;

			if (currentBlock.Recursive)
			{
				if (currentBlock.PageTypeFilter != null)
				{
					pages = contentLocator.FindPagesByPageType(listRoot, true, currentBlock.PageTypeFilter.ID);
				}
				else
				{
					pages = contentLocator.GetAll<PageData>(listRoot);
				}
			}
			else
			{
				if (currentBlock.PageTypeFilter != null)
				{
					pages = contentLoader.GetChildren<PageData>(listRoot)
							.Where(p => p.ContentTypeID == currentBlock.PageTypeFilter.ID);
				}
				else
				{
					pages = contentLoader.GetChildren<PageData>(listRoot);
				}
			}

			if (currentBlock.CategoryFilter != null && currentBlock.CategoryFilter.Any())
			{
				pages = pages.Where(x => x.Category.Intersect(currentBlock.CategoryFilter).Any());
			}
			return pages;
		}

		private IEnumerable<PageData> Sort(IEnumerable<PageData> pages, FilterSortOrder sortOrder)
		{
			var pageCollection = new PageDataCollection(pages);
			var sortFilter = new FilterSort(sortOrder);
			sortFilter.Sort(pageCollection);
			return pageCollection;
		}

	}
}
