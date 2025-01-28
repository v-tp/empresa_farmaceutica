using BlazorGestaoProdutos.Data;

namespace BlazorGestaoProdutos.Services
{
    public interface IMateriaPrimaService
    {
        Task<List<MateriaPrima>> GetMateriasPrimas();
        Task<bool> CadastrarMateriaPrima(MateriaPrima m);
        Task<bool> DeletarMateriaPrima(MateriaPrima m);
    }
}
