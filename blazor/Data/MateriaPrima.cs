namespace BlazorGestaoProdutos.Data
{
    public class MateriaPrima
    {
        public const string Endpoint = "/api/MateriaPrima";
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string Fornecedor { get; set; }
        public int QtdEstoque { get; set; }
        public DateTime DtValidade { get; set; }
        public int IdUsuarioInclusao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int? IdUsuarioExclusao { get; set; }
        public DateTime? DtExclusao { get; set; }
    }
}
