using System;
namespace NineLivesCatRescueLibrary.Models
{
    public class AttributesModel
    {
        public bool IsAdoptionPending { get; set; }
        public string AgeGroup { get; set; }
        public string AgeString { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsBirthDateExact { get; set; }
        public string BreedString { get; set; }
        public string BreedPrimary { get; set; }
        public int BreedPrimaryId { get; set; }
        public bool IsBreedMixed { get; set; }
        public string CoatLength { get; set; }
        public bool IsCourtesyListing { get; set; }
        public string DescriptionHtml { get; set; }
        public string DescriptionText { get; set; }
        public bool IsFound { get; set; }
        public string FoundDate { get; set; }
        public string FoundPostalcode { get; set; }
        public int Priority { get; set; }
        public bool IsHousetrained { get; set; }
        public string KillReason { get; set; }
        public string Name { get; set; }
        public int PictureCount { get; set; }
        public string PictureThumbnailUrl { get; set; }
        public string SearchString { get; set; }
        public string Sex { get; set; }
        public string SizeGroup { get; set; }
        public string SizeUOM { get; set; }
        public string Slug { get; set; }
        public bool IsSponsorable { get; set; }
        public string TrackerimageUrl { get; set; }
        public int VideoCount { get; set; }
        public int VideoUrlCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string AdoptionFeeString { get; set; }
        public DateTime? AvailableDate { get; set; }
        public bool? IsCurrentVaccinations { get; set; }
        public List<string> Qualities { get; set; }
        public bool? IsCatsOk { get; set; }
        public bool? IsKidsOk { get; set; }
        public string ActivityLevel { get; set; }
        public string IndoorOutdoor { get; set; }
        public string NewPeopleReaction { get; set; }
        public string BreedSecondary { get; set; }
        public int? BreedSecondaryId { get; set; }
        public string Singular { get; set; }
        public string Plural { get; set; }
        public string YoungSingular { get; set; }
        public string YoungPlural { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Citystate { get; set; }
        public string Postalcode { get; set; }
        public string Country { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public string Coordinates { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string FacebookUrl { get; set; }
        public string AdoptionProcess { get; set; }
        public string About { get; set; }
        public string Services { get; set; }
        public string Type { get; set; }
        public ImageDetailsModel Original { get; set; }
        public ImageDetailsModel Large { get; set; }
        public ImageDetailsModel Small { get; set; }
        public int? Order { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}