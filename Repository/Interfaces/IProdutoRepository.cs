using Sucos_Vendas.Domain;
using System.Collections.Generic;

namespace Sucos_Vendas.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        IList<Produto> GetByCodigo(string cpf);
        IList<Produto> GetByNome(string nome);
        IList<Produto> GetByEmbalagem(string embalagem);
        IList<Produto> GetByTamanho(string tamanho);
        IList<Produto> GetBySabor(string sabor);
        IList<Produto> GetByPreco(float preco);
        void UpdateNome(string nome);
        void UpdateEmbalagem(string embalagem);
        void UpdateTamanho(string tamanho);
        void UpdateSabor(string sabor);
        void UpdatePreco(float preco);
    }
}
