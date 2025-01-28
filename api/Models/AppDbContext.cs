using Microsoft.EntityFrameworkCore;
using ApiGestaoProdutos.Models;

namespace ApiGestaoProdutos.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Cliente> Cliente { get; set;}
        public DbSet<MateriaPrima> MateriaPrima { get; set;}
        public DbSet<MateriaPrimaMedicamento> MateriaPrimaMedicamento {  get; set;}
        public DbSet<Medicamento> Medicamento { get; set;}
        public DbSet<Pedido> Pedido { get; set;}    
        public DbSet<PedidoMedicamento> PedidoMedicamento { get; set;}
        public DbSet<ApiGestaoProdutos.Models.UsuarioSistema> UsuarioSistema { get; set; } = default!;
    }
}
