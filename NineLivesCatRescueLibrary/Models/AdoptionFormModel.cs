using System;
using System.Text.Json.Serialization;

namespace NineLivesCatRescueLibrary.Models
{
    public class AdoptionFormModel : ContactInfoModel
    {
        public string formid { get; set; } = "5072";
        public string siteid { get; set; } = "8916";
        public string confirm_js { get; set; } = "Correct";
        public string submitForm { get; set; } = "Submit!";
        public string c { get; set; } = "FWNNBBSC";
        //county
        public string q102111 { get; set; }

        //animal you want to adopt
        public string q127995 { get; set; }

        [JsonPropertyName("q133616[]")]
        public IEnumerable<string> AgeGroup { get; set; }

        //commitment
        public string q104282 { get; set; }

        [JsonPropertyName("q104192[]")]
        public IEnumerable<string> WhoDoYouLiveWith { get; set; }

        [JsonPropertyName("q104193[]")]
        public IEnumerable<string> HouseholdAllergies { get; set; }

        //house type
        public string q104238 { get; set; }
        //rent or own
        public string q104237 { get; set; }
        //rent at
        public string q104259 { get; set; }
        //landlord number
        public string q104258 { get; set; }
        //extra deposit 
        public string q104260 { get; set; }
        //employed
        public string q104261 { get; set; }
        //employer info
        public string q104264 { get; set; }
        //previous owned pets num
        public string q104266 { get; set; }
        //pet history
        public string q138290 { get; set; }
        //given away pet
        public string q104286 { get; set; }
        //who pet will live with
        public string q104267 { get; set; }

        [JsonPropertyName("q104268[]")]
        public IEnumerable<string> ReasonsForCat { get; set; }

        //where will cat live 
        public string q104270 { get; set; }

        //care for cat when gone 
        public string q104271 { get; set; }

        //handle clawing issues 
        public string q104288 { get; set; }

        //handle elimination issues 
        public string q104289 { get; set; }

        //current vet
        public string q104274 { get; set; }

        //spend on vet care
        public string q104280 { get; set; }

        //flea preventative
        public string q104275 { get; set; }

        //allow visit
        public string q104279 { get; set; }

        //vet and landlord release
        public string q104285 { get; set; }

        //signature
        public string q102135 { get; set; }

    }
}