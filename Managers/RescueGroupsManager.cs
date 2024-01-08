using System.Text.Json;
using System.Web;
using NineLivesCatRescueLibrary.ApiClients;
using NineLivesCatRescueLibrary.Enums;
using NineLivesCatRescueLibrary.Models;

namespace NineLivesCatRescueApi.Managers;

public class RescueGroupsManager
{
    private RescueGroupsApiClient _rescueGroupsApiClient;
    
    public RescueGroupsManager(RescueGroupsApiClient rescueGroupsApiClient)
    {
        _rescueGroupsApiClient = rescueGroupsApiClient;
    }

    public async Task<string> GetFeaturedCats()
    {
        var result = await _rescueGroupsApiClient.GetAvailableAnimalsAsync().ConfigureAwait(false);
        
        var featuredCats = ProcessCats(result);

        var catArray = featuredCats.Where(x=> x.Attributes.Name != "Barn cats" && x.Attributes.Name != "Expert Mouser")
            .OrderBy(x => x.Attributes.AvailableDate)
            .Take(3)
            .ToArray();
        
        string catJsonArray = JsonSerializer.Serialize(catArray);
        return catJsonArray;
    }
    
    public async Task<string> GetAvailableCatsByFilter()
    {
        var result = await _rescueGroupsApiClient.GetAvailableAnimalsAsync().ConfigureAwait(false);

        IList<CatModel> availableCats = ProcessCats(result);

        var catArray = availableCats.Where(x => x.Attributes.Name != "Barn cats" && x.Attributes.Name != "Expert Mouser")
            .ToArray();

        string catJsonArray = JsonSerializer.Serialize(catArray);
        return catJsonArray;
    }

    private IList<CatModel> ProcessCats(RootModel rootModel)
    {
        IList<CatModel> cats = new List<CatModel>();
        var currentAvailableCats = rootModel.Data;
        var includedPictures = rootModel.Included.Where(x => x.Type == "pictures").ToList();

        foreach (var animal in currentAvailableCats)
        {
            if (animal.Attributes.Qualities is not null && animal.Attributes.Qualities.Any())
            {
                animal.Attributes.Qualities.RemoveAll(x => !PetQualityBehaviorEnums.behaviorQualities.Contains(x));
                animal.Attributes.Qualities = animal.Attributes.Qualities.Take(3).ToList();
                for (int i = 0; i < animal.Attributes.Qualities.Count; i++)
                {
                    animal.Attributes.Qualities[i] = (string)typeof(PetQualityBehaviorEnums).GetField(animal.Attributes.Qualities[i]).GetValue(null);;
                }
            }

            animal.Attributes.Qualities ??= new List<string>();

            if (!String.IsNullOrWhiteSpace(animal.Attributes.DescriptionText))
            {
                animal.Attributes.DescriptionText = animal.Attributes.DescriptionText.Replace("\n", "");
                animal.Attributes.DescriptionText = HttpUtility.HtmlDecode(animal.Attributes.DescriptionText);
            }

            CatModel cat = new()
            {
                Attributes = animal.Attributes,
                Pictures = includedPictures.Where(x => animal.Relationships != null && animal.Relationships.Pictures.Data.Select(y => y.Id).Contains(x.Id)),
                PrimaryPictureUrl = ProcessImages(animal, includedPictures)
            };

            cats.Add(cat);
        }

        return cats;
    }
    
    private string ProcessImages(DataModel animal, IList<IncludedModel> pictures)
    {
        string imageUrl = "";
        if (animal.Relationships?.Pictures == null)
        { 
            imageUrl = "https://s3.amazonaws.com/imagesroot.rescuegroups.org/webpages/s8916nwf3l60z82l.jpg";
            return imageUrl;
        }
        
        var animalPictures1 = animal.Relationships.Pictures.Data.Select(x => x.Id);

        var animalPictures = pictures.Where(x => animalPictures1.Contains(x.Id));
        
        return animalPictures.FirstOrDefault(x => x.Attributes.Order == 1).Attributes.Original.Url;
    }
}