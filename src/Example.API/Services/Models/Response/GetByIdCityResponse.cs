using Example.API._Common;
using Example.API.Services.Models.Dtos;

namespace Example.API.Services.Models.Response
{
    public class GetByIdCityResponse : BaseResponse
    {
        public CityDto City { get; set; }
    }
}
