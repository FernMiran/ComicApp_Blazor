using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Domain.Repositories.Commands
{
    public interface IBaseCommandRepository<T> where T : class
    {
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
