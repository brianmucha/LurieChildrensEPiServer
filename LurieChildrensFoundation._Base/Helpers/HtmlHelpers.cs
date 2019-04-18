using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace LurieChildrensFoundation._Base.Helpers
{
	/// <summary>
	/// This HTML Helper supports rendering the navigation Partial Views.
	/// </summary>
	public static class HtmlHelperMenu
	{
		/// <summary>
		/// This HTML Helper returns a filtered <see cref="MenuItem"/> list for a navigation Partial View.
		/// </summary>
		public static IHtmlString MenuList
		(
			this HtmlHelper helper,
			ContentReference rootLink,
			Func<MenuItem, HelperResult> itemTemplate
		)
		{
			var currentContentLink = helper.ViewContext.RequestContext.GetContentLink();
			var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
			var filterForVisitor = new FilterContentForVisitor();

			var pagePath = contentLoader.GetAncestors(currentContentLink)
				.Reverse()
				.Select(x => x.ContentLink)
				.SkipWhile(x => !x.CompareToIgnoreWorkID(rootLink))
				.ToList();

			var menuItems = contentLoader.GetChildren<PageData>(rootLink)
				.Where(page => !filterForVisitor.ShouldFilter(page) && page.VisibleInMenu)
				.Select(page => 
					new MenuItem
					{
						Page = page,
						Selected = page.ContentLink.CompareToIgnoreWorkID(currentContentLink) || pagePath.Contains(page.ContentLink)
					}
				)
				.ToList();

			var buffer = new StringBuilder();
			var writer = new StringWriter(buffer);
			
			foreach (var menuItem in menuItems)
			{
				itemTemplate(menuItem).WriteTo(writer);
			}

			return new MvcHtmlString(buffer.ToString());
		}

		/// <summary>
		/// This object contains a generic <see cref="PageData"/> page and related properties for a navigation Partial View.
		/// </summary>
		public class MenuItem
		{
			public PageData Page { get; set; }
			public bool Selected { get; set; }
		}

	}
}