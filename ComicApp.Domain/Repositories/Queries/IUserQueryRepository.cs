using ComicApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Domain.Repositories.Queries
{
    public interface IUserQueryRepository : IBaseQueryRepository<User>
    {
        Task<User> GetByUsername(string username);
    }
}
