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
            decimal delta = 0.005m;
//            decimal delta = 0.01m;

            SwLat = latitude - delta;
            SwLng = longitude - delta;
            NeLat = latitude + delta;
            NeLng = longitude + delta;
        }

        public LocationModel GetMarkers(ICountDownService countDownService)
        {
            return countDownService.GetBustops(SwLat, SwLng, NeLat, NeLng);
        }
    }
}