using System.Net;

namespace Mango.Product.API.DTOs
{
    public class ResponseDTO<T>
    {
        public bool IsSuccess { get; set; }
        public T Result { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
