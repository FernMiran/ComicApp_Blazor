using ComicApp.Domain.Entities;
using ComicApp.Domain.Repositories.Commands;
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
    public class UserQueryRepository : BaseQueryRepository<User>, IUserQueryRepository
    {
        public UserQueryRepository(ComicDbContext context) : base(context)
        {
        }

        public async Task<User> GetByUsername(string username)
        {
            return await _dbSet
                .Where(user => user.Username.ToLower() == username.ToLower())
                .FirstOrDefaultAsync();
        }
    }
}
