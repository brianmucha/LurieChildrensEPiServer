using EPiServer.DataAbstraction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using EPiServer.DataAnnotations;

namespace LurieChildrensFoundation._Base
{
	public class Global
	{

		/// <summary>
		/// Group names for content types and properties
		/// </summary>
		[GroupDefinitions()]
		public static class GroupNames
		{
			[Display(Name = "Content", Order = 10)]
			public const string Content = SystemTabNames.Content;

			[Display(Name = "Metadata", Order = 20)]
			public const string MetaData = "Metadata";

			[Display(Name = "Settings", Order = 50)]
			public const string Settings = SystemTabNames.Settings;

		}

	}
}