using System.Text.Json;
using Microsoft.Extensions.Configuration;
using NineLivesCatRescueLibrary.Models;
using RestSharp;
using RestSharp.Serializers.Json;

namespace NineLivesCatRescueLibrary.ApiClients
{
	public class RescueGroupsApiClient
	{
		RestClient _client;
		IConfiguration _config;
		private string _apiKey;
		public RescueGroupsApiClient(IConfiguration config)
		{
			_config = config;
			var options = new RestClientOptions("https://api.rescuegroups.org/v5")
			{
				ThrowOnAnyError = true,
				ThrowOnDeserializationError = true
			};


			_client = new RestClient(options, configureSerialization:
				s => s.UseSystemTextJson(new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true,
					AllowTrailingCommas = true,
				}));

			_apiKey = _config["RescueGroupsApiKey"];
		}

		public async Task<RootModel> GetAvailableAnimalsAsync()
		{
			var request = new RestRequest();
			request.AddHeader("Authorization", _apiKey);
			request.Resource = "public/orgs/8916/animals/search/available";
			request.AddQueryParameter("limit", 50);
			request.AddQueryParameter("include", "pictures");
			var response = await _client.GetAsync<RootModel>(request).ConfigureAwait(false);
			return response;
		}

		public async Task<RootModel> GetOrganizationInfoAsync()
		{
			var request = new RestRequest();
			request.AddHeader("Authorization", "placeHolder");
			request.Resource = "public/orgs/8916";
			request.AddQueryParameter("limit", 50);
			var response = await _client.GetAsync<RootModel>(request).ConfigureAwait(false);
			return response;
		}
	}
}