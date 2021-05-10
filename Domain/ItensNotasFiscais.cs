using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sucos_Vendas.Domain
{
    public class ItensNotasFiscais
    {
        public int Numero { get; set; }
        public string CodProduto { get; set; }
        public int Quantidade { get; set; }
        public float Preço { get; set; }
        public Produto Produto { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
    }
}
