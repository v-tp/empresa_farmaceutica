using BlazorGestaoProdutos.Data;

namespace BlazorGestaoProdutos.Services
{
    public interface IMedicamentoService
    {
        Task<List<Medicamento>> GetMedicamentos();
        Task<bool> CadastrarMedicamento(Medicamento m);
        Task<bool> DeletarMedicamento(Medicamento m);
    }
}
