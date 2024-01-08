using System;
using System.Text.Json;
using NineLivesCatRescueLibrary.Models;
using RestSharp;
using RestSharp.Serializers.Json;

namespace NineLivesCatRescueLibrary
{
    public class SubmitApplicationApiClient
    {
        RestClient _client;
        public SubmitApplicationApiClient()
        {
            var options = new RestClientOptions("https://toolkit.rescuegroups.org")
            {
                ThrowOnAnyError = true,
                ThrowOnDeserializationError = true,
            };


            _client = new RestClient(options, configureSerialization:
                s => s.UseSystemTextJson(new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    AllowTrailingCommas = true,
                }));
        }

        public async Task<bool> SubmitAdoptionApplication(AdoptionFormModel form)
        {
            var request = new RestRequest("of/f_process", Method.Post);
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Referer", "https://toolkit.rescuegroups.org/of/f?c=FWNNBBSC");
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            request.AddHeader("Host", "toolkit.rescuegroups.org");
            request.AddHeader("Origin", "https://toolkit.rescuegroups.org");
            request.AlwaysMultipartFormData = true;

            foreach (var param in form.AgeGroup)
            {
                request.AddParameter("q133616[]", param);
            }

            foreach (var param in form.HouseholdAllergies)
            {
                request.AddParameter("q104193[]", param);
            }

            foreach (var param in form.WhoDoYouLiveWith)
            {
                request.AddParameter("q104192[]", param);
            }

            foreach (var param in form.ReasonsForCat)
            {
                request.AddParameter("q104268[]", param);
            }

            request.AddObject(form);
            var response = await _client.ExecuteAsync(request).ConfigureAwait(false);

            return response.IsSuccessful;
        }

        public async Task<bool> SubmitFosterApplication(FosterFormModel form)
        {
            var request = new RestRequest("of/f_process", Method.Post);
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Referer", "https://toolkit.rescuegroups.org/of/f?c=XPSZPBRC");
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            request.AddHeader("Host", "toolkit.rescuegroups.org");
            request.AddHeader("Origin", "https://toolkit.rescuegroups.org");
            request.AlwaysMultipartFormData = true;

            foreach (var param in form.AgeGroup)
            {
                request.AddParameter("q133616[]", param);
            }
            
            foreach (var param in form.WhoDoYouLiveWith)
            {
                request.AddParameter("q104192[]", param);
            }

            foreach (var param in form.HouseholdAllergies)
            {
                request.AddParameter("q104193[]", param);
            }

            foreach (var param in form.TypeOfFostering)
            {
                request.AddParameter("q134519[]", param);
            }

            foreach (var param in form.FosterLengthOfTime)
            {
                request.AddParameter("q134521[]", param);
            }
            
            request.AddObject(form);
            var response = await _client.ExecuteAsync(request).ConfigureAwait(false);

            return response.IsSuccessful;
        }

        public async Task<bool> SubmitContactForm(ContactFormModel form)
        {
            var request = new RestRequest("of/f_process", Method.Post);
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Referer", "https://toolkit.rescuegroups.org/of/f?c=BBYJFNBT");
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            request.AddHeader("Host", "toolkit.rescuegroups.org");
            request.AddHeader("Origin", "https://toolkit.rescuegroups.org");
            request.AlwaysMultipartFormData = true;
            
            request.AddObject(form);
            var response = await _client.ExecuteAsync(request).ConfigureAwait(false);

            return response.IsSuccessful;
        }
    }
}