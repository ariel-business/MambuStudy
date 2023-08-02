using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;
using Microsoft.Net.Http.Headers;

namespace MambuStudy.Application.Services
{
    public class ClientService : IClientService
    {
        private HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public ClientService(IConfiguration configuration)
        {
            _configuration = configuration;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_configuration.GetSection("mambuApiConfiguration:baseUrl").Value);
            _httpClient.DefaultRequestHeaders.Add("apiKey", _configuration.GetSection("mambuApiConfiguration:apiKey").Value);
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/vnd.mambu.v2+json");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");
        }

        public async Task<ApiResult<List<ClientResponse>>> Get(int? limit, int? offset)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"clients?limit={limit}&offset={offset}");

            var result = httpResponseMessage.GetApiResult<List<ClientResponse>>();

            return result;
        }

        public async Task<ApiResult<ClientResponse>> Create(CreateClientRequest clientRequest)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("clients", clientRequest);

            var result = httpResponseMessage.GetApiResult<ClientResponse>();

            return result;
        }

        public async Task<ApiResult<ClientResponse>> GetById(string clientId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"clients/{clientId}");

            var result = httpResponseMessage.GetApiResult<ClientResponse>();

            return result;
        }

        public async Task<ApiResult<object>> Delete(string clientId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.DeleteAsync($"clients/{clientId}");

            var result = httpResponseMessage.GetApiResult<object>();

            return result;
        }
    }
}
