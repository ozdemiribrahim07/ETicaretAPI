using ETicaret.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> where T : class , IEntityBase, new()
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, 
                                              Func<IQueryable<T>, IIncludableQueryable<T,object>>? include = null,
                                              Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                              bool enableTracking = false);

        Task<IList<T>> GetAllAsyncByPaging(Expression<Func<T, bool>>? filter = null,
                                              Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                              Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                              bool enableTracking = false, int currentage = 1, int pageSize = 5);


        Task<T> GetAsync(Expression<Func<T, bool>> filter,
                                              Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                              bool enableTracking = false);

        Task<int> CountAsync(Expression<Func<T, bool>>? filter = null);

        IQueryable<T> Find(Expression<Func<T, bool>> filter);
    }


}
