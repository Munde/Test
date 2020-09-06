
using Core.Entities.Domain.UOW;

using Infrastructure.Core.Data;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.UOW
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            //all migration has been runned
            _context.Database.Migrate();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveSync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
