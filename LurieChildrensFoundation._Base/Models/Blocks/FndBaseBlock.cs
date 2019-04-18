using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace LurieChildrensFoundation._Base.Models.Blocks
{
	/// <summary>
	/// This Block Type defines common content and meta data for all blocks.
	/// </summary>
	public class FndBaseBlock : BlockData, IFndBaseBlock
	{

	}
}