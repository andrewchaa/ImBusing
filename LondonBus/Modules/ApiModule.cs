using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImBusing.Domain.DomainModels;
using ImBusing.Domain.Services;
using Nancy;

namespace ImBusing.Modules
{
    public class ApiModule : NancyModule
    {
        public ApiModule(ICountDownService countDownService)
        {
            Get["/api/bustops/{code}"] = parameters => {
                    var bustop = new Bustop(parameters.code);
                    return bustop.GetBustopDetails(countDownService);
                };

            Get["/api/bustops/latitude/{latitude}/longitude/{longitude}"] = _ =>
                {
                    var location = new Location(_.Latitude, _.Longitude);
                    return location.GetMarkers(countDownService);
                };

        }
    }
}