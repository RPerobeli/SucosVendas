using System;
using System.Collections.Generic;

namespace Sucos_Vendas.Domain
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereço1 { get; set; }
        public string Endereço2 { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public float LimiteCredito { get; set; }
        public float VolumeCompra { get; set; }
        public bool PrimeiraCompra { get; set; }
        public IList<NotaFiscal> NotasFiscais { get; set; }
    }
}
