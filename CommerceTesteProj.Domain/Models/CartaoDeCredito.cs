namespace CommerceTesteProj.Domain.Models
{
    public class CartaoDeCredito
    {
        public string titular { get; set; }
        public string numero { get; set; }
        public string data_expiracao { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
    }
}