using Jil;
using System.Collections.Generic;

namespace Test_Travis_CI_Integration.Models
{
    class RestResponse
    {
        [JilDirective(Name = "messages")]
        public string[] Messages { get; set; }

        [JilDirective(Name = "result")]
        public List<BaseModel> Result { get; set; }
    }

    class Response
    {
        [JilDirective(Name = "RestResponse")]
        public RestResponse RestResponse { get; set; }
    }
}
