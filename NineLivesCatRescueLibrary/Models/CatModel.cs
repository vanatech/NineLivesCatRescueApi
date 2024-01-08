namespace NineLivesCatRescueLibrary.Models;

public class CatModel
{
	public AttributesModel Attributes { get; set; }
	public IEnumerable<IncludedModel> Pictures { get; set; }
	public string PrimaryPictureUrl { get; set; }
}