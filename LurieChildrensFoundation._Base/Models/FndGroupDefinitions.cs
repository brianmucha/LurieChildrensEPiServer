using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation._Base.Models.Pages
{
	[GroupDefinitions]
	public class FndCustomTabNames
	{
		[Display(Order = 110)]
		public const string SiteSettings = "Site-Wide Settings";
	}
}