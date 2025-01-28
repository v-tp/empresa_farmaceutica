namespace BlazorGestaoProdutos.Data
{
    public class MateriaPrimaMedicamento
    {
        public const string Endpoint = "/api/MateriaPrimaMedicamento";

        public int Id { get; set; }
        public int IdMateriaPrima { get; set; }
        public int IdMedicamento { get; set; }
        public int IdUsuarioInclusao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int? IdUsuarioExclusao { get; set; }
        public DateTime? DtExclusao { get; set; }
    }
}