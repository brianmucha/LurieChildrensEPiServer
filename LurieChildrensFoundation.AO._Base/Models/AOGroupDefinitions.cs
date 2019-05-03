using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation._Base.Models;

namespace LurieChildrensFoundation.AO._Base.Models
{
	[GroupDefinitions]
	public class AOCustomTabNames : FndCustomTabNames
	{
		[Display(Order = 100)]
		public const string Masthead = "Masthead";

		[Display(Order = 110)]
		public const string SiteSettings = "Site-Wide Settings";
	}
}