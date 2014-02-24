using System.Collections.Generic;
using ImBusing.Domain.ReadModels;

namespace ImBusing.Domain.Services
{
    public interface ICountDownService
    {
        BustopModel GetBustopDetails(int bustopCode);
        LocationModel GetMarkers(decimal swLat, decimal swLng, decimal neLat, decimal neLng);
    }
}