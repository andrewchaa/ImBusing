using BusesInLondon.Domain.DomainModels;
using BusesInLondon.Domain.Services;
using Nancy;

namespace BusesInLondon.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule(ICountDownService countDownService)
        {

            Get["/"] = parameters => View["index"];

            Get["/bustops/{code}"] = parameters =>
                {
                    var bustop = new Bustop(parameters.code);
                    return bustop.GetBustopDetails(countDownService);
//                    string api = "http://countdown.tfl.gov.uk/stopBoard/" + parameters.id;
//                    var client = new WebClient();
//                    string contents = client.DownloadString(api);
//
//                    return JsonSerializer.DeserializeFromString<BustopModel>(contents);
                };

        }
    }
}