using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Application.Interfaces.UnitOfWork;
using ETicaret.Persistance.Contexts;
using ETicaret.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly TicaretContext _ticaretContext;

        public UnitOfWork(TicaretContext ticaretContext)
        {
            _ticaretContext = ticaretContext;
        }


        public async ValueTask DisposeAsync()
        {
           await _ticaretContext.DisposeAsync();
        }

        public int Save()
        {
          return _ticaretContext.SaveChanges();
        }

        public async Task<int> SaveAsync() => await _ticaretContext.SaveChangesAsync();



        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_ticaretContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(_ticaretContext);
        



    }
}
