using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGestaoProdutos.Models
{
    [Table("pedido_medicamento")]
    public class PedidoMedicamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_pedido")]
        public int IdPedido { get; set; }

        [Column("id_medicamento")]
        public int IdMedicamento { get; set; }

        [Column("quantidade_medicamento")]
        public int QuantidadeMedicamento { get; set; }

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
