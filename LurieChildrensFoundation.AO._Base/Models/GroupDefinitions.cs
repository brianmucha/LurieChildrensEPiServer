﻿using System.ComponentModel.DataAnnotations;

using LurieChildrensFoundation._Base.Models.Pages;

{
	[GroupDefinitions]
	public class CustomTabNames : FndCustomTabNames
	{
		[Display(Order = 100)]
		public const string Masthead = "Masthead";
	}
}