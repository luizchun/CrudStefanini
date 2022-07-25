using Example.API.Services.Models.Request;
using Example.API.Services.Models.Response;

namespace Example.API.Services.Service
{
    public interface IPeopleService
    {
        Task<GetAllPeopleResponse> GetAllAsync();
        Task<GetByIdPeopleResponse> GetByIdAsync(int id);
        Task<CreatePeopleResponse> CreateAsync(CreatePeopleRequest request);
        Task<UpdatePeopleResponse> UpdateAsync(int id, UpdatePeopleRequest request);
        Task<DeletePeopleResponse> DeleteAsync(int id);
    }
}
