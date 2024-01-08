using System;
namespace NineLivesCatRescueLibrary.Models
{
	public class NineLivesStateManagementModel
	{
		public List<DataModel> AvailableAnimals { get; set; }
		public List<IncludedModel> IncludedAnimalPictures { get; set; }
		public DataModel OrganizationInfo { get; set; }
		public DateTime LastUpdatedDate { get; set; }
		public IList<AvailableCatItem> FavoriteCats { get; set; } = new List<AvailableCatItem>();
	}
}