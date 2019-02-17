using Digipix.Domain;
using Digipix.Infrastructure.Service.Constants;
using Digipix.Infrastructure.Service.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Digipix.Infrastructure.Service.Implementations
{
    public class EnderecoService : IEnderecoService
    {
        private HttpClient _httpClient;

        public EnderecoService()
        {
        }

        public async Task<EnderecoDomain> GetByZipCode(string zipCode)
        {
            using (var _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri(EndPoints.URL);

                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + EndPoints.JWTToken);

                var result = await _httpClient.GetAsync(EndPoints.Get + zipCode);

                return JsonConvertService<EnderecoDomain>.Deserialize(result.Content.ReadAsStringAsync().Result);
            }
        }
    }
}

