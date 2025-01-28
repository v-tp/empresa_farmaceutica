using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGestaoProdutos.Models
{
    [Table("materia_prima_medicamento")]
    public class MateriaPrimaMedicamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_materia_prima")]
        public int IdMateriaPrima { get; set; }

        [Column("id_medicamento")]
        public int IdMedicamento { get; set; }

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
