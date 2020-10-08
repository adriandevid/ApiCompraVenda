namespace CommerceTesteProj.Domain.Models
{
    public class Produto
    {
        public int produto_id { get; set; }  
        public string nome { get; set; }
        public double valor_unitario { get; set; }
        public double qtde_estoque { get; set; }
    }
}