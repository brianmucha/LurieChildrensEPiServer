using EPiServer.Core;

namespace LurieChildrensFoundation._Base.Models.Pages
{
	public interface IFndBasePage
	{
		ContentArea MainContentArea { get; set; }

		string MetaTitle { get; set; }
		string MetaDescription { get; set; }
		string MetaRobots { get; set; }
	}
}
