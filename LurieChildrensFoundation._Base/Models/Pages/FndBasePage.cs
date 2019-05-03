using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace LurieChildrensFoundation._Base.Models.Pages
{
	/// <summary>
	/// This Page Type defines common content and meta data for all pages.
	/// </summary>
	public class FndBasePage : PageData, IFndBasePage
	{

		/* ********** Content Tab ********** */

		[Display(
			Name = "Main Content",
			Description = "The main content will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
			GroupName = FndCustomTabNames.Content,
			Order = 30)]
		public virtual ContentArea MainContentArea { get; set; }

		/* ********** MetaData Tab ********** */

		[Display(
			Name = "Meta Title",
			Description = "The title of the page. Titles are displayed on browser tabs, bookmarks and history, and also in search engine results pages as the clickable headline for a given result, and are important for usability, SEO, and social sharing.",
			GroupName = FndCustomTabNames.MetaData,
			Order = 100)]
		[CultureSpecific]
		public virtual string MetaTitle
		{
			get
			{
				// Use explicitly set meta title, otherwise fall back to page name
				var metaTitle = this.GetPropertyValue(p => p.MetaTitle);
				return !string.IsNullOrWhiteSpace(metaTitle)
						? metaTitle
						: PageName;
			}
			set { this.SetPropertyValue(p => p.MetaTitle, value); }
		}

		[Display(
			Name = "Meta Description",
			Description = "The summary of the page content. Search engines show the meta description in search results mostly when the searched-for phrase is within the description, so optimizing the meta description is crucial for SEO.",
			GroupName = FndCustomTabNames.MetaData,
			Order = 200)]
		[CultureSpecific]
		[UIHint("TextArea")]
		public virtual string MetaDescription { get; set; }

		[Display(
			Name = "Meta Robots",
			Description = "Controls the page's availability for search engine crawling and indexing.",
			GroupName = FndCustomTabNames.MetaData,
			Order = 300)]
		[SelectMany(SelectionFactoryType = typeof(MetaRobotsSelectionFactory))]
		public virtual string MetaRobots { get; set; }

	}

	public class MetaRobotsSelectionFactory : ISelectionFactory
	{
		IEnumerable<ISelectItem> ISelectionFactory.GetSelections(ExtendedMetadata metadata)
		{
			return new ISelectItem[] {
				new SelectItem() { Text="noindex", Value="noindex" },
				new SelectItem() { Text="nofollow", Value="nofollow" },
				new SelectItem() { Text="nosnippet", Value="nosnippet" },
				new SelectItem() { Text="noarchive", Value="noarchive" },
				new SelectItem() { Text="noimageindex", Value="noimageindex" }
			};
		}
	}

}