using FIX_API_Test.Models;
using RestSharp;

namespace FIX_API_Test
{
    public class Helper
    {
        public static IRestResponse<RegisteredResponse> GetResponse(string methodName, RegistrationUserData user)
        {
            var client = new RestClient(Settings.Default.baseURL);
            var request = new RestRequest(methodName, Method.GET);
            request.AddObject(user);
            return client.Execute<RegisteredResponse>(request);
        }

        public static IRestResponse<NotRegisteredResponse> GetErrorResponse(string methodName, RegistrationUserData user)
        {
            var client = new RestClient(Settings.Default.baseURL);
            var request = new RestRequest(methodName, Method.GET);
            request.AddObject(user);
            return client.Execute<NotRegisteredResponse>(request);
        }
    }
}
