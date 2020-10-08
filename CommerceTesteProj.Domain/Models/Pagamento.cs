namespace CommerceTesteProj.Domain.Models
{
    public class Pagamento
    {
        public int produto_id { get; set; }
        public int qtde_comprada { get; set; }
        public CartaoDeCredito cartao { get; set; }
    }
}