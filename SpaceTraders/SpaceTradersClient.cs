using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Models;
using Newtonsoft.Json;

namespace Blazor.SpaceTraders
{
    public class SpaceTradersClient
    {
        private readonly HttpClient _httpClient;
        public SpaceTradersClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<InitialContactResponse> GetOnlineStatus()
        {
            return await Get<InitialContactResponse>("/game/status");
        }

        private async Task<T> Get<T>(string uri)
        {
            try
            {
                var response = await _httpClient.GetAsync(uri);
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseJson);
            }
            catch (Exception e)
            {
                throw new HttpRequestException($"Failed to retrieve Status: {e}");
            }
        }
    }
}