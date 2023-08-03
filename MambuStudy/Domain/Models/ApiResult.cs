using MambuStudy.Application.ViewModel.Response;
using System.Net;
using System.Text.Json.Serialization;

namespace MambuStudy.Domain.Models
{
    public class ApiResult<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public T Data { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ErrorResponse Errors { get; set; }

        public ApiResult()
        {
        }

        public ApiResult(T data, HttpStatusCode statusCode)
        {
            Data = data;
            StatusCode = statusCode;
            IsSuccess = true;
        }

        public ApiResult(T data, HttpStatusCode statusCode, ErrorResponse errors)
        {
            Data = data;
            StatusCode = statusCode;
            Errors = errors;
            IsSuccess = false;
        }
    }
}
