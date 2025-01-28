using BlazorGestaoProdutos.Data;
using System.Runtime.CompilerServices;

namespace BlazorGestaoProdutos.Services
{
    public class MateriaPrimaService(HttpClient _http) : IMateriaPrimaService
    {
        private HttpClient http = _http;
        private string Url = Environment.GetEnvironmentVariable("URL_API") + MateriaPrima.Endpoint;

        public async Task<List<MateriaPrima>> GetMateriasPrimas()
        {
            var materiasPrimas = await http.GetFromJsonAsync<List<MateriaPrima>>(Url);

            // remove as exclusões lógicas
            materiasPrimas = materiasPrimas?.Where(m => m.DtExclusao == null).ToList();

            return materiasPrimas;
        }

        public async Task<bool> CadastrarMateriaPrima(MateriaPrima m)
        {
            m.DtInclusao = DateTime.Now;
            m.IdUsuarioInclusao = 1;
            var response = await http.PostAsJsonAsync<MateriaPrima>(Url, m);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletarMateriaPrima(MateriaPrima m)
        {
            m.DtExclusao = DateTime.Now;
            m.IdUsuarioExclusao = 1;
            var response = await http.PutAsJsonAsync($"{Url}/{m.Id}", m);

            return response.IsSuccessStatusCode;
        }   
    }
}
