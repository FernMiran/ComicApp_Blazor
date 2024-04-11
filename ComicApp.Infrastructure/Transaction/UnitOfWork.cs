using ComicApp.Domain.Transaction;
using ComicApp.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Infrastructure.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private ComicDbContext _dbContext;

        public UnitOfWork(ComicDbContext context)
        {
            _dbContext = context;
        }


        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
