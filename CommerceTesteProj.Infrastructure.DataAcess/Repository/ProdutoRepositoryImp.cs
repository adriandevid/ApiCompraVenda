using System.Linq;
using CommerceTesteProj.Domain.Interface;
using CommerceTesteProj.Domain.Models;
using CommerceTesteProj.Infrastructure.DataAcess.Context;

namespace CommerceTesteProj.Infrastructure.DataAcess.Repository
{
    public class ProdutoRepositoryImp : ProdutoRepository
    {
        private ProdutoContext Context;
        public ProdutoRepositoryImp(ProdutoContext ProdutoContext)
        {
            Context = ProdutoContext;
        }
        public void Add(Produto entity)
        {
            Context.Add(entity);
        }

        public Produto[] GetAllProduts()
        {
            return Context.Set<Produto>().ToArray();
        }

        public Produto GetProdutoById(int IdProduto)
        {
            return Context.Set<Produto>().Find(IdProduto);
        }

        public void Remove(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpDate(Produto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}