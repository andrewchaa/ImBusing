using System.Collections.Generic;

namespace ImBusing.Domain.ReadModels
{
    public class BustopModel
    {
        public IEnumerable<ArrivalModel> Arrivals { get; set; }
        public string LastUpdated { get; set; }
    }
}