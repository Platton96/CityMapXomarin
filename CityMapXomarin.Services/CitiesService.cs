using CityMapXomarin.Infrastructure;
using CityMapXomarin.Models;
using CityMapXomarin.Services.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityMapXomarin.Services
{
    public class CitiesService : ICitiesService
    {
        ICitiesApiService _citiesApiService;

        public CitiesService()
        {
            _citiesApiService = new CitiesApiService();
        }

        public async Task<IEnumerable<CityModel>> GetCitiesAsync()
        {
            return (await _citiesApiService.GetDataAsync()).Cities;
        }
    }
}
