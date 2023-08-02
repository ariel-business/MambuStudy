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
            
            if (message.StatusCode == HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<T>(content);
                return new ApiResult<T>(data, HttpStatusCode.OK);
            }
            
            if (message.StatusCode == HttpStatusCode.Created)
            {
                var data = JsonConvert.DeserializeObject<T>(content);
                return new ApiResult<T>(data, HttpStatusCode.Created);
            }

            message.EnsureSuccessStatusCode();
            
            return null;
        }
    }
}
