using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Services
{
    public class DepositAccountService : IDepositAccountService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DepositAccountService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<List<DepositAccountResponse>>> Get(int? limit, int? offset)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"deposits?limit={limit}&offset={offset}");

            var result = httpResponseMessage.GetApiResult<List<DepositAccountResponse>>();

            return result;
        }

        public async Task<ApiResult<DepositAccountResponse>> Create(CreateDepositAccountRequest depositAccountRequest)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync("deposits", depositAccountRequest);

            var result = httpResponseMessage.GetApiResult<DepositAccountResponse>();

            return result;
        }

        public async Task<ApiResult<DepositAccountResponse>> GetById(string depositAccountId)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"deposits/{depositAccountId}");

            var result = httpResponseMessage.GetApiResult<DepositAccountResponse>();

            return result;
        }

        public async Task<ApiResult<object>> Delete(string depositAccountId)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync($"deposits/{depositAccountId}");

            var result = httpResponseMessage.GetApiResult<object>();

            return result;
        }
    }
}
