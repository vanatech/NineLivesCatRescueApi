namespace NineLivesCatRescueLibrary.Enums;

public static class PetQualityBehaviorEnums
{
	public const string eagerToPlease = "eager to please";
	public const string lap = "lap pet";
	public const string playsToys = "likes toys";
	public const string playful = "playful";
	public const string obedient = "obedient";
	public const string affectionate = "affectionate";
	public const string timid = "timid/shy";
	public const string goofy = "goofy";
	public const string gentle = "gentle";
	public const string eventempered = "even-tempered";
	public const string intelligent = "intelligent";
	public const string skittish = "skittish";

	public static IList<string> behaviorQualities = new List<string>()
	{
		"eagerToPlease", 
		"affectionate", 
		"obedient", 
		"eventempered", 
		"gentle", 
		"goofy", 
		"intelligent", 
		"lap",
		"timid",
		"playful",
		"gentle",
		"playsToys",
		"skittish"
	};
}