using Sucos_Vendas.Domain;
using Sucos_Vendas.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Sucos_Vendas.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public IList<Produto> GetByCodigo(string cpf)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> GetByEmbalagem(string embalagem)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> GetByPreco(float preco)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> GetBySabor(string sabor)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> GetByTamanho(string tamanho)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmbalagem(string embalagem)
        {
            throw new NotImplementedException();
        }

        public void UpdateNome(string nome)
        {
            throw new NotImplementedException();
        }

        public void UpdatePreco(float preco)
        {
            throw new NotImplementedException();
        }

        public void UpdateSabor(string sabor)
        {
            throw new NotImplementedException();
        }

        public void UpdateTamanho(string tamanho)
        {
            throw new NotImplementedException();
        }
    }
}
