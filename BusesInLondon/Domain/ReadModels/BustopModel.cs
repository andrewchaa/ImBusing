using System.Collections.Generic;

namespace BusesInLondon.Domain.ReadModels
{
    public class BustopModel
    {
        public IEnumerable<ArrivalModel> Arrivals { get; set; }
        public string LastUpdated { get; set; }
    }
}