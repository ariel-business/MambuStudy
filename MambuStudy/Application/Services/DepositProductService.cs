using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;
using Microsoft.Net.Http.Headers;
using System.Collections.Generic;

namespace MambuStudy.Application.Services
{
    public class DepositProductService : IDepositProductService
    {
        private HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public DepositProductService(IConfiguration configuration)
        {
            _configuration = configuration;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_configuration.GetSection("MambuApiConfiguration:BaseUrl").Value);
            _httpClient.DefaultRequestHeaders.Add("apiKey", _configuration.GetSection("MambuApiConfiguration:ApiKey").Value);
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, $"application/vnd.mambu.{_configuration.GetSection("MambuApiConfiguration:Version").Value}+json");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");
        }

        public async Task<ApiResult<List<DepositProductResponse>>> Get(int? limit, int? offset, string? detailsLevel = "FULL")
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"depositproducts?limit={limit}&offset={offset}&detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<List<DepositProductResponse>>();

            return result;
        }
    }
}
