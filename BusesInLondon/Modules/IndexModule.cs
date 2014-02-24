using ImBusing.Domain.DomainModels;
using ImBusing.Domain.Services;
using Nancy;

namespace ImBusing.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule(ICountDownService countDownService)
        {
            Get["/"] = parameters => View["index"];
            Get["/stopcode/{stopcode}"] = _ => View["stopcode", _.stopcode];
        }
    }
}