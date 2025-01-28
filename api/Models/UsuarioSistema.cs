using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGestaoProdutos.Models
{
    [Table("usuario_sistema")]
    public class UsuarioSistema
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

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
