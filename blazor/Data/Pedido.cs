namespace BlazorGestaoProdutos.Data
{
    public class Pedido
    {
        public const string Endpoint = "/api/Pedido";

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdUsuarioInclusao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int? IdUsuarioExclusao { get; set; }
        public DateTime? DtExclusao { get; set; }
    }
}
