namespace BlazorGestaoProdutos.Data
{
    public class PedidoMedicamento
    {
        public const string Endpoint = "/api/PedidoMedicamento";

        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdMedicamento { get; set; }
        public int QuantidadeMedicamento { get; set; }
        public int IdUsuarioInclusao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int? IdUsuarioExclusao { get; set; }
        public DateTime? DtExclusao { get; set; }
    }
}
