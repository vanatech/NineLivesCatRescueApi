using System;
using System.Drawing;

namespace NineLivesCatRescueLibrary.Models
{
	public class RelationshipModel
	{
		public DataDetailModel? Breeds { get; set; }
		public DataDetailModel? Colors { get; set; }
		public DataDetailModel? Species { get; set; }
		public DataDetailModel? Statuses { get; set; }
		public DataDetailModel? Locations { get; set; }
		public DataDetailModel? Orgs { get; set; }
		public DataDetailModel? Pictures { get; set; }
		public DataDetailModel? Patterns { get; set; }
	}
}