
using LurieChildrensFoundation.AO._Base.Models.Blocks;

namespace LurieChildrensFoundation.AO._Base.Models.ViewModels
{
	public class AOBaseBlockViewModel
	{
		/// <summary>
		/// Returns a BlockViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating BlockViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		public static AOBaseBlockViewModel<T> Create<T>(T block) where T : AOBaseBlock
		{
			return new AOBaseBlockViewModel<T>(block);
		}
	}

	public class AOBaseBlockViewModel<T> : IAOBaseBlockViewModel<T> where T : AOBaseBlock
	{
		public AOBaseBlockViewModel(T currentBlock)
		{
			CurrentBlock = currentBlock;
		}

		public T CurrentBlock { get; private set; }
	}
}
