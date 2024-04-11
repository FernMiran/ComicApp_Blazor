using ComicApp.Domain.Repositories.Commands;
using ComicApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Infrastructure.Repositories.Commands
{
    public abstract class BaseCommandRepository<T> : IBaseCommandRepository<T> where T : class
    {
        protected readonly ComicDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseCommandRepository(ComicDbContext comicDbContext)
        {
            _context = comicDbContext;
            _dbSet = _context.Set<T>();
        }

        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task Update(T entity)
        {
            _dbSet.Entry(entity).State = EntityState.Modified;
        }
    }
}
