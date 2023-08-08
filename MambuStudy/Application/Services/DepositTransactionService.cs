using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Services
{
    public class DepositTransactionService : IDepositTransactionService
    {
        IHttpClientFactory _httpClientFactory;

        public DepositTransactionService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<DepositTransactionResponse>> GetById(string depositTransactionId, string? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"deposits/transactions/{depositTransactionId}?detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<DepositTransactionResponse>();

            return result;
        }
    }
}
