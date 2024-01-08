using System;

namespace NineLivesCatRescueLibrary.Models
{
	public class IncludedModel
	{
		public string Type { get; set; }
		public string Id { get; set; }
		public AttributesModel Attributes { get; set; }
		public LinksModel Links { get; set; }
	}
}