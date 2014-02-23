using System.Collections.Generic;

namespace ImBusing.Domain.ReadModels
{
    public class LocationModel
    {
        public IEnumerable<Marker> Markers { get; set; } 
    }
}