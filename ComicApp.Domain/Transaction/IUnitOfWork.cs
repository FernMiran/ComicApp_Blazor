using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Domain.Transaction
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
