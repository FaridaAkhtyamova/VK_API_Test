using RestSharp;
using System.Collections.Generic;

namespace FIX_API_Test.Models
{
    public class RegisteredResponse : RestResponse
    {
        public List<Response> response { get; set; }
    }

    public class Response
    {
        public string sid { get; set; }
    }
}
