using BlazorGestaoProdutos.Data;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorGestaoProdutos.Services
{
    public class MedicamentoService : IMedicamentoService
    {
        private HttpClient http;
        private string Url = Environment.GetEnvironmentVariable("URL_API") + Medicamento.Endpoint;

        public MedicamentoService(HttpClient _http)
        {
            http = _http;
        }

        public async Task<List<Medicamento>> GetMedicamentos()
        {
            var medicamentos = await http.GetFromJsonAsync<List<Medicamento>>(Url);

            // remove as exclusões lógicas
            medicamentos = medicamentos?.Where(m => m.DtExclusao == null).ToList();

            return medicamentos;
        }

        public async Task<bool> CadastrarMedicamento(Medicamento m)
        {
            m.DtInclusao = DateTime.Now;
            m.IdUsuarioInclusao = 1;
            var response = await http.PostAsJsonAsync(Url, m);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletarMedicamento(Medicamento m)
        {
            m.DtExclusao = DateTime.Now;
            m.IdUsuarioExclusao = 1;
            var response = await http.PutAsJsonAsync($"{Url}/{m.Id}", m);
            return response.IsSuccessStatusCode;
        }
    }
}