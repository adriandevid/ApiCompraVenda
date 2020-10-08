using System.Collections.Generic;
using System.Threading.Tasks;
using CommerceTesteProj.Domain.Interface;
using CommerceTesteProj.Domain.Models;

namespace CommerceTesteProj.Domain.Service
{
    public class ProdutoServiceImp : ProdutoService
    {
        private ProdutoRepository Repository; 
        public ProdutoServiceImp(ProdutoRepository ProdutoRepository)
        {
            Repository = ProdutoRepository;           
        }

        public void Add(Produto entity)
        {
            Repository.Add(entity);
        }

        public Produto[] GetAllProduts()
        {
            return Repository.GetAllProduts();
        }

        public Produto GetProdutoById(int IdProduto)
        {
            return Repository.GetProdutoById(IdProduto);
        }

        public void Remove(Produto entity)
        {
            Repository.Remove(entity);
        }

        public void SaveChanges()
        {
            Repository.SaveChanges();
        }

        public void UpDate(Produto entity)
        {
            Repository.UpDate(entity);
        }
    }
}