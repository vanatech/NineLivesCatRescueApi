using Microsoft.AspNetCore.Mvc;
using NineLivesCatRescue.Managers;

namespace NineLivesCatRescue.Controllers
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
            var result = await _rescueGroupsManager.GetAvailableCatsByFilter().ConfigureAwait(false);
            return result;
        }

        [Route("available/featured")]
        [HttpGet]
        public async Task<string> GetFeaturedCats()
        {
            var result = await _rescueGroupsManager.GetFeaturedCats().ConfigureAwait(false);
            return result;
        }
        
        /*[Route("organization")]
        [HttpGet]
        public async Task<RootModel> GetOrganizationInfo()
        {
            var organization = await _rescueGroupsApiClient.GetOrganizationInfoAsync().ConfigureAwait(false);
            return organization;
        }

        [Route("adoption-application")]
        [HttpPost]
        public async Task<bool> SubmitAdoptionApplication([FromBody] AdoptionFormModel adoptionForm)
        {
            bool success = await _submitApplicationApiClient.SubmitAdoptionApplication(adoptionForm)
                .ConfigureAwait(false);
            return success;
        }

        [Route("foster-application")]
        [HttpPost]
        public async Task<bool> SubmitFosterApplication([FromBody] FosterFormModel fosterForm)
        {
            bool success = await _submitApplicationApiClient.SubmitFosterApplication(fosterForm)
                .ConfigureAwait(false);
            return success;
        }

        [Route("contact-form")]
        [HttpPost]
        public async Task<bool> SubmitContactForm([FromBody] ContactFormModel contactForm)
        {
            bool success = await _submitApplicationApiClient.SubmitContactForm(contactForm)
                .ConfigureAwait(false);
            return success;
        }*/
    }
}
