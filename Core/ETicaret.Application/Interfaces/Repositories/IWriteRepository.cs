using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase , new()
    {
        Task AddAsync(T t); //Gerçekleşip gerçekleşmediğini görmek için Task içerisinde int kullanıldı.
        Task AddRangeAsync(IList<T> t);

        Task HardDeleteAsync(T t);

        Task<T> UpdateAsync(T t);


    }
}
