using Traveler.Blazor.Client.Models;
using System.Text.Json;
using Traveler.Blazor.Client.Components;

namespace Traveler.Blazor.Client.Services
{
    public class ParksService : IParksService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ParksService> _logger;

        public ParksService(HttpClient httpClient, ILogger<ParksService> logger) 
        { 
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<List<ParkModel>> GetParksAsync()
        {
            List<ParkModel>? parks = null;
            try
            {
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.Headers.Add("x-api-key", "SoIpYXCex2dFwt5Hb9Oab4PdbVJswl30IRTAM9cE");
                request.RequestUri = new Uri("https://developer.nps.gov/api/v1/parks");

                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStreamAsync();
                var result = await JsonSerializer.DeserializeAsync<NpsResponseModel<List<ParkModel>>>(content);

                parks = result?.Data ?? new List<ParkModel>();
            }
            catch(Exception ex) 
            {
                _logger.LogError(ex, ex.Message);
            }
            return parks;
        }

        public async Task<ParkModel> GetParkByIdAsync(int id)
        {
            ParkModel? park = null;
            try
            {
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.Headers.Add("x-api-key", "SoIpYXCex2dFwt5Hb9Oab4PdbVJswl30IRTAM9cE");
                request.RequestUri = new Uri("https://developer.nps.gov/api/v1/parks");

                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStreamAsync();
                var result = await JsonSerializer.DeserializeAsync<NpsResponseModel<ParkModel>>(content);

                park = result?.Data ?? new ParkModel();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return park;
        }
    }
}
