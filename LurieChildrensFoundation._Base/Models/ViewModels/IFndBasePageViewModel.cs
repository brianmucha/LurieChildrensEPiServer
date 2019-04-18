using EPiServer.Core;

using LurieChildrensFoundation._Base.Models.Pages;

namespace LurieChildrensFoundation._Base.Models.ViewModels
{
	/// <summary>
	/// Defines common characteristics for Page View Models in this solution, including properties used by layout files.
	/// </summary>
	/// <remarks>
	/// Views which handle several Page Types (T) can use this interface as model type rather than a
	/// concrete Page View Model class, utilizing the fact that this interface is covariant.
	/// </remarks>
	public interface IFndBasePageViewModel<out T> where T : FndBasePage
	{
		T CurrentPage { get; }
//		LayoutModel Layout { get; set; }
		IContent Section { get; set; }
	}
}
