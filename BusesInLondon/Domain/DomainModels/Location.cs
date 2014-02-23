using System.Collections.Generic;
using ImBusing.Domain.ReadModels;
using ImBusing.Domain.Services;

namespace ImBusing.Domain.DomainModels
{
    public class Location
    {
        public decimal SwLat { get; private set; }
        public decimal SwLng { get; private set; }
        public decimal NeLat { get; private set; }
        public decimal NeLng { get; private set; }

        public Location(decimal latitude, decimal longitude)
        {
            SwLat = latitude - 0.01m;
            SwLng = longitude - 0.01m;
            NeLat = latitude + 0.01m;
            NeLng = longitude + 0.01m;
        }

        public LocationModel GetMarkers(ICountDownService countDownService)
        {
            return countDownService.GetBustops(SwLat, SwLng, NeLat, NeLng);
        }
    }
}