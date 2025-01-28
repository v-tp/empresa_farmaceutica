using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGestaoProdutos.Models
{
    [Table("medicamento")]
    public class Medicamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string? Descricao { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("qtd_estoque")]
        public int QtdEstoque { get; set; }

        [Column("id_usuario_inclusao")]
        public int IdUsuarioInclusao { get; set; }

        [Column("dt_inclusao")]
        public DateTime DtInclusao { get; set; }

        [Column("id_usuario_exclusao")]
        public int? IdUsuarioExclusao { get; set; }

        [Column("dt_exclusao")]
        public DateTime? DtExclusao { get; set; }
    }
}
