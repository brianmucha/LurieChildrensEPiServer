using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO._Base.Models.ViewModels
{
	/// <summary>
	/// Defines common characteristics for Block View Models in this solution, including properties used by layout files.
	/// </summary>
	/// <remarks>
	/// Views which handle several Block Types (T) can use this interface as model type rather than a
	/// concrete Block View Model class, utilizing the fact that this interface is covariant.
	/// </remarks>
	public interface IAOBaseBlockViewModel<out T> where T : AOBaseBlock
	{
		T CurrentBlock { get; }
	}
}
