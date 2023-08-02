using System.Net;

namespace MambuStudy.Domain.Models
{
    public class ApiResult<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }

        public ApiResult()
        {
        }

        public ApiResult(T data, HttpStatusCode statusCode)
        {
            Data = data;
            StatusCode = statusCode;
        }
    }
}
