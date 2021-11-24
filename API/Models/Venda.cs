namespace API.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public ItemVenda ItemVenda { get; set; }
        public int ItemVendaId { get; set; }
        public int FormaId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}