using System.Configuration;
using Test_Travis_CI_Integration.Models;

namespace Test_Travis_CI_Integration
{
    static class GetRecords
    {
        internal static Response GetCountryDetails(string countryCode)
        {
            var url = ConfigurationManager.AppSettings["apiUrl"] + countryCode + "/all";
            var result = WebCaller.Get(url, "", "");
            Response value = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(result, WebCaller.GetSettings());
            return value;
        }

        internal static Response GetSateDetailsOnCountry(string countryCode, string stateCode)
        {
            var url = ConfigurationManager.AppSettings["apiUrl"] + countryCode + stateCode;
            var result = WebCaller.Get(url, "", "");
            Response value = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(result, WebCaller.GetSettings());
            //JSON.Deserialize<Response>(result, WebCaller.GetSettings());
            return value;
        }
    }
}
