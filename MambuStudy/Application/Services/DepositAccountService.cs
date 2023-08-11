using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Enums;
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

        public async Task<ApiResult<List<DepositAccountResponse>>> GetAll(int? limit, int? offset, DetailsLevel? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"deposits?limit={limit}&offset={offset}&detailsLevel={detailsLevel}");

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

        public async Task<ApiResult<DepositAccountResponse>> GetById(string depositAccountId, DetailsLevel? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"deposits/{depositAccountId}?detailsLevel={detailsLevel}");

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

        public async Task<ApiResult<DepositAccountResponse>> ChangeDepositAccountState(string depositAccountId, ChangeDepositAccountStateRequest changeDepositAccountStateRequest)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync($"deposits/{depositAccountId}:changeState", changeDepositAccountStateRequest);

            var result = httpResponseMessage.GetApiResult<DepositAccountResponse>();

            return result;
        }

        public async Task<ApiResult<List<DepositTransactionResponse>>> GetAllTransactions(string depositAccountId, int? limit, int? offset, DetailsLevel? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"deposits/{depositAccountId}/transactions?limit={limit}&offset={offset}&detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<List<DepositTransactionResponse>>();

            return result;
        }

        public async Task<ApiResult<DepositTransactionResponse>> MakeDeposit(string depositAccountId, MakeDepositTransactionRequest makeDepositTransactionRequest)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync($"deposits/{depositAccountId}/deposit-transactions", makeDepositTransactionRequest);

            var result = httpResponseMessage.GetApiResult<DepositTransactionResponse>();

            return result;
        }

        public async Task<ApiResult<DepositAccountResponse>> StartDepositAccountMaturity(string depositAccountId, StartDepositAccountMaturityRequest startDepositAccountMaturityRequest)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync($"deposits/{depositAccountId}:startMaturity", startDepositAccountMaturityRequest);

            var result = httpResponseMessage.GetApiResult<DepositAccountResponse>();

            return result;
        }

        public async Task<ApiResult<object>> UndoDepositAccountMaturity(string depositAccountId, UndoDepositAccountMaturityRequest? undoDepositAccountMaturityRequest)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync($"deposits/{depositAccountId}:undoMaturity", undoDepositAccountMaturityRequest);

            var result = httpResponseMessage.GetApiResult<object>();

            return result;
        }
    }
}
