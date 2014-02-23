using System.Net;
using BusesInLondon.Domain.ReadModels;
using ServiceStack.Text;

namespace BusesInLondon.Domain.Services
{
    public class CountDownService : ICountDownService
    {
        public BustopModel GetBustopDetails(int bustopCode)
        {
            string api = "http://countdown.tfl.gov.uk/stopBoard/" + bustopCode;
            string contents = new WebClient().DownloadString(api);

            return JsonSerializer.DeserializeFromString<BustopModel>(contents);
        } 
    }
}