using System.Net;

namespace Movie.Domain.Models
{
    public class BaseServiceResponse
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public BaseServiceResponse(HttpStatusCode statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }


    public class BaseServiceResponse<T> : BaseServiceResponse
    {
        public T Data { get; set; }

        public BaseServiceResponse(HttpStatusCode statusCode, string message) : base(statusCode, message)
        {
        }

        public BaseServiceResponse(T data, HttpStatusCode statusCode, string message) : base(statusCode, message)
        {
            Data = data;
        }
    }
}
