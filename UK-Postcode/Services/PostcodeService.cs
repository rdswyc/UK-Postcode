using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UK_Postcode.Models;

namespace UK_Postcode.Services
{
    public class PostcodeService
    {
        private HttpClient _client { get; }

        public PostcodeService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.postcodes.io");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            _client = client;
        }

        public async Task<Postcode> GetPostcode(string postcode)
        {
            var response = await _client.GetFromJsonAsync<Postcode>($"/postcodes/{postcode}");
            return response;
        }
    }
}
