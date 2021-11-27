using System.Net.Http;
using System.Threading.Tasks;

namespace SpaceTraders
{
    public class SpaceTradersClient
    {
        private readonly HttpClient _httpClient;
        public SpaceTradersClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}