using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();

        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();

        int Save();

        Task<int> SaveAsync();

        

    }
}
