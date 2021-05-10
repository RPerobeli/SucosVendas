using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sucos_Vendas.Domain
{
    public class NotaFiscal
    {
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime Data { get; set; }
        public int Numero { get; set; }
        public float Imposto { get; set; }
        public IList<ItensNotasFiscais> ItensNotasFiscais { get; set; }
        public Vendedor Vendedores { get; set; }
        public Cliente Clientes { get; set; }
    }
}
