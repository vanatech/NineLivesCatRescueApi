using System;
namespace NineLivesCatRescueLibrary.Models
{
	public class AvailableCatItem
	{
		public string ImageUrl { get; set; }
		public string AnimalName { get; set; }
		public string AnimalDescription { get; set; }
		public string AnimalBreed { get; set; }
		public string AnimalGender { get; set; }
		public string AnimalAgeGroup { get; set; }
		public ItemLink[] Links { get; set; }
	}

	public class ItemLink
	{
		public string Url { get; set; }
		public string Text { get; set; }
	}
}