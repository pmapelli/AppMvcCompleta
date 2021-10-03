using System;
using Bussines.Models;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}