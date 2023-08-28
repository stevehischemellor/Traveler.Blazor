using Traveler.Blazor.Client.Models;

namespace Traveler.Blazor.Client.Services
{
    public interface IParksService
    {
        Task<ParkModel> GetParkByIdAsync(int id);
        Task<List<ParkModel>> GetParksAsync();
    }
}