using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;
    
        public ClientService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<List<ClientResponse>>> GetAll(int? limit, int? offset, string? detailsLevel) 
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"clients?limit={limit}&offset={offset}&detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<List<ClientResponse>>();

            return result;
        }

        public async Task<ApiResult<ClientResponse>> Create(CreateClientRequest clientRequest)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync("clients", clientRequest);

            var result = httpResponseMessage.GetApiResult<ClientResponse>();

            return result;
        }

        public async Task<ApiResult<ClientResponse>> GetById(string clientId, string? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"clients/{clientId}?detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<ClientResponse>();

            return result;
        }

        public async Task<ApiResult<object>> Delete(string clientId)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync($"clients/{clientId}");

            var result = httpResponseMessage.GetApiResult<object>();

            return result;
        }
    }
}
