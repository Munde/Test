using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Domain.Repositories
{
    public interface IRepository<TEntity>
    {
        //read operation
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(Guid id);

        //Create
        Task<TEntity> CreateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> CreateRangeAsync(IEnumerable<TEntity> entities);

        //Delete 
        Task<TEntity> DeleteAsync(TEntity entity);
    }
}
