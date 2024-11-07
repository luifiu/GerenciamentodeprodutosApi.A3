namespace GerenciadorDeProdutos.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? DescriÇao { get; set; }
        public decimal Preço { get; set; }
        public int Quantidade { get; set; }
    }
}
