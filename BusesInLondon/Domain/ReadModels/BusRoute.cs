namespace ImBusing.Domain.ReadModels
{
    public class BusRoute
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}