using Jil;
using Newtonsoft.Json;
using System.Net;

namespace Test_Travis_CI_Integration
{
    static class WebCaller
    {
        internal static JsonSerializerSettings GetSettings()
        {
            //return new Options
            //(      
            //    excludeNulls: false,
            //    includeInherited: true,
            //    serializationNameFormat: SerializationNameFormat.CamelCase
            //);

            return new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
            };
        }

        internal static string Post(string url, string tenantId, string value)
        {
            var webClient = new WebClient();
            webClient.Headers["Content-Type"] = "application/json";
            var response = webClient.UploadString(url, value);
            return response;
        }

        internal static string Get(string url, string tenantId, string value)
        {
            var client = new WebClient();          
            client.Headers["Content-Type"] = "application/json";
            return client.DownloadString(url);
        }

        internal static string Put(string url, string tenantId, string recordId)
        {
            var client = new WebClient();            
            client.Headers["Content-Type"] = "application/json";
            return client.DownloadString(url);
        }
    }
}
