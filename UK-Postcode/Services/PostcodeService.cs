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
        private readonly DistanceService _distanceService;

        public PostcodeService(HttpClient client, DistanceService distanceService)
        {
            client.BaseAddress = new Uri("https://api.postcodes.io");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            _client = client;
            _distanceService = distanceService;
        }

        public async Task<AddressViewModel> GetAddress(string postcode)
        {
            var dto = await _client.GetFromJsonAsync<PostcodeDTO>($"/postcodes/{postcode}");

            if (dto.Status != 200)
            {
                throw new Exception("Postcode not found.");
            }

            var address = new AddressViewModel
            {
                Address = $"{dto.Result.AdminWard}, {dto.Result.Region}, {dto.Result.Country}",
                DistanceMI = _distanceService.Distance(dto.Result.Latitude, dto.Result.Longitude, DistanceUnit.MI),
                DistanceKM = _distanceService.Distance(dto.Result.Latitude, dto.Result.Longitude, DistanceUnit.KM)
            };

            return address;
        }
    }
}
