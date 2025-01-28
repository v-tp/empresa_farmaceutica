using BlazorGestaoProdutos.Data;

namespace BlazorGestaoProdutos.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetClientes();
        Task<bool> CadastrarCliente(Cliente c);
        Task<bool> DeletarCliente(Cliente c);
    }
}
