using BlazorGestaoProdutos.Data;

namespace BlazorGestaoProdutos.Services
{
    public interface IPedidoService
    {
        Task<List<Pedido>> GetPedidos();
        Task<bool> CadastrarPedido(Pedido p);
        Task<bool> DeletarPedido(Pedido p);
    }
}
