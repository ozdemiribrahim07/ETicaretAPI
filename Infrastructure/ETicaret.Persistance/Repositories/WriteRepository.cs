using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Persistance.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {

        private readonly DbContext _dbContext;

        public WriteRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private DbSet<T> Table { get => _dbContext.Set<T>(); }



        public async Task AddAsync(T t)
        {
            await Table.AddAsync(t);
        }



        public async Task AddRangeAsync(IList<T> t)
        {
            await Table.AddRangeAsync(t);
        }


        public async Task HardDeleteAsync(T t)
        {
            await Task.Run(() => Table.Remove(t));
        }


        public async Task<T> UpdateAsync(T t)
        {
            await Task.Run(() => Table.Update(t));
            return t;
        }

    }
}
