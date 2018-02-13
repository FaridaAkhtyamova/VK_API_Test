using RestSharp;
using System.Collections.Generic;

namespace FIX_API_Test.Models
{
    public class NotRegisteredResponse : RestResponse
    {
        public List<Error> error { get; set; }

    }

    public class Error
    {
        public int error_code { get; set; }
        public string error_msg { get; set; }
    }
}
