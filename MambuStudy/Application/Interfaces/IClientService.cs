using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IClientService
    {
        Task<ApiResult<List<ClientResponse>>> Get(int? limit, int? offset);
        Task<ApiResult<ClientResponse>> Create(CreateClientRequest clientRequest);
        Task<ApiResult<ClientResponse>> GetById(string clientId);
        Task<ApiResult<object>> Delete(string clientId);
    }
}
