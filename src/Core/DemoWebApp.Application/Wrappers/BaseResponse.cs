using System.Net;

namespace DemoWebApp.Application.Wrappers
{
    public class BaseResponse<T>
    {
        public bool IsOk { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
        public List<Exception>? Exceptions { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }

        public BaseResponse()
        {
            IsOk = true;
            Message = string.Empty;
            Exceptions = null;
            HttpStatusCode = HttpStatusCode.OK;
        }
    }
}
