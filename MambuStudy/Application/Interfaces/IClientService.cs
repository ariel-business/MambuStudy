using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Enums;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Interfaces
{
    public interface IClientService
    {
        Task<ApiResult<List<ClientResponse>>> GetAll(int? limit, int? offset, DetailsLevel? detailsLevel);
        Task<ApiResult<ClientResponse>> Create(CreateClientRequest clientRequest);
        Task<ApiResult<ClientResponse>> GetById(string clientId, DetailsLevel? detailsLevel);
        Task<ApiResult<object>> Delete(string clientId);
    }
}
