namespace BlazorGestaoProdutos.Data
{
    public class UsuarioSistema
    {
        public const string Endpoint = "/api/UsuarioSistema";

        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdUsuarioInclusao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int? IdUsuarioExclusao { get; set; }
        public DateTime? DtExclusao { get; set; }
    }
}
