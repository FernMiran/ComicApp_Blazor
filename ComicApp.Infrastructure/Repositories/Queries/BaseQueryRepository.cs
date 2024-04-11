using ComicApp.Domain.Repositories.Queries;
using ComicApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Infrastructure.Repositories.Queries
{
    public abstract class BaseQueryRepository<T> : IBaseQueryRepository<T> where T : class
    {
        protected ComicDbContext _context;
        protected DbSet<T> _dbSet;

        public BaseQueryRepository(ComicDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
    }
}
