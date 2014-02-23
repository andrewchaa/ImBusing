using System.Collections.Generic;
using ServiceStack;

namespace ImBusing.Domain.ReadModels
{
    public class Marker
    {
        public string Direction { get; set; }
        public string Id { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Name { get; set; }
        public string Towards { get; set; }
        public IEnumerable<BusRoute> Routes { get; set; }

        public string RoutesString
        {
            get { return Routes.Join(", "); }
        }
    }
}