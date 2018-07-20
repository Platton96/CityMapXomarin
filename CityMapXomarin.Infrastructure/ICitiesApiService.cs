using CityMapXomarin.Models;
using System.Threading.Tasks;

namespace CityMapXomarin.Infrastructure
{
    public interface ICitiesApiService
    {
        Task<Data> GetDataAsync();
    }
}
