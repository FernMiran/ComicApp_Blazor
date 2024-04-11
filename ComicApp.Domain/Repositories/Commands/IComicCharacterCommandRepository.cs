using ComicApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Domain.Repositories.Commands
{
    public interface IComicCharacterCommandRepository : IBaseCommandRepository<ComicCharacter>
    {
    }
}
