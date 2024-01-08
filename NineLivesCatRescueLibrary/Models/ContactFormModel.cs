using System;
namespace NineLivesCatRescueLibrary.Models
{
	public class ContactFormModel : ContactInfoModel
	{
		public string formid { get; set; } = "6982";
		public string siteid { get; set; } = "8916";
		public string confirm_js { get; set; } = "Correct";
		public string submitForm { get; set; } = "Submit!";
		public string c { get; set; } = "BBYJFNBT";

		//q136504[]: 
		public IEnumerable<string> HowDidYouHearAboutUs { get; set; }

		//q136505[]
		public IEnumerable<string> ReasonForInteraction { get; set; }

		//DonationInspiration
		public string q136507 { get; set; }

		//donation impact
		public string q136508 { get; set; }

		//what would you like to see from organization
		public string q136509 { get; set; }

		//better communication on impact of donor dollars
		public string q136510 { get; set; }

		//q136511[]
		public IEnumerable<string> ProgressUpdates { get; set; }

		//Overall experience with 9LCR
		public string q136517 { get; set; }

		//donation likelihood again
		public string q136513 { get; set; }

		//q136514[]
		public IEnumerable<string> Merchandise { get; set; }

		//q136515[]
		public IEnumerable<string> Fundraising { get; set; }

		//how would you like to be involved
		public string q136516 { get; set; }

		//anything else/questions
		public string q126061 { get; set; }
	}
}