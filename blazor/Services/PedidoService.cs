using BlazorGestaoProdutos.Data;
using System.Net.Http.Json;

namespace BlazorGestaoProdutos.Services
{
    public class PedidoService : IPedidoService
    {
        private HttpClient http;
        private string Url = Environment.GetEnvironmentVariable("URL_API") + Pedido.Endpoint;

        public PedidoService(HttpClient _http)
        {
            http = _http;
        }

        public async Task<List<Pedido>> GetPedidos()
        {
            var pedidos = await http.GetFromJsonAsync<List<Pedido>>(Url);

            // Remove as exclusões lógicas
            pedidos = pedidos?.Where(p => p.DtExclusao == null).ToList();

            return pedidos;
        }

        public async Task<bool> CadastrarPedido(Pedido p)
        {
            p.DtInclusao = DateTime.Now;
            p.IdUsuarioInclusao = 1;
            var response = await http.PostAsJsonAsync(Url, p);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletarPedido(Pedido p)
        {
            p.DtExclusao = DateTime.Now;
            p.IdUsuarioExclusao = 1;
            var response = await http.PutAsJsonAsync($"{Url}/{p.Id}", p);
            return response.IsSuccessStatusCode;
        }
    }
}
