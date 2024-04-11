using ComicApp.Domain.Entities;
using ComicApp.Domain.Repositories.Commands;
using ComicApp.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Infrastructure.Repositories.Commands
{
    public class ComicCharacterCommandRepository : BaseCommandRepository<ComicCharacter>, IComicCharacterCommandRepository
    {
        public ComicCharacterCommandRepository(ComicDbContext comicDbContext) : base(comicDbContext)
        {
            
        }
    }
}
