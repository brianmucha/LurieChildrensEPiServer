using EPiServer.Core;

using LurieChildrensFoundation._Base.Models.Blocks;

namespace LurieChildrensFoundation._Base.Models.ViewModels
{
	/// <summary>
	/// Defines common characteristics for Block View Models in this solution, including properties used by layout files.
	/// </summary>
	/// <remarks>
	/// Views which handle several Block Types (T) can use this interface as model type rather than a
	/// concrete Block View Model class, utilizing the fact that this interface is covariant.
	/// </remarks>
	public interface IFndBaseBlockViewModel<out T> where T : FndBaseBlock
	{
		T CurrentBlock { get; }
	}
}
