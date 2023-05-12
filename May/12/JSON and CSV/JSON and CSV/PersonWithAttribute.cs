using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_and_CSV
{
    public class PersonWithAttribute
    {
        [JsonProperty("p_id")]
        public int Id { get; set; }

        [JsonProperty("p_name")]
        public string Name { get; set; }

        [JsonProperty("p_surname")]
        public string Surname { get; set; }

        [JsonProperty("p_email")]
        public string Email { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("p_country")]
        public string Country { get; set; }
    }
}
