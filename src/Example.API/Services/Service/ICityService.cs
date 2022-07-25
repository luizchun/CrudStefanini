using Example.API.Services.Models.Request;
using Example.API.Services.Models.Response;

namespace Example.API.Services.Service
{
    public interface ICityService
    {
        Task<GetAllCityResponse> GetAllAsync();
        Task<GetByIdCityResponse> GetByIdAsync(int id);
        Task<CreateCityResponse> CreateAsync(CreateCityRequest request);
        Task<UpdateCityResponse> UpdateAsync(int id, UpdateCityRequest request);
        Task<DeleteCityResponse> DeleteAsync(int id);
    }
}
