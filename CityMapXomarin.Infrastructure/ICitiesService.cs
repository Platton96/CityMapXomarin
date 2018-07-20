using CityMapXomarin.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityMapXomarin.Infrastructure
{
    public interface ICitiesService
    {
        Task<IEnumerable<CityModel>> GetCitiesAsync();
    }
}
