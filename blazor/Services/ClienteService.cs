using BlazorGestaoProdutos.Data;

namespace BlazorGestaoProdutos.Services
{
    public class ClienteService : IClienteService
    {
        private HttpClient http;
        private string Url;

        public ClienteService(HttpClient _http)
        {
            http = _http;
            Url = Environment.GetEnvironmentVariable("URL_API") + Cliente.Endpoint;
        }

        public async Task<List<Cliente>> GetClientes()
        {
            var clientes = await http.GetFromJsonAsync<List<Cliente>>(Url);

            // remove as exclusões lógicas
            clientes = clientes?.Where(m => m.DtExclusao == null).ToList();

            return clientes;
        }

        public async Task<bool> CadastrarCliente(Cliente c)
        {
            c.DtInclusao = DateTime.Now;
            c.IdUsuarioInclusao = 1;
            var response = await http.PostAsJsonAsync(Url, c);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletarCliente(Cliente c)
        {
            c.DtExclusao = DateTime.Now;
            c.IdUsuarioExclusao = 1;
            var response = await http.PutAsJsonAsync($"{Url}/{c.Id}", c);
            return response.IsSuccessStatusCode;
        }
    }
}
