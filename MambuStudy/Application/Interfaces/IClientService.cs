using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IClientService
    {
        Task<ApiResult<List<ClientResponse>>> GetAll(int? limit, int? offset, string? detailsLevel);
        Task<ApiResult<ClientResponse>> Create(CreateClientRequest clientRequest);
        Task<ApiResult<ClientResponse>> GetById(string clientId, string? detailsLevel);
        Task<ApiResult<object>> Delete(string clientId);
    }
}
