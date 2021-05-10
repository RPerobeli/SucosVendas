using Sucos_Vendas.Domain;
using Sucos_Vendas.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sucos_Vendas.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public IList<Cliente> GetByBairro(string bairro)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByCEP(string cep)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByCidade(string cidade)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByEstado(string estado)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByIdade(int idade)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByLimiteCredito(float limite)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByPrimCompra(bool state)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetBySexo(char sexo)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetByVolumeCompra(float volumeCompra)
        {
            throw new NotImplementedException();
        }

        public void UpdateBairro(string bairro)
        {
            throw new NotImplementedException();
        }

        public void UpdateCEP(string cep)
        {
            throw new NotImplementedException();
        }

        public void UpdateCidade(string cidade)
        {
            throw new NotImplementedException();
        }

        public void UpdateEndereco(string endereco)
        {
            throw new NotImplementedException();
        }

        public void UpdateEstado(string estado)
        {
            throw new NotImplementedException();
        }

        public void UpdateIdade(int idade)
        {
            throw new NotImplementedException();
        }

        public void UpdateLimiteCredito(float novoLimite)
        {
            throw new NotImplementedException();
        }

        public void UpdatePrimCompra(bool state)
        {
            throw new NotImplementedException();
        }

        public void UpdateSexo(char sexo)
        {
            throw new NotImplementedException();
        }

        public void UpdateVolumeCompra(float novoValor)
        {
            throw new NotImplementedException();
        }
    }
}
