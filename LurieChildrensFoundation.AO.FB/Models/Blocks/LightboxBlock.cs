using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

using System.Text;

namespace LurieChildrensFoundation.AO.FB.Models.Blocks
{
	[ContentType(
		DisplayName = "Lightbox Block",
		Description = "",
		GUID = "6DE0EE6D-A3AD-444A-9AB6-125543F86BA3")]
	[ImageUrl("~/ClientResources/Images/LightboxBlock.png")]
	public class LightboxBlock : BlockData
	{
		[CultureSpecific]
		[Display(
			Name = "Content",
			Description = "The HTML content for the Lightbox",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		[UIHint(UIHint.Textarea)]
		public virtual string Content { get; set; }

		[CultureSpecific]
		[Display(
			Name = "Code",
			Description = "The script content for the Lightbox",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		[UIHint(UIHint.Textarea)]
		public virtual string Code { get; set; }

		[CultureSpecific]
		[Display(
			Name = "Styles",
			Description = "The style content for the Lightbox",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		[UIHint(UIHint.Textarea)]
		public virtual string Styles { get; set; }

		public override void SetDefaultValues(ContentType contentType)
		{
			base.SetDefaultValues(contentType);

			StringBuilder contentString = new StringBuilder();
			contentString.Append("<div class=\"lightbox-wrapper\">").AppendLine();
			contentString.Append("	<h1 class=\"lightbox-headline\"></h1>").AppendLine();
			contentString.Append("	<p class=\"lightbox-content\"></p>").AppendLine();
			contentString.Append("	<a class=\"lightbox-button\" href=\"https://luriechildrens.org/donate\">Donate</a>").AppendLine();
			contentString.Append("</div>").AppendLine();

			StringBuilder scriptString = new StringBuilder();
			scriptString.Append("<script type=\"text/javascript\">").AppendLine();
			scriptString.Append("	$(document).ready()").AppendLine();
			scriptString.Append("	{").AppendLine();
			scriptString.Append("		$(\"#campaign-lightbox\").madDismissible({").AppendLine();
			scriptString.Append("			'cookieName': 'mad-cookie',").AppendLine();
			scriptString.Append("			'width': 600,").AppendLine();
			scriptString.Append("			'speed': 1000,").AppendLine();
			scriptString.Append("			'modal': true,").AppendLine();
			scriptString.Append("			'autoCenter': true,").AppendLine();
			scriptString.Append("			'startBottom': true,").AppendLine();
			scriptString.Append("			'overlaySpeed': 250,").AppendLine();
			scriptString.Append("			'expireDays': 1,").AppendLine();
			scriptString.Append("			'openDelay': 5000,").AppendLine();
			scriptString.Append("			'openCallback': function() { }").AppendLine();
			scriptString.Append("		});").AppendLine();
			scriptString.Append("		$(\"#campaign-lightbox\").madDismissible(\"open\");").AppendLine();
			scriptString.Append("	}").AppendLine();
			scriptString.Append("</script>").AppendLine();

			StringBuilder styleString = new StringBuilder();
			styleString.Append("<style type=\"text/css\">").AppendLine();
			styleString.Append("	.lightbox-wrapper { }").AppendLine();
			styleString.Append("	.lightbox-headline { }").AppendLine();
			styleString.Append("	.lightbox-content { }").AppendLine();
			styleString.Append("	.lightbox-button { }").AppendLine();
			styleString.Append("</style>").AppendLine();

			Content = contentString.ToString();
			Code = scriptString.ToString();
			Styles = styleString.ToString();
		}
	}
}