using System.Threading.Tasks;
using CommerceTesteProj.Domain.Models;

namespace CommerceTesteProj.Domain.Interface
{
    public interface ProdutoRepository
    {
        void Add(Produto entity);
        void Remove(Produto entity);
        void UpDate(Produto entity);
        void SaveChanges();
        Produto[] GetAllProduts();
        Produto GetProdutoById(int IdProduto);
    }
}