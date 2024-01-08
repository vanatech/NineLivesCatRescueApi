using System;
using System.Xml.Linq;

namespace NineLivesCatRescueLibrary.Models
{
	public class DataModel
	{
		public string Type { get; set; }
		public string Id { get; set; }
		public AttributesModel Attributes { get; set; }
		public RelationshipModel? Relationships { get; set; }
	}
}