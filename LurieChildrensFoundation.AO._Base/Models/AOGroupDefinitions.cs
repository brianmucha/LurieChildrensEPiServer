using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using LurieChildrensFoundation._Base.Models;

namespace LurieChildrensFoundation.AO._Base.Models
{
	[GroupDefinitions]
	public class AOCustomTabNames : FndCustomTabNames
	{
		[Display(Order = 5)]
		public const string EventInfo = "Event Info";

		[Display(Order = 5)]
		public const string Summary = "Summary";

		[Display(Order = 20)]
		public const string ResponsiveImages = "Responsive Images";

		[Display(Order = 100)]
		public const string Masthead = "Masthead";
	}
}