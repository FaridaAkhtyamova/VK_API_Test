using FIX_API_Test.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Linq;

namespace FIX_API_Test
{
    [TestClass]
    public class RegistrationTests
    {
        string methodName = "auth.signup";

        [TestMethod]
        public void TestRegisterValidUser()
        {
            RegistrationUserData user = new RegistrationUserData()
            {
                first_name = "Иван",
                last_name = "Иванов",
                client_id = 3697615,
                client_secret = "AlVXZFMUqyrnABp8ncuU",
                phone = "89118745678",
                password = "123123Aa",
                test_mode = 1,
                sex = 2
            };

            IRestResponse<RegisteredResponse> response = Helper.GetResponse(methodName, user);
            Assert.IsNotNull(response.Data.response.FirstOrDefault().sid);
        }

        [TestMethod]
        public void TestRegisterInvalidUser()
        {
            RegistrationUserData user = new RegistrationUserData()
            {
                first_name = "Иван",
                last_name = "Иванов",
                client_id = 3697615,
                client_secret = "AlVXZFMUqyrnABp8ncuU",
                phone = "",
                password = "123123Aa",
                test_mode = 1,
                sex = 2
            };

            IRestResponse<NotRegisteredResponse> response = Helper.GetErrorResponse(methodName, user);

            Assert.IsTrue(response.Data.error.FirstOrDefault().
                error_code == 100);
            Assert.IsTrue(response.Data.error.FirstOrDefault().
                error_msg == "One of the parameters specified was missing or invalid: phone is undefined");
        }
    }
}
