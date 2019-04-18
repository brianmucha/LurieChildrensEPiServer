using EPiServer.Core;
using LurieChildrensFoundation._Base.Models.Blocks;

namespace LurieChildrensFoundation._Base.Models.ViewModels
{
	public class FndBaseBlockViewModel
	{
		/// <summary>
		/// Returns a BlockViewModel of type <typeparam name="T"/>.
		/// </summary>
		/// <remarks>
		/// Convenient method for creating BlockViewModels without having to specify the type as methods can use type inference while constructors cannot.
		/// </remarks>
		public static FndBaseBlockViewModel<T> Create<T>(T block) where T : FndBaseBlock
		{
			return new FndBaseBlockViewModel<T>(block);
		}
	}

	public class FndBaseBlockViewModel<T> : IFndBaseBlockViewModel<T> where T : FndBaseBlock
	{
		public FndBaseBlockViewModel(T currentBlock)
		{
			CurrentBlock = currentBlock;
		}

		public T CurrentBlock { get; private set; }
	}
}
