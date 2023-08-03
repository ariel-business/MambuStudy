using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;
using Microsoft.Net.Http.Headers;

namespace MambuStudy.Application.Services
{
    public class DepositAccountService : IDepositAccountService
    {
        private HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public DepositAccountService(IConfiguration configuration)
        {
            _configuration = configuration;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_configuration.GetSection("MambuApiConfiguration:BaseUrl").Value);
            _httpClient.DefaultRequestHeaders.Add("apiKey", _configuration.GetSection("MambuApiConfiguration:ApiKey").Value);
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, $"application/vnd.mambu.{_configuration.GetSection("MambuApiConfiguration:Version").Value}+json");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");
        }

        public async Task<ApiResult<List<DepositAccountResponse>>> Get(int? limit, int? offset)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"deposits?limit={limit}&offset={offset}");

            var result = httpResponseMessage.GetApiResult<List<DepositAccountResponse>>();

            return result;
        }

        public async Task<ApiResult<DepositAccountResponse>> Create(CreateDepositAccountRequest depositAccountRequest)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("deposits", depositAccountRequest);

            var result = httpResponseMessage.GetApiResult<DepositAccountResponse>();

            return result;
        }

        public async Task<ApiResult<DepositAccountResponse>> GetById(string depositAccountId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"deposits/{depositAccountId}");

            var result = httpResponseMessage.GetApiResult<DepositAccountResponse>();

            return result;
        }

        public async Task<ApiResult<object>> Delete(string depositAccountId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.DeleteAsync($"deposits/{depositAccountId}");

            var result = httpResponseMessage.GetApiResult<object>();

            return result;
        }
    }
}
