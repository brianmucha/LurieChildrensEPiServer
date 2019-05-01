using EPiServer.Cms.TinyMce.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

using LurieChildrensFoundation._Base.Models.Blocks;
using LurieChildrensFoundation._Base.Models.Pages;

namespace LurieChildrensFoundation._Base.Business.Initializations
{
	[ModuleDependency(typeof(TinyMceInitialization))]
	public class ExtendedTinyMceInitialization : IConfigurableModule
	{
		public void Initialize(InitializationEngine context)
		{
		}

		public void Uninitialize(InitializationEngine context)
		{
		}

		public void ConfigureContainer(ServiceConfigurationContext context)
		{
			context.Services.Configure<TinyMceConfiguration>(config =>
			{
				config.Default()
					.Width(748)
					.Height(450)
					.AddPlugin("code")
					.Toolbar("formatselect styleselect | bold italic | epi-link image epi-image-editor epi-personalized-content | bullist numlist outdent indent | code searchreplace fullscreen | help")
					.ContentCss("/static/css/bootstrap-4.3.1/bootstrap.css", "/static/css/default.css", "/static/css/fonts.css")
					/*
					.StyleFormats(
						new
						{
							title = "title-paragraph-styles",
							items = new[]
							{
								new { title = "title-introduction", selector = "p", classes = "introduction" },
								new { title = "title-ingress", selector = "p", classes = "ingress" }
							}
						}
					)
					.AddSetting("style_formats_autohide", true)
					.AddSetting("style_formats_merge", true)
					*/
					;
			});
		}
	}
}