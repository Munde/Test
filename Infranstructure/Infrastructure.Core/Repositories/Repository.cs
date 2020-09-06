using Core.Entities.Domain.Repositories;

using Infrastructure.Core.Data;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Repositories
{
    internal class Repository<TEntity> : IRepository<TEntity>
    {
        private ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.AddRangeAsync(entities);
            return entities;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            await Task.Run(()=>_context.Remove(entity));
            return entity;
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
