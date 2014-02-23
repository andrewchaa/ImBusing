namespace BusesInLondon.Domain.ReadModels
{
    public class ArrivalModel
    {
        public string Destination { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public string EstimatedWait { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsRealTime { get; set; }
        public string ScheduledTime { get; set; }
    }
}