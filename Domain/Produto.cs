using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sucos_Vendas.Domain
{
    public class Produto
    {
        public string  CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Embalagem { get; set; }
        public string Tamanho { get; set; }
        public string Sabor { get; set; }
        public float Preco { get; set; }
        public IList<ItensNotasFiscais> ItensNotasFiscais { get; set; }
    }
}
