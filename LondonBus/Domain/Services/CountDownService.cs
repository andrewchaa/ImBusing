using System.Collections.Generic;
using System.Net;
using ImBusing.Domain.ReadModels;
using ServiceStack.Text;

namespace ImBusing.Domain.Services
{
    public class CountDownService : ICountDownService
    {
        private readonly WebClient _webClient;
        private const string CountDownRoot = "http://countdown.tfl.gov.uk";

        public CountDownService()
        {
            _webClient = new WebClient();
        }

        public BustopModel GetBustopDetails(int bustopCode)
        {
            string api = CountDownRoot + "/stopBoard/" + bustopCode;
            string contents = _webClient.DownloadString(api);

            return JsonSerializer.DeserializeFromString<BustopModel>(contents);
        }

        public LocationModel GetMarkers(decimal swLat, decimal swLng, decimal neLat, decimal neLng)
        {
            string api = string.Format("{0}/markers/swLat/{1}/swLng/{2}/neLat/{3}/neLng/{4}/",
                CountDownRoot, swLat, swLng, neLat, neLng);
            string contents = _webClient.DownloadString(api);

            return JsonSerializer.DeserializeFromString<LocationModel>(contents);
        }
    }
}