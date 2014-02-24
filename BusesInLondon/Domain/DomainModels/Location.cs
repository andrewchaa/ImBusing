using System;
using System.Linq;
using ImBusing.Domain.ReadModels;
using ImBusing.Domain.Services;

namespace ImBusing.Domain.DomainModels
{
    public class Location
    {
        private const decimal Delta = 0.005m;

        private readonly decimal _latitude;
        private readonly decimal _longitude;

        public decimal SwLat { get; private set; }
        public decimal SwLng { get; private set; }
        public decimal NeLat { get; private set; }
        public decimal NeLng { get; private set; }

        public Location(decimal latitude, decimal longitude)
        {
            _latitude = latitude;
            _longitude = longitude;

            SwLat = _latitude - Delta;
            SwLng = _longitude - Delta;
            NeLat = _latitude + Delta;
            NeLng = _longitude + Delta;
        }

        public LocationModel GetMarkers(ICountDownService countDownService)
        {
            var locationModel = countDownService.GetMarkers(SwLat, SwLng, NeLat, NeLng);
            foreach (var marker in locationModel.Markers)
            {
                marker.Delta = Math.Abs(_latitude - marker.Lat) + Math.Abs(_longitude - marker.Lng);
            }

            locationModel.Markers = locationModel.Markers.OrderBy(m => m.Delta);

            return locationModel;
        }
    }
}