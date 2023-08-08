using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Services
{
    public class DepositProductService : IDepositProductService
    {
        IHttpClientFactory _httpClientFactory;

        public DepositProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<List<DepositProductResponse>>> GetAll(int? limit, int? offset, string? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"depositproducts?limit={limit}&offset={offset}&detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<List<DepositProductResponse>>();

            return result;
        }

        public async Task<ApiResult<DepositProductResponse>> GetById(string depositProductId, string? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"depositproducts/{depositProductId}?detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<DepositProductResponse>();

            return result;
        }
    }
}
