using System;
namespace NineLivesCatRescueLibrary.Models
{
	public class FosterFormModel : ContactInfoModel
	{
		public string formid { get; set; } = "6838";
		public string siteid { get; set; } = "8916";
		public string confirm_js { get; set; } = "Correct";
		public string submitForm { get; set; } = "Submit!";
		public string c { get; set; } = "XPSZPBRC";

		//q133616[]
		public HashSet<string> AgeGroup { get; set; }

		//rentorown
		public string q104237 { get; set; }

		//q104192[]
		public HashSet<string> WhoDoYouLiveWith { get; set; }

		//q104193[]
		public HashSet<string> HouseholdAllergies { get; set; }

		//household agree with fostering 
		public string q134518 { get; set; }

		//animals already in household
		public string q134517 { get; set; }

		//q134519[]
		public HashSet<string> TypeOfFostering { get; set; }

		//q134521[]
		public HashSet<string> FosterLengthOfTime { get; set; }

		//where will cat spend night
		public string q104278 { get; set; }

		//where will cat spend day 
		public string q104277 { get; set; }

		//visit agreement
		public string q137107 { get; set; }

		//commentsquestions
		public string q120684 { get; set; }
	}
}