using FAK.CopaFilmes.Api.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FAK.CopaFilmes.Api.Infraestrutura
{
    public class EmpresaApiCliente
    {
        private readonly HttpClient _httpClient;

        public EmpresaApiCliente(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<FilmeModel>> ObterFilmesAsync()
        {
            HttpResponseMessage resposta = await _httpClient.GetAsync($"api/filmes");
            resposta.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<List<FilmeModel>>(await resposta.Content.ReadAsStringAsync());
        }
    }
}
