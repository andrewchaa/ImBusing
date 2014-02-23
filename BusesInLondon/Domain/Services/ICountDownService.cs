using BusesInLondon.Domain.ReadModels;

namespace BusesInLondon.Domain.Services
{
    public interface ICountDownService
    {
        BustopModel GetBustopDetails(int bustopCode);
    }
}