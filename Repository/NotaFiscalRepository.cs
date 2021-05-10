using Sucos_Vendas.Domain;
using Sucos_Vendas.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sucos_Vendas.Repository
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        public IList<NotaFiscal> GetByCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public IList<NotaFiscal> GetByNumero(int numero)
        {
            throw new NotImplementedException();
        }

        public IList<NotaFiscal> GetByPreco(float preco)
        {
            throw new NotImplementedException();
        }

        public IList<NotaFiscal> GetByQuantidade(int quantidade)
        {
            throw new NotImplementedException();
        }

        public void UpdatePreco(float preco)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuantidade(int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
