using Sucos_Vendas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sucos_Vendas.Repository.Interfaces
{
    public interface INotaFiscalRepository
    {
        IList<NotaFiscal> GetByNumero(int numero);
        IList<NotaFiscal> GetByCodigo(string codigo);
        IList<NotaFiscal> GetByQuantidade(int quantidade);
        IList<NotaFiscal> GetByPreco(float preco);
        void UpdateQuantidade(int quantidade);
        void UpdatePreco(float preco);
    }
}
