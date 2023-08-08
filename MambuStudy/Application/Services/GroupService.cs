using MambuStudy.Application.Extensions;
using MambuStudy.Application.Interfaces;
using MambuStudy.Application.ViewModel.Request;
using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Enums;
using MambuStudy.Domain.Models;

namespace MambuStudy.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GroupService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<List<GroupResponse>>> GetAll(int? limit, int? offset, DetailsLevel? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"groups?limit={limit}&offset={offset}&detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<List<GroupResponse>>();

            return result;
        }

        public async Task<ApiResult<GroupResponse>> Create(CreateGroupRequest groupRequest)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync("groups", groupRequest);

            var result = httpResponseMessage.GetApiResult<GroupResponse>();

            return result;
        }

        public async Task<ApiResult<GroupResponse>> GetById(string groupId, DetailsLevel? detailsLevel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"groups/{groupId}?detailsLevel={detailsLevel}");

            var result = httpResponseMessage.GetApiResult<GroupResponse>();

            return result;
        }

        public async Task<ApiResult<object>> Delete(string groupId)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("mambuApi");

            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync($"groups/{groupId}");

            var result = httpResponseMessage.GetApiResult<object>();

            return result;
        }
    }
}
