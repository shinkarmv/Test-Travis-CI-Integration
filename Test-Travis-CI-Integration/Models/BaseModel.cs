using Jil;

namespace Test_Travis_CI_Integration.Models
{
    class BaseModel
    {
        [JilDirective(Name = "id")]
        public string Id { get; set; }

        [JilDirective(Name = "country")]
        public string Country { get; set; }

        [JilDirective(Name = "name")]
        public string Name { get; set; } 

        [JilDirective(Name = "abbr")]
        public string Abbreviation { get; set; }

        [JilDirective(Name = "area")]
        public string Area { get; set; }

        [JilDirective(Name = "largest_city")]
        public string LargestCity { get; set; }

        [JilDirective(Name = "capital")]
        public string Capital { get; set; }
    }
}
