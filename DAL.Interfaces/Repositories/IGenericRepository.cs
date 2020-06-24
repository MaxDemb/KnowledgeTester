using DAL.Domain.Base;
using DAL.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task CreateAsync(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
