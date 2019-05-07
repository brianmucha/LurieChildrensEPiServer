using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation._Base.Models
{
	[GroupDefinitions]
	public class FndCustomTabNames
	{
		[Display(Order = 10)]
		public const string Content = SystemTabNames.Content;

		[Display(Order = 20)]
		public const string MetaData = "Metadata";

		[Display(Order = 30)]
		public const string Settings = SystemTabNames.Settings;

		[Display(Order = 40)]
		public const string SiteSettings = "Site-Wide Settings";
	}
}