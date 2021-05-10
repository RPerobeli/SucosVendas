using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sucos_Vendas.Domain
{
    public class Vendedor
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public float Comissao { get; set; }
        public DateTime Admissao { get; set; }
        public bool Ferias { get; set; }
        public string Bairro { get; set; }
        public IList<NotaFiscal> NotasFiscais {get; set;}
    }
}
