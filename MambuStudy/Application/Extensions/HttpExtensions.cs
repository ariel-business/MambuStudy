using MambuStudy.Application.ViewModel.Response;
using MambuStudy.Domain.Models;
using Newtonsoft.Json;
using System.Net;

namespace MambuStudy.Application.Extensions
{
    public static class HttpExtensions
    {
        public static ApiResult<T> GetApiResult<T>(this HttpResponseMessage message) where T : class
        {
            using var body = message.Content.ReadAsStream();
            using var sr = new StreamReader(body);
            var content = sr.ReadToEnd();

            if (message.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<T>(content);
                return new ApiResult<T>(data, message.StatusCode);
            }

            if (!message.IsSuccessStatusCode)
            {
                var errors = JsonConvert.DeserializeObject<ErrorResponse>(content);
                return new ApiResult<T>(default(T), message.StatusCode, errors);
            }

            return null;
        }
    }
}
