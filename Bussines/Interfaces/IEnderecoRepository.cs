using System;
using Bussines.Models;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}