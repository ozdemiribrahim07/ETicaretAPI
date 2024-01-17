using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class , IEntityBase , new()
    {
        private readonly DbContext _dbContext;

        public ReadRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private DbSet<T> Table { get => _dbContext.Set<T>(); }

       



        public async Task<int> CountAsync(Expression<Func<T, bool>>? filter = null)
        {
            Table.AsNoTracking();
            if (filter != null)
            {
                Table.Where(filter);
            }

            return await Table.CountAsync();
        }





        public IQueryable<T> Find(Expression<Func<T, bool>> filter)
        {
           return Table.Where(filter);
        }






        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            IQueryable<T> query = Table;

            if (!enableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }

            return await query.ToListAsync();
        }



        public async Task<IList<T>> GetAllAsyncByPaging(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentage = 1, int pageSize = 5)
        {

            IQueryable<T> query = Table;

            if (!enableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return await orderBy(query).Skip((currentage-1)* pageSize).Take(pageSize).ToListAsync();
            }

            return await query.Skip((currentage - 1) * pageSize).Take(pageSize).ToListAsync();
        }




        public async Task<T> GetAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {

            IQueryable<T> query = Table;

            if (!enableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            return await query.FirstOrDefaultAsync(filter);
        }




    }
}
