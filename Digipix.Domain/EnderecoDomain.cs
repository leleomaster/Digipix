using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipix.Domain
{
    public class EnderecoDomain
    {
        [JsonProperty(PropertyName = "street")]
        public string Logradouro { get; set; }
        
        [JsonProperty(PropertyName = "neighborhood")]
        public string Bairro { get; set; }

        [JsonProperty(PropertyName = "state_short")]
        public string Estado { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string Cidade { get; set; }

        [JsonProperty(PropertyName = "zipcode")]
        public string Cep { get; set; }
        
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}

