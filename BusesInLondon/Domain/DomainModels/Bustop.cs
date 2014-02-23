using ImBusing.Domain.ReadModels;
using ImBusing.Domain.Services;

namespace ImBusing.Domain.DomainModels
{
    public class Bustop
    {
        private readonly int _code;

        public Bustop(int code)
        {
            _code = code;
        }

        public BustopModel GetBustopDetails(ICountDownService service)
        {
            return service.GetBustopDetails(_code);
        }
    }
}