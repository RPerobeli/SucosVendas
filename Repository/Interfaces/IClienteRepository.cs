using Sucos_Vendas.Domain;
using System;
using System.Collections.Generic;

namespace Sucos_Vendas.Repository.Interfaces
{
    public interface IClienteRepository
    {
        IList<Cliente> GetByCpf(string cpf);
        IList<Cliente> GetByNome(string nome);
        IList<Cliente> GetByBairro(string bairro);
        IList<Cliente> GetByCidade(string cidade);
        IList<Cliente> GetByEstado(string estado);
        IList<Cliente> GetByCEP(string cep);
        IList<Cliente> GetByIdade(int idade);
        IList<Cliente> GetBySexo(char sexo);
        IList<Cliente> GetByData(DateTime data);
        IList<Cliente> GetByLimiteCredito(float limite);
        IList<Cliente> GetByVolumeCompra(float volumeCompra);
        IList<Cliente> GetByPrimCompra(bool state);
        void UpdateEndereco(string endereco);
        void UpdateBairro(string bairro);
        void UpdateCidade(string cidade);
        void UpdateEstado(string estado);
        void UpdateCEP(string cep);
        void UpdateIdade(int idade);
        void UpdateSexo(char sexo);
        void UpdateLimiteCredito(float novoLimite);
        void UpdateVolumeCompra(float novoValor);
        void UpdatePrimCompra(bool state);

    }
}
