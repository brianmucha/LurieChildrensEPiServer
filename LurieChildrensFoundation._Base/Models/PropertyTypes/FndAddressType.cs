using System;
using System.ComponentModel.DataAnnotations;using System.Text;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

using LurieChildrensFoundation._Base.Models.Blocks;

namespace LurieChildrensFoundation._Base.Models.PropertyTypes
{
	/// <summary>
	/// This Property Type is used to define a postal address.
	/// </summary>
	public class FndAddressType : FndBaseBlock
	{
		[Display(
			Name = "Recipient Line",
			Description = "The name of the occupant or business.")]
		public virtual String RecipientLine { get; set; }

		[Display(
			Name = "Delivery Line",
			Description = "The house number and street name in the format: 123 S Michigan Ave.")]
		[Required]
		public virtual String DeliveryLine { get; set; }

		[Display(
			Name = "Last Line",
			Description = "The city, state and zip code in the format: Chicago, IL 60601.")]
		[Required]
		public virtual String LastLine { get; set; }

		public String ToEncodedString()
		{
			StringBuilder sb = new StringBuilder();

			if (!String.IsNullOrWhiteSpace(RecipientLine))
			{
				sb.Append(RecipientLine);
				sb.Append(" ");
			}

			sb.Append(DeliveryLine);
			sb.Append(" ");

			sb.Append(LastLine);

			return sb.ToString().Replace(" ", "+");
		}
	}
}