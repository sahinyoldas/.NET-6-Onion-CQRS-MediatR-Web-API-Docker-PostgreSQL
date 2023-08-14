using OnionArchitecture.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Interfaces.Repository
{
    public interface IGeneralRepository<T> where T : BaseEntity
    {
        Task<T> GetById(long itemId);
        Task<T> Save(T item);
        Task<T> Update(T item);
        Task Delete(T item);
        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>>? filter = null);
    }
}
