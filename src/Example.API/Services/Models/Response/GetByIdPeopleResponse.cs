using Example.API._Common;
using Example.API.Services.Models.Dtos;

namespace Example.API.Services.Models.Response
{
    public class GetByIdPeopleResponse : BaseResponse
    {
        public PeopleDto People { get; set; }
    }
}
