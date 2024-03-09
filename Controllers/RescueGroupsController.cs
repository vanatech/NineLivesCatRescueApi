using Microsoft.AspNetCore.Mvc;
using NineLivesCatRescueApi.Managers;
using NineLivesCatRescueLibrary.Models;
using Serilog;

namespace NineLivesCatRescueApi.Controllers
{
    [Route("api/rescue-groups")]
    [ApiController]
    public class RescueGroupsController : ControllerBase
    {
        private RescueGroupsManager _rescueGroupsManager;
        
        public RescueGroupsController(RescueGroupsManager rescueGroupsManager)
        {
            _rescueGroupsManager = rescueGroupsManager;
        }

        [Route("available")]
        [HttpGet]
        public async Task<string> GetAvailableCatsByFilter()
        {
            string error;
            try
            {
                var result = await _rescueGroupsManager.GetAvailableCatsByFilter().ConfigureAwait(false);
                return result;
            }
            catch (Exception e)
            {
                Log.Logger.Error(e.ToString());
                error = e.ToString();
            }

            return error;
        }

        [Route("available/featured")]
        [HttpGet]
        public async Task<string> GetFeaturedCats()
        {
            string error;
            try
            {
                var result = await _rescueGroupsManager.GetFeaturedCats().ConfigureAwait(false);
                return result;
            }
            catch (Exception e)
            {
                Log.Logger.Error(e.ToString());
                error = e.ToString();
            }

            return error;
        }
        
        // [Route("organization")]
        // [HttpGet]
        // public async Task<RootModel> GetOrganizationInfo()
        // {
        //     var organization = await _rescueGroupsApiClient.GetOrganizationInfoAsync().ConfigureAwait(false);
        //     return organization;
        // }

        // [Route("adoption-application")]
        // [HttpPost]
        // public async Task<bool> SubmitAdoptionApplication([FromBody] AdoptionFormModel adoptionForm)
        // {
        //     bool success = await _rescueGroupsManager.SaveAdoptionApplication(adoptionForm)
        //         .ConfigureAwait(false);
        //     return success;
        // }

        // [Route("foster-application")]
        // [HttpPost]
        // public async Task<bool> SubmitFosterApplication([FromBody] FosterFormModel fosterForm)
        // {
        //     bool success = await _submitApplicationApiClient.SubmitFosterApplication(fosterForm)
        //         .ConfigureAwait(false);
        //     return success;
        // }
        //
        // [Route("contact-form")]
        // [HttpPost]
        // public async Task<bool> SubmitContactForm([FromBody] ContactFormModel contactForm)
        // {
        //     bool success = await _submitApplicationApiClient.SubmitContactForm(contactForm)
        //         .ConfigureAwait(false);
        //     return success;
        // }
    }
}
