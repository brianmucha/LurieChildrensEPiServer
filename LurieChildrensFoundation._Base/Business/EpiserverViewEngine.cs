using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LurieChildrensFoundation._Base.Models
{
	public class EpiserverViewEngine : System.Web.Mvc.RazorViewEngine
	{
		public EpiserverViewEngine()
		{
			var partialViewLocations = new[]
			{
				"~/Views/Blocks/{1}.cshtml",
				"~/Views/Blocks/{0}.cshtml",
				"~/Views/Shared/{0}.cshtml",

				"~/Views/Blocks/{1}/{0}.cshtml",
				"~/Views/Shared/{1}/{0}.cshtml"
			};

			var viewLocations = new[]
			{
				"~/Views/Pages/{1}.cshtml",
				"~/Views/Nodes/{1}.cshtml",
				"~/Views/Catalog/{1}.cshtml",

				"~/Views/Pages/{1}/{0}.cshtml",
				"~/Views/Nodes/{1}/{0}.cshtml",
				"~/Views/Catalog/{1}/{0}.cshtml"
			};

			PartialViewLocationFormats = partialViewLocations;
			ViewLocationFormats = viewLocations;
		}
	}
}
