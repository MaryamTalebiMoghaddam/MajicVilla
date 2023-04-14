using System.Net;

namespace MagicVilla_VillaApi.Models
{
    public class APIResponse
    {
        public APIResponse()
        {
            ErrorMessage = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        //public bool SuccessFlage(bool IsSuccess)
        //{
        //    if (StatusCode)
        //    {

        //    }
        //    return IsSuccess;
        //}
        public List<string> ErrorMessage { get; set; }
        public object Result { get; set; }
    }
}
